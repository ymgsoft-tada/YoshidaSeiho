using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Diagnostics;

using ComponentDB;
using ComponentIO;
using ComponentFile;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// DB �A�b�v�f�[�g���s���܂��B
	/// </summary>
	public class AppDbUpdateManager
	{
		#region *** Private Value ***
		/// <summary>
		/// �ϊ��Ώ� t_basic ���B
		/// </summary>
		static t_basic		modsys = null;
		/// <summary>
		/// Update ���ʁB
		/// </summary>
		static bool			result;
		#endregion
		
		#region *** Property Value ***
		/// <summary>
		/// Update ���ʂ��擾���܂��B
		/// </summary>
		public static bool Result
		{
			get
			{
				return result;
			}
		}
		#endregion
		
		#region *** Public Method ***
		/// <summary>
		/// �o�[�W�������X�V���܂��B
		/// </summary>
		/// <returns>true..�����A�������͕K�v�Ȃ�, false..���s</returns>
		public static void UpdateVersion(object sender, DoWorkEventArgsEx e)
		{
			FormBg_Progress		bgform	= (FormBg_Progress)sender;
			
			const string		backupfile = "backup.tmp";
			string				modfile = Cast.String(e.Args[0]);
			string				seefile = Cast.String(e.Args[1]);
			
			// �o�[�W�����A�b�v�O�̃t�@�C����ۑ��B
			FileIO.Copy(modfile, backupfile);
			
			DB		moddb = new DB(modfile, AppConst.AppDBPassword);
			DB		seedb = new DB(seefile, AppConst.AppDBPassword);
			DBView	moddv_sys = new DBView(new DBAdapter(moddb, TableProp.t_basic));
			DBView	seedv_sys = new DBView(new DBAdapter(seedb, TableProp.t_basic));
			
			AppDbUpdateHistory.eVersion eVer = checkUpperVersion(moddv_sys);

			// �ϊ��̕K�v�Ȃ��B�iVersion���T�[�o�[��荂�����A�`�F�b�N����肭�ł��Ȃ��j
			if (eVer != AppDbUpdateHistory.eVersion.Lower)
			{
				// �i���o�[�̍X�V�B
				if (bgform != null) bgform.FinishProgress();
				return;
			}
			
			//�� �ϊ��Ώۂ� HistoryList �������B
			string	modver_str = "0.0.0";
			int		modhis;

			if (moddv_sys.Contains(t_basic.FBAS_DBVersion) == true)
			{
				modver_str = modsys.BAS_DBVersion;
			}
			
			for (modhis = 0; modhis < AppDbUpdate.History.Length; modhis++)
			{
				if (AppDbUpdate.History[modhis].CheckNeedVersionUp(modver_str) == true)
				{
					break;
				}
			}
			// �o�[�W�����A�b�v�ɂ��ϊ��̕K�v�Ȃ��B�iVersion�����グ��j
			if (modhis == AppDbUpdate.History.Length)
			{
				modsys.BAS_DBVersion = AppConst.AppDBVersion;
				moddv_sys.Update();
				
				// �i���o�[�̍X�V�B
				if (bgform != null) bgform.FinishProgress();
				
				result = true;
				return;
			}
			
			// mod 0.99.00 see 1.01.00 �ŁA���X�g��
			//		1.00.02
			//		1.00.05
			// �̂Q�Ȃ�A1.00.05 �܂Ńf�[�^�x�[�X���X�V���Ȃ���΂����Ȃ��B
			
			//�� �ϊ��Q�Ƃ� HistoryList �������B
			int[]	seever = AppDbUpdateHistory.VersionToArray(AppConst.AppDBVersion);
			int		seehis;
			
			for (seehis = 0; seehis < AppDbUpdate.History.Length; seehis++)
			{
				if (AppDbUpdate.History[seehis].Version == seever)
				{
					// mod 0.99.00 see 0.99.07 �ŁA���X�g��
					//		0.99.07
					// �̂P�Ȃ�Amodhis �� 0�Aseehis �� 1 �ɂȂ��Ă���K�v������̂ŁA�P�𑫂��B
					seehis++;
					break;
				}
			}
			
			//�� DB�o�[�W�����A�b�v�������s���B
			for (int i = modhis; i < seehis; i++)
			{
				// verup��db���ύX����Ă���\��������̂ŁA����擾����
				moddb = new DB(modfile, AppConst.AppDBPassword);

				bool succeed = AppDbUpdate.History[i].UpdateMethod(moddb, seedb);
				
				if (succeed == false)
				{
					// �o�[�W�����A�b�v�O�̃t�@�C���ɖ߂��B
					FileIO.Copy(backupfile, modfile);
					FileIO.Delete(backupfile);
					
					// �ϊ����s�B
					result = false;
					return;
				}

				// �i���o�[�̍X�V�B
				if (bgform != null) bgform.SetProgress(100 * (i-modhis+1) / (seehis - modhis));
			}

			moddb.DelAdapter(moddv_sys.DBAdapter);
			moddv_sys = null;

			// �����B
			moddv_sys = new DBView(new DBAdapter(moddb, TableProp.t_basic));
			if (moddv_sys.Count > 0)
			{
				modsys = new t_basic(moddv_sys[0].Row);
				modsys.BAS_DBVersion = AppConst.AppDBVersion;
				moddv_sys.Update();
			}
			
			// �i���o�[�̍X�V�B
			if (bgform != null) bgform.FinishProgress();
			
			// �o�[�W�����A�b�v�O�̃o�b�N�A�b�v�t�@�C���������B
			FileIO.Delete(backupfile);
			
			result = true;
			return;
		}
		
		/// <summary>
		/// �o�[�W�������������`�F�b�N���܂��B
		/// </summary>
		/// <param name="modfile">�ϊ��Ώ�DB�t�@�C�����B</param>
		public static AppDbUpdateHistory.eVersion CheckUpperVersion(string modfile)
		{
			DB		moddb = new DB(modfile, AppConst.AppDBPassword);
			DBView	moddv_sys = new DBView(new DBAdapter(moddb, TableProp.t_basic));
			
			AppDbUpdateHistory.eVersion ret = checkUpperVersion(moddv_sys);

			//�� �`�F�b�N����DB���������B
			moddb.Close();
			moddb.Dispose();
			moddb = null;

			return ret;
		}

		/// <summary>
		/// �w��t�@�C������o�[�W���������擾���܂��B
		/// </summary>
		/// <param name="modfile">�Ώۂc�a�t�@�C��</param>
		public static string GetVersion(string modfile)
		{
			DB		moddb = new DB(modfile, AppConst.AppDBPassword);
			DBView	moddv_sys = new DBView(new DBAdapter(moddb, TableProp.t_basic));

			string ver = "";
			if (moddv_sys.CurrentRow != null)
			{
				ver = Cast.String(moddv_sys[t_basic.FBAS_DBVersion]);
			}

			//�� �`�F�b�N����DB���������B
			moddb.Close();
			moddb.Dispose();
			moddb = null;

			return ver;
		}
		
		/// <summary>
		/// �o�[�W�������������`�F�b�N���܂��B
		/// </summary>
		/// <param name="moddv_sys">�ϊ��Ώ�DB�B</param>
		static AppDbUpdateHistory.eVersion checkUpperVersion(DBView moddv_sys)
		{
			// T_System �̓��e��ۑ��B
			modsys	= null;
			if (moddv_sys.Count > 0)
			{
				modsys	= new t_basic(moddv_sys[0]);
			}
			
			// Version �̃`�F�b�N���ł��Ȃ��B
			if (modsys == null)
			{
				return AppDbUpdateHistory.eVersion.None;
			}

			// DBVerup�p�t�B�[���h������
			if (modsys.Row.Table.Columns.Contains(t_basic.FBAS_DBVersion) == false)
			{
				return AppDbUpdateHistory.eVersion.Lower;
			}

			// Version �͔�r�Q�Ƃ�荂���H
			return AppDbUpdateHistory.CheckVersion(AppConst.AppDBVersion, modsys.BAS_DBVersion);
		}
		#endregion
		
		#region *** Private Method ***
		/// <summary>
		/// �G���[�\���BDEBUG���ł̂ݗL���ł�
		/// </summary>
		[Conditional("DEBUG")]
		static void _write_err(Exception ex)
		{
			Debug.WriteLine("������ Exception");
			Debug.WriteLine("Source     = {0}", ex.Source);
			Debug.WriteLine("Type       = {0}", ex.GetType().ToString());
			Debug.WriteLine("Message    = {0}", ex.Message);
			Debug.WriteLine("StackTrace = {0}", ex.StackTrace);
			Debug.WriteLine("");
		}
		#endregion
	}
}
