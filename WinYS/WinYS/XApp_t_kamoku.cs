
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
	public partial class t_kamoku : FieldProp
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
		/// �t�B�[���h[�Ȗ�ID]�B
		/// </summary>
		public const string FID_Kamoku = "ID_Kamoku";
		/// <summary>
		/// �Ȗ�ID
		/// </summary>
		public int ID_Kamoku
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Kamoku]);	}
			set	{	_set(FID_Kamoku, value);	}
		}
		
		/// <summary>
		/// �Ȗ�ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Kamoku_Null
		{
			get	{	if (row == null || row[FID_Kamoku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Kamoku]); }	}
			set	{	_set(FID_Kamoku, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�L���g�[���Ȗږ�]�B
		/// </summary>
		public const string FKMK_NameKintone = "KMK_NameKintone";
		/// <summary>
		/// �L���g�[���Ȗږ�
		/// </summary>
		public string KMK_NameKintone
		{
			get	{	return Cast.String(row == null ? null : row[FKMK_NameKintone]);	}
			set	{	_set(FKMK_NameKintone, value);	}
		}
		
		/// <summary>
		/// �L���g�[���Ȗږ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string KMK_NameKintone_Null
		{
			get	{	if (row == null || row[FKMK_NameKintone] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKMK_NameKintone]); }	}
			set	{	_set(FKMK_NameKintone, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�T�N���X�ȖڃR�[�h]�B
		/// </summary>
		public const string FKMK_SakurasCode = "KMK_SakurasCode";
		/// <summary>
		/// �T�N���X�ȖڃR�[�h
		/// </summary>
		public int KMK_SakurasCode
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasCode]);	}
			set	{	_set(FKMK_SakurasCode, value);	}
		}
		
		/// <summary>
		/// �T�N���X�ȖڃR�[�h�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? KMK_SakurasCode_Null
		{
			get	{	if (row == null || row[FKMK_SakurasCode] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasCode]); }	}
			set	{	_set(FKMK_SakurasCode, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�T�N���X�⏕�ȖڃR�[�h]�B
		/// </summary>
		public const string FKMK_SakurasCodeHojo = "KMK_SakurasCodeHojo";
		/// <summary>
		/// �T�N���X�⏕�ȖڃR�[�h
		/// </summary>
		public int KMK_SakurasCodeHojo
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasCodeHojo]);	}
			set	{	_set(FKMK_SakurasCodeHojo, value);	}
		}
		
		/// <summary>
		/// �T�N���X�⏕�ȖڃR�[�h�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? KMK_SakurasCodeHojo_Null
		{
			get	{	if (row == null || row[FKMK_SakurasCodeHojo] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasCodeHojo]); }	}
			set	{	_set(FKMK_SakurasCodeHojo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�T�N���X�ېŋ敪�R�[�h]�B
		/// </summary>
		public const string FKMK_SakurasZeiku = "KMK_SakurasZeiku";
		/// <summary>
		/// �T�N���X�ېŋ敪�R�[�h
		/// </summary>
		public int KMK_SakurasZeiku
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasZeiku]);	}
			set	{	_set(FKMK_SakurasZeiku, value);	}
		}
		
		/// <summary>
		/// �T�N���X�ېŋ敪�R�[�h�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? KMK_SakurasZeiku_Null
		{
			get	{	if (row == null || row[FKMK_SakurasZeiku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasZeiku]); }	}
			set	{	_set(FKMK_SakurasZeiku, value);	}
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
		public t_kamoku(object o) : base(o) {}
		#endregion
		/// <summary>
		/// t_kamoku �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>t_kamoku �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("t_kamoku");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Kamoku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_NameKintone, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasCode, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasCodeHojo, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasZeiku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FLastUpdate, typeof(DateTime));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
