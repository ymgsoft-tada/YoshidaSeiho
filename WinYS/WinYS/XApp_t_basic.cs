
//
// �����̃v���O������DBAutoProperties2Access2000�ɂ�莩���I�ɐ�������܂����B(fj)
//
// MDB File :
//		D:\client\DotNet4.6_YMGLib5\YoshidaSeiho\WinYS\WinYS\bin\Debug\system\Data.mdb
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

using ComponentIO;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// �e�[�u���ҏW�̍ۂɎg���N���X�ł��B
	/// </summary>
	public partial class t_basic : FieldProp
	{
		/// <summary>
		/// �t�B�[���h[Access ���������p]�B
		/// </summary>
		public const string FID_Auto = "ID_Auto";
		/// <summary>
		/// Access ���������p
		/// </summary>
		public int ID_Auto
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Auto]);	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// Access ���������p�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Auto_Null
		{
			get	{	if (row == null || row[FID_Auto] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Auto]); }	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��Ж�]�B
		/// </summary>
		public const string FBAS_Name = "BAS_Name";
		/// <summary>
		/// ��Ж�
		/// </summary>
		public string BAS_Name
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Name]);	}
			set	{	_set(FBAS_Name, value);	}
		}
		
		/// <summary>
		/// ��Ж��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Name_Null
		{
			get	{	if (row == null || row[FBAS_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Name]); }	}
			set	{	_set(FBAS_Name, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��Ж��t���K�i]�B
		/// </summary>
		public const string FBAS_NameFurigana = "BAS_NameFurigana";
		/// <summary>
		/// ��Ж��t���K�i
		/// </summary>
		public string BAS_NameFurigana
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameFurigana]);	}
			set	{	_set(FBAS_NameFurigana, value);	}
		}
		
		/// <summary>
		/// ��Ж��t���K�i�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_NameFurigana_Null
		{
			get	{	if (row == null || row[FBAS_NameFurigana] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameFurigana]); }	}
			set	{	_set(FBAS_NameFurigana, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��\�Җ�]�B
		/// </summary>
		public const string FBAS_NameDaihyo = "BAS_NameDaihyo";
		/// <summary>
		/// ��\�Җ�
		/// </summary>
		public string BAS_NameDaihyo
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameDaihyo]);	}
			set	{	_set(FBAS_NameDaihyo, value);	}
		}
		
		/// <summary>
		/// ��\�Җ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_NameDaihyo_Null
		{
			get	{	if (row == null || row[FBAS_NameDaihyo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameDaihyo]); }	}
			set	{	_set(FBAS_NameDaihyo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��Ж�2]�B
		/// </summary>
		public const string FBAS_Name2 = "BAS_Name2";
		/// <summary>
		/// ��Ж�2
		/// </summary>
		public string BAS_Name2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Name2]);	}
			set	{	_set(FBAS_Name2, value);	}
		}
		
		/// <summary>
		/// ��Ж�2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Name2_Null
		{
			get	{	if (row == null || row[FBAS_Name2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Name2]); }	}
			set	{	_set(FBAS_Name2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��\�Җ�2]�B
		/// </summary>
		public const string FBAS_NameDaihyo2 = "BAS_NameDaihyo2";
		/// <summary>
		/// ��\�Җ�2
		/// </summary>
		public string BAS_NameDaihyo2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameDaihyo2]);	}
			set	{	_set(FBAS_NameDaihyo2, value);	}
		}
		
		/// <summary>
		/// ��\�Җ�2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_NameDaihyo2_Null
		{
			get	{	if (row == null || row[FBAS_NameDaihyo2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameDaihyo2]); }	}
			set	{	_set(FBAS_NameDaihyo2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�X�֔ԍ�]�B
		/// </summary>
		public const string FBAS_Post = "BAS_Post";
		/// <summary>
		/// �X�֔ԍ�
		/// </summary>
		public string BAS_Post
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Post]);	}
			set	{	_set(FBAS_Post, value);	}
		}
		
		/// <summary>
		/// �X�֔ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Post_Null
		{
			get	{	if (row == null || row[FBAS_Post] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Post]); }	}
			set	{	_set(FBAS_Post, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z���P]�B
		/// </summary>
		public const string FBAS_Addr1 = "BAS_Addr1";
		/// <summary>
		/// �Z���P
		/// </summary>
		public string BAS_Addr1
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Addr1]);	}
			set	{	_set(FBAS_Addr1, value);	}
		}
		
		/// <summary>
		/// �Z���P�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Addr1_Null
		{
			get	{	if (row == null || row[FBAS_Addr1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Addr1]); }	}
			set	{	_set(FBAS_Addr1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z���Q]�B
		/// </summary>
		public const string FBAS_Addr2 = "BAS_Addr2";
		/// <summary>
		/// �Z���Q
		/// </summary>
		public string BAS_Addr2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Addr2]);	}
			set	{	_set(FBAS_Addr2, value);	}
		}
		
		/// <summary>
		/// �Z���Q�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Addr2_Null
		{
			get	{	if (row == null || row[FBAS_Addr2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Addr2]); }	}
			set	{	_set(FBAS_Addr2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�d�b�P]�B
		/// </summary>
		public const string FBAS_Tel1 = "BAS_Tel1";
		/// <summary>
		/// �d�b�P
		/// </summary>
		public string BAS_Tel1
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Tel1]);	}
			set	{	_set(FBAS_Tel1, value);	}
		}
		
		/// <summary>
		/// �d�b�P�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Tel1_Null
		{
			get	{	if (row == null || row[FBAS_Tel1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Tel1]); }	}
			set	{	_set(FBAS_Tel1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�d�b2]�B
		/// </summary>
		public const string FBAS_Tel2 = "BAS_Tel2";
		/// <summary>
		/// �d�b2
		/// </summary>
		public string BAS_Tel2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Tel2]);	}
			set	{	_set(FBAS_Tel2, value);	}
		}
		
		/// <summary>
		/// �d�b2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Tel2_Null
		{
			get	{	if (row == null || row[FBAS_Tel2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Tel2]); }	}
			set	{	_set(FBAS_Tel2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[FAX]�B
		/// </summary>
		public const string FBAS_Fax = "BAS_Fax";
		/// <summary>
		/// FAX
		/// </summary>
		public string BAS_Fax
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Fax]);	}
			set	{	_set(FBAS_Fax, value);	}
		}
		
		/// <summary>
		/// FAX�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_Fax_Null
		{
			get	{	if (row == null || row[FBAS_Fax] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Fax]); }	}
			set	{	_set(FBAS_Fax, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[DBVersion]�B
		/// </summary>
		public const string FBAS_DBVersion = "BAS_DBVersion";
		/// <summary>
		/// DBVersion
		/// </summary>
		public string BAS_DBVersion
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_DBVersion]);	}
			set	{	_set(FBAS_DBVersion, value);	}
		}
		
		/// <summary>
		/// DBVersion�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_DBVersion_Null
		{
			get	{	if (row == null || row[FBAS_DBVersion] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_DBVersion]); }	}
			set	{	_set(FBAS_DBVersion, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ŏI�f�[�^�擾���t]�B
		/// </summary>
		public const string FBAS_LastDateDownload = "BAS_LastDateDownload";
		/// <summary>
		/// �ŏI�f�[�^�擾���t
		/// </summary>
		public DateTime BAS_LastDateDownload
		{
			get	{	return Cast.DateTime(row == null ? null : row[FBAS_LastDateDownload]);	}
			set	{	_set(FBAS_LastDateDownload, value);	}
		}
		
		/// <summary>
		/// �ŏI�f�[�^�擾���t�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? BAS_LastDateDownload_Null
		{
			get	{	if (row == null || row[FBAS_LastDateDownload] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FBAS_LastDateDownload]); }	}
			set	{	_set(FBAS_LastDateDownload, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�V�X�e���p�X���[�h]�B
		/// </summary>
		public const string FBAS_SystemPWD = "BAS_SystemPWD";
		/// <summary>
		/// �V�X�e���p�X���[�h
		/// </summary>
		public string BAS_SystemPWD
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_SystemPWD]);	}
			set	{	_set(FBAS_SystemPWD, value);	}
		}
		
		/// <summary>
		/// �V�X�e���p�X���[�h�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string BAS_SystemPWD_Null
		{
			get	{	if (row == null || row[FBAS_SystemPWD] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_SystemPWD]); }	}
			set	{	_set(FBAS_SystemPWD, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[[�v����]�ŏI�X�V����]�B
		/// </summary>
		public const string FLastUpdate = "LastUpdate";
		/// <summary>
		/// [�v����]�ŏI�X�V����
		/// </summary>
		public DateTime LastUpdate
		{
			get	{	return Cast.DateTime(row == null ? null : row[FLastUpdate]);	}
			set	{	_set_datetime(FLastUpdate, value);	}
		}
		
		/// <summary>
		/// [�v����]�ŏI�X�V�����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? LastUpdate_Null
		{
			get	{	if (row == null || row[FLastUpdate] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FLastUpdate]); }	}
			set	{	_set_datetime(FLastUpdate, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public t_basic(object o) : base(o) {}
		#endregion
		/// <summary>
		/// t_basic �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>t_basic �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("t_basic");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameFurigana, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameDaihyo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 50;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Name2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameDaihyo2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 50;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Post, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Addr1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Addr2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Tel1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Tel2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Fax, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_DBVersion, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_LastDateDownload, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_SystemPWD, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FLastUpdate, typeof(DateTime));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
