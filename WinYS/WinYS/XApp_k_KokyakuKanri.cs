
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
	public partial class k_KokyakuKanri : FieldProp
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
		/// �t�B�[���h[�ڋqID]�B
		/// </summary>
		public const string FID_Kokyaku = "ID_Kokyaku";
		/// <summary>
		/// �ڋqID
		/// </summary>
		public int ID_Kokyaku
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Kokyaku]);	}
			set	{	_set(FID_Kokyaku, value);	}
		}
		
		/// <summary>
		/// �ڋqID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Kokyaku_Null
		{
			get	{	if (row == null || row[FID_Kokyaku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Kokyaku]); }	}
			set	{	_set(FID_Kokyaku, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ڋq��]�B
		/// </summary>
		public const string FKokyaku_Name = "Kokyaku_Name";
		/// <summary>
		/// �ڋq��
		/// </summary>
		public string Kokyaku_Name
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Name]);	}
			set	{	_set(FKokyaku_Name, value);	}
		}
		
		/// <summary>
		/// �ڋq���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Name_Null
		{
			get	{	if (row == null || row[FKokyaku_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Name]); }	}
			set	{	_set(FKokyaku_Name, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�h��]�B
		/// </summary>
		public const string FKokyaku_Keisho = "Kokyaku_Keisho";
		/// <summary>
		/// �h��
		/// </summary>
		public string Kokyaku_Keisho
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Keisho]);	}
			set	{	_set(FKokyaku_Keisho, value);	}
		}
		
		/// <summary>
		/// �h�́BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Keisho_Null
		{
			get	{	if (row == null || row[FKokyaku_Keisho] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Keisho]); }	}
			set	{	_set(FKokyaku_Keisho, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�t���K�i]�B
		/// </summary>
		public const string FKokyaku_NameFurigana = "Kokyaku_NameFurigana";
		/// <summary>
		/// �t���K�i
		/// </summary>
		public string Kokyaku_NameFurigana
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_NameFurigana]);	}
			set	{	_set(FKokyaku_NameFurigana, value);	}
		}
		
		/// <summary>
		/// �t���K�i�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_NameFurigana_Null
		{
			get	{	if (row == null || row[FKokyaku_NameFurigana] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_NameFurigana]); }	}
			set	{	_set(FKokyaku_NameFurigana, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�S����]�B
		/// </summary>
		public const string FKokyaku_TantoshaName = "Kokyaku_TantoshaName";
		/// <summary>
		/// �S����
		/// </summary>
		public string Kokyaku_TantoshaName
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_TantoshaName]);	}
			set	{	_set(FKokyaku_TantoshaName, value);	}
		}
		
		/// <summary>
		/// �S���ҁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_TantoshaName_Null
		{
			get	{	if (row == null || row[FKokyaku_TantoshaName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_TantoshaName]); }	}
			set	{	_set(FKokyaku_TantoshaName, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ǘ��ԍ�]�B
		/// </summary>
		public const string FKokyaku_KanriNumber = "Kokyaku_KanriNumber";
		/// <summary>
		/// �Ǘ��ԍ�
		/// </summary>
		public string Kokyaku_KanriNumber
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_KanriNumber]);	}
			set	{	_set(FKokyaku_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �Ǘ��ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_KanriNumber_Null
		{
			get	{	if (row == null || row[FKokyaku_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_KanriNumber]); }	}
			set	{	_set(FKokyaku_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��]�B
		/// </summary>
		public const string FKokyaku_Zip1 = "Kokyaku_Zip1";
		/// <summary>
		/// ��
		/// </summary>
		public string Kokyaku_Zip1
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Zip1]);	}
			set	{	_set(FKokyaku_Zip1, value);	}
		}
		
		/// <summary>
		/// ���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Zip1_Null
		{
			get	{	if (row == null || row[FKokyaku_Zip1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Zip1]); }	}
			set	{	_set(FKokyaku_Zip1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z��1]�B
		/// </summary>
		public const string FKokyaku_Address1 = "Kokyaku_Address1";
		/// <summary>
		/// �Z��1
		/// </summary>
		public string Kokyaku_Address1
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address1]);	}
			set	{	_set(FKokyaku_Address1, value);	}
		}
		
		/// <summary>
		/// �Z��1�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Address1_Null
		{
			get	{	if (row == null || row[FKokyaku_Address1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address1]); }	}
			set	{	_set(FKokyaku_Address1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z��2]�B
		/// </summary>
		public const string FKokyaku_Address2 = "Kokyaku_Address2";
		/// <summary>
		/// �Z��2
		/// </summary>
		public string Kokyaku_Address2
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address2]);	}
			set	{	_set(FKokyaku_Address2, value);	}
		}
		
		/// <summary>
		/// �Z��2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Address2_Null
		{
			get	{	if (row == null || row[FKokyaku_Address2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address2]); }	}
			set	{	_set(FKokyaku_Address2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�d�b�ԍ�1]�B
		/// </summary>
		public const string FKokyaku_Tel1 = "Kokyaku_Tel1";
		/// <summary>
		/// �d�b�ԍ�1
		/// </summary>
		public int Kokyaku_Tel1
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel1]);	}
			set	{	_set(FKokyaku_Tel1, value);	}
		}
		
		/// <summary>
		/// �d�b�ԍ�1�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Tel1_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel1] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel1]); }	}
			set	{	_set(FKokyaku_Tel1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�d�b�ԍ�2]�B
		/// </summary>
		public const string FKokyaku_Tel2 = "Kokyaku_Tel2";
		/// <summary>
		/// �d�b�ԍ�2
		/// </summary>
		public int Kokyaku_Tel2
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel2]);	}
			set	{	_set(FKokyaku_Tel2, value);	}
		}
		
		/// <summary>
		/// �d�b�ԍ�2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Tel2_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel2] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel2]); }	}
			set	{	_set(FKokyaku_Tel2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�d�b�ԍ�3]�B
		/// </summary>
		public const string FKokyaku_Tel3 = "Kokyaku_Tel3";
		/// <summary>
		/// �d�b�ԍ�3
		/// </summary>
		public int Kokyaku_Tel3
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel3]);	}
			set	{	_set(FKokyaku_Tel3, value);	}
		}
		
		/// <summary>
		/// �d�b�ԍ�3�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Tel3_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel3] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel3]); }	}
			set	{	_set(FKokyaku_Tel3, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[FAX�ԍ�1]�B
		/// </summary>
		public const string FKokyaku_Fax1 = "Kokyaku_Fax1";
		/// <summary>
		/// FAX�ԍ�1
		/// </summary>
		public int Kokyaku_Fax1
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax1]);	}
			set	{	_set(FKokyaku_Fax1, value);	}
		}
		
		/// <summary>
		/// FAX�ԍ�1�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Fax1_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax1] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax1]); }	}
			set	{	_set(FKokyaku_Fax1, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[FAX�ԍ�2]�B
		/// </summary>
		public const string FKokyaku_Fax2 = "Kokyaku_Fax2";
		/// <summary>
		/// FAX�ԍ�2
		/// </summary>
		public int Kokyaku_Fax2
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax2]);	}
			set	{	_set(FKokyaku_Fax2, value);	}
		}
		
		/// <summary>
		/// FAX�ԍ�2�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Fax2_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax2] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax2]); }	}
			set	{	_set(FKokyaku_Fax2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[FAX�ԍ�3]�B
		/// </summary>
		public const string FKokyaku_Fax3 = "Kokyaku_Fax3";
		/// <summary>
		/// FAX�ԍ�3
		/// </summary>
		public int Kokyaku_Fax3
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax3]);	}
			set	{	_set(FKokyaku_Fax3, value);	}
		}
		
		/// <summary>
		/// FAX�ԍ�3�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Kokyaku_Fax3_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax3] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax3]); }	}
			set	{	_set(FKokyaku_Fax3, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[���A�h���X]�B
		/// </summary>
		public const string FKokyaku_Mail = "Kokyaku_Mail";
		/// <summary>
		/// ���[���A�h���X
		/// </summary>
		public string Kokyaku_Mail
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Mail]);	}
			set	{	_set(FKokyaku_Mail, value);	}
		}
		
		/// <summary>
		/// ���[���A�h���X�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Mail_Null
		{
			get	{	if (row == null || row[FKokyaku_Mail] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Mail]); }	}
			set	{	_set(FKokyaku_Mail, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���S���Җ�]�B
		/// </summary>
		public const string FKokyaku_LeaseTantosha = "Kokyaku_LeaseTantosha";
		/// <summary>
		/// ���S���Җ�
		/// </summary>
		public string Kokyaku_LeaseTantosha
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_LeaseTantosha]);	}
			set	{	_set(FKokyaku_LeaseTantosha, value);	}
		}
		
		/// <summary>
		/// ���S���Җ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_LeaseTantosha_Null
		{
			get	{	if (row == null || row[FKokyaku_LeaseTantosha] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_LeaseTantosha]); }	}
			set	{	_set(FKokyaku_LeaseTantosha, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�A���悪�قȂ�ꍇ��]�B
		/// </summary>
		public const string FKokyaku_Zip2 = "Kokyaku_Zip2";
		/// <summary>
		/// �A���悪�قȂ�ꍇ��
		/// </summary>
		public string Kokyaku_Zip2
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Zip2]);	}
			set	{	_set(FKokyaku_Zip2, value);	}
		}
		
		/// <summary>
		/// �A���悪�قȂ�ꍇ���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Zip2_Null
		{
			get	{	if (row == null || row[FKokyaku_Zip2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Zip2]); }	}
			set	{	_set(FKokyaku_Zip2, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z��3]�B
		/// </summary>
		public const string FKokyaku_Address3 = "Kokyaku_Address3";
		/// <summary>
		/// �Z��3
		/// </summary>
		public string Kokyaku_Address3
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address3]);	}
			set	{	_set(FKokyaku_Address3, value);	}
		}
		
		/// <summary>
		/// �Z��3�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Address3_Null
		{
			get	{	if (row == null || row[FKokyaku_Address3] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address3]); }	}
			set	{	_set(FKokyaku_Address3, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Z��4]�B
		/// </summary>
		public const string FKokyaku_Address4 = "Kokyaku_Address4";
		/// <summary>
		/// �Z��4
		/// </summary>
		public string Kokyaku_Address4
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address4]);	}
			set	{	_set(FKokyaku_Address4, value);	}
		}
		
		/// <summary>
		/// �Z��4�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Address4_Null
		{
			get	{	if (row == null || row[FKokyaku_Address4] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address4]); }	}
			set	{	_set(FKokyaku_Address4, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���l]�B
		/// </summary>
		public const string FKokyaku_Memo = "Kokyaku_Memo";
		/// <summary>
		/// ���l
		/// </summary>
		public string Kokyaku_Memo
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Memo]);	}
			set	{	_set(FKokyaku_Memo, value);	}
		}
		
		/// <summary>
		/// ���l�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Kokyaku_Memo_Null
		{
			get	{	if (row == null || row[FKokyaku_Memo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Memo]); }	}
			set	{	_set(FKokyaku_Memo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_KokyakuKanri(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_KokyakuKanri �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_KokyakuKanri �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_KokyakuKanri");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Kokyaku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Keisho, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_NameFurigana, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_TantoshaName, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_KanriNumber, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Zip1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel1, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel2, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel3, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax1, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax2, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax3, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Mail, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_LeaseTantosha, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Zip2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address3, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address4, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Memo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
