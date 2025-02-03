using System;
using System.Collections.Generic;
using System.Text;

using ComponentDB;
using System.Diagnostics;
using ComponentDebug;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// DB �A�b�v�f�[�g�̎��s���\�b�h�������X�g�B
	/// </summary>
	public partial class AppDbUpdate
	{
		//
		// �Q�l�T�C�g�B
		//		�e�[�u���̍\����ύX����N�G���iALTER TABLE�j
		//			http://www.nurs.or.jp/~ppoy/access/access/acQ020.html
		//		�f�[�^�^
		//			http://www.nurs.or.jp/~ppoy/access/access/acEt019.html
		//
		#region *** Public Value ***
		/// <summary>
		/// DB �X�V�����B
		/// </summary>
		public static AppDbUpdateHistory[]		History;
		#endregion		



		#region *** Private Method ***
		/// <summary>
		/// �e�[�u���Ɏw�肵���t�B�[���h�����݂��邩DAO�Ń`�F�N���܂��B
		/// </summary>
		/// <param name="db"></param>
		/// <param name="tbl">�e�[�u��</param>
		/// <param name="fld">�t�B�[���h</param>
		static bool checkExistFieldForDAO(DAO.Database db, string tbl, string fld)
		{
			if (db != null)
			{
				try
				{
					if (checkExistTableForDAO(db, tbl) == true)
					{
						for (int i = 0; i < db.TableDefs[tbl].Fields.Count; i++)
						{
							if (db.TableDefs[tbl].Fields[i].Name == fld)
							{
								return true;
							}
						}
					}
				}
				catch
				{
					ErrLog.WriteLine("{0}:{1}�ɂ��āADAO����t�B�[���h�m�F�Ɏ��s���܂����B", tbl, fld);
				}
			}

			return false;
		}

		/// <summary>
		/// �e�[�u���Ɏw�肵���t�B�[���h�����݂��邩�`�F�N���܂��B
		/// </summary>
		/// <param name="db">db</param>
		/// <param name="tbl">�e�[�u����</param>
		static bool checkExistTableForDAO(DAO.Database db, string tbl)
		{
			try
			{
				if (db != null)
				{
					for (int i = 0; i < db.TableDefs.Count; i++)
					{
						if (db.TableDefs[i].Name == tbl)
						{
							return true;
						}
					}
				}
			}
			catch
			{
				ErrLog.WriteLine("{0}�ɂ��āADAO����e�[�u�����̊m�F�Ɏ��s���܂����B",tbl);
			}

			return false;
		}

		/// <summary>
		/// DB����e�[�u�����폜���܂��B�iDAO���Ə����Ȃ��e�[�u���ɗL���ł��j
		/// </summary>
		/// <param name="db">DB�I�u�W�F�N�g</param>
		/// <param name="tbl">�e�[�u����</param>
		static bool dropTable(DB db, string tbl)
		{
			List<string> tables = db.GetTableNameList();

			// ��U�e�[�u�����폜����B
			if(db.GetTableNameList().Contains(tbl) == true)
			{
				try
				{
					if (db.DBCon.State == System.Data.ConnectionState.Open)
					{
						db.Close();
					}
					db.ExecuteQuery("DROP TABLE {0}", tbl);
				}
				catch(Exception ex)
				{
					ErrLog.WriteLine("Cannot Drop Table �y{0}�z",tbl);
					ErrLog.WriteException(ex);
				}

				return true;
			}

			return false;
		}
		#endregion
	}

	#region AppDbUpdateHistory
	/// <summary>
	/// [�쐬�� fj]
	/// �A�b�v�f�[�g�����B�o�[�W�����ƁA����ɑΉ�����X�V���\�b�h�������܂��B
	/// </summary>
	public class AppDbUpdateHistory
	{
		/// <summary>
		/// �A�b�v�f�[�g���������s���邽�߂̃C�x���g�n���h���ł��B
		/// </summary>
		/// <param name="moddb">�A�b�v�f�[�g���s�� DB�B</param>
		/// <param name="seedb">�Q�Ɨp�� DB�B</param>
		public delegate bool UpdateHandler(DB moddb, DB seedb);
		
		#region *** Private Value ***
		/// <summary>
		/// �o�[�W�������B
		/// </summary>
		string			version;
		/// <summary>
		/// �A�b�v�f�[�g���\�b�h�B
		/// </summary>
		UpdateHandler	updateMethod;
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// �o�[�W�������B�i������j
		/// </summary>
		public string	VersionStr
		{
			get
			{
				return version;
			}
		}
		/// <summary>
		/// �o�[�W�������B�i�����̔z��j ��F0.10.01��[0][10][1]�A1.00.00��[1][0][0]
		/// </summary>
		public int[]	Version
		{
			get
			{
				return VersionToArray(version);
			}
		}
		
		/// <summary>
		/// �A�b�v�f�[�g���\�b�h
		/// </summary>
		public UpdateHandler UpdateMethod
		{
			get
			{
				return updateMethod;
			}
		}

		/// <summary>
		/// �w�肳�ꂽ�o�[�W�����������̃o�[�W�������Ⴂ�ꍇ�ɁA�o�[�W�����A�b�v�̕K�v�A����Ԃ��܂��B
		/// </summary>
		/// <param name="verstr">�`�F�b�N�������o�[�W����</param>
		/// <returns>�K�v�����true</returns>
		public bool CheckNeedVersionUp(string verstr)
		{
			bool ret = false;

			if (CheckVersion(version, verstr) == eVersion.Lower)
			{
				ret = true;
			}

			return ret;
		}

		/// <summary>
		/// �o�[�W����
		/// </summary>
		public enum eVersion
		{
			/// <summary></summary>
			None,
			/// <summary>���</summary>
			Upper,
			/// <summary>����</summary>
			Lower,
			/// <summary>����</summary>
			Same,
		}

		/// <summary>
		/// �w�茳�Ǝw�����r���ăo�[�W�����̍��ق��`�F�b�N���ĕԂ��܂�
		/// </summary>
		/// <param name="src">�w�茳</param>
		/// <param name="chk">�w���</param>
		/// <returns>�o�[�W�����`�F�b�N</returns>
		public static eVersion CheckVersion(string src, string chk)
		{
			eVersion ret = eVersion.None;
			
			int [] srcVer = VersionToArray(src);
			int [] chkVer = VersionToArray(chk);

			if (srcVer != null && chkVer != null)
			{
				if (srcVer[0] > chkVer[0])
				{
					// ���W���[�o�[�W�����A�b�v
					ret = eVersion.Lower;
				}
				else
				if (srcVer[0] < chkVer[0])
				{
					ret = eVersion.Upper;
				}
				else
				if (srcVer[1] >  chkVer[1])
				{
					// �}�C�i�[�o�[�W�����A�b�v
					ret = eVersion.Lower;
				}
				else
				if (srcVer[1] <  chkVer[1])
				{
					ret = eVersion.Upper;
				}
				else
				if (srcVer[2] >  chkVer[2])
				{
					// ���r�W�����o�[�W�����A�b�v
					ret = eVersion.Lower;
				}
				else
				if (srcVer[2] <  chkVer[2])
				{
					ret = eVersion.Upper;
				}
				else
				{
					ret = eVersion.Same;
				}
			}

			return ret;
		}

		/// <summary>
		/// �o�[�W�������𐔎��̔z��֕ϊ����܂��B ��F0.10.01��[0][10][1]�A1.00.00��[1][0][0]
		/// </summary>
		public static int[] VersionToArray(string verstr)
		{
			string[]	ver_str = System.Text.RegularExpressions.Regex.Split(verstr, @"\.");
			
			if (ver_str.Length != 0 && ver_str.Length != 3)
			{
				Debug.WriteLine("{0}�́A�o�[�W�����̋�؂肪�s���ł��BVersion1.0.0�Ƃ��ăA�b�v�f�[�g���s���܂��B", verstr);

				// �s���ȏꍇ��Version1.0.0�Ƃ��ĔF��������B
				ver_str = new string[]{ "1", "0", "0"};
			}

			int[]		ver		= new int[ver_str.Length];

			for (int i = 0; i < ver_str.Length; i++)
			{
				ver[i] = ComponentIO.Cast.Int(ver_str[i]);
			}

			return ver;
		}
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^�B
		/// </summary>
		/// <param name="_version">�o�[�W������\�������B��F0.10.01</param>
		/// <param name="_updateMethod">�A�b�v�f�[�g���\�b�h�B</param>
		public AppDbUpdateHistory(string _version, UpdateHandler _updateMethod)
		{
			version = _version;
			updateMethod = _updateMethod;
		}
		#endregion
	}
	#endregion
}
