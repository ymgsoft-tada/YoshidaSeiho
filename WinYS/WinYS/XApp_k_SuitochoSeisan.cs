
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
	public partial class k_SuitochoSeisan : FieldProp
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
		/// �t�B�[���h[�o�[�����ZID]�B
		/// </summary>
		public const string FID_SuitochoSeisan = "ID_SuitochoSeisan";
		/// <summary>
		/// �o�[�����ZID
		/// </summary>
		public int ID_SuitochoSeisan
		{
			get	{	return Cast.Int(row == null ? null : row[FID_SuitochoSeisan]);	}
			set	{	_set(FID_SuitochoSeisan, value);	}
		}
		
		/// <summary>
		/// �o�[�����ZID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_SuitochoSeisan_Null
		{
			get	{	if (row == null || row[FID_SuitochoSeisan] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_SuitochoSeisan]); }	}
			set	{	_set(FID_SuitochoSeisan, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�o�[��ID]�B
		/// </summary>
		public const string FID_Suitocho = "ID_Suitocho";
		/// <summary>
		/// �o�[��ID
		/// </summary>
		public int ID_Suitocho
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Suitocho]);	}
			set	{	_set(FID_Suitocho, value);	}
		}
		
		/// <summary>
		/// �o�[��ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Suitocho_Null
		{
			get	{	if (row == null || row[FID_Suitocho] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Suitocho]); }	}
			set	{	_set(FID_Suitocho, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���t]�B
		/// </summary>
		public const string FSuitocho_SeisanDate = "Suitocho_SeisanDate";
		/// <summary>
		/// ���t
		/// </summary>
		public DateTime Suitocho_SeisanDate
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSuitocho_SeisanDate]);	}
			set	{	_set(FSuitocho_SeisanDate, value);	}
		}
		
		/// <summary>
		/// ���t�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Suitocho_SeisanDate_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanDate] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSuitocho_SeisanDate]); }	}
			set	{	_set(FSuitocho_SeisanDate, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[������e]�B
		/// </summary>
		public const string FSuitocho_SeisanTorihiki = "Suitocho_SeisanTorihiki";
		/// <summary>
		/// ������e
		/// </summary>
		public string Suitocho_SeisanTorihiki
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_SeisanTorihiki]);	}
			set	{	_set(FSuitocho_SeisanTorihiki, value);	}
		}
		
		/// <summary>
		/// ������e�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_SeisanTorihiki_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanTorihiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_SeisanTorihiki]); }	}
			set	{	_set(FSuitocho_SeisanTorihiki, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���z]�B
		/// </summary>
		public const string FSuitocho_SeisanCost = "Suitocho_SeisanCost";
		/// <summary>
		/// ���z
		/// </summary>
		public decimal Suitocho_SeisanCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_SeisanCost]);	}
			set	{	_set(FSuitocho_SeisanCost, value);	}
		}
		
		/// <summary>
		/// ���z�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_SeisanCost_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_SeisanCost]); }	}
			set	{	_set(FSuitocho_SeisanCost, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�������]�B
		/// </summary>
		public const string FSuitocho_SeisanShohizei = "Suitocho_SeisanShohizei";
		/// <summary>
		/// �������
		/// </summary>
		public decimal Suitocho_SeisanShohizei
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_SeisanShohizei]);	}
			set	{	_set(FSuitocho_SeisanShohizei, value);	}
		}
		
		/// <summary>
		/// ������ŁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_SeisanShohizei_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanShohizei] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_SeisanShohizei]); }	}
			set	{	_set(FSuitocho_SeisanShohizei, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[����]�B
		/// </summary>
		public const string FSuitocho_SeisanMemo = "Suitocho_SeisanMemo";
		/// <summary>
		/// ����
		/// </summary>
		public string Suitocho_SeisanMemo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_SeisanMemo]);	}
			set	{	_set(FSuitocho_SeisanMemo, value);	}
		}
		
		/// <summary>
		/// �����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_SeisanMemo_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanMemo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_SeisanMemo]); }	}
			set	{	_set(FSuitocho_SeisanMemo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_SuitochoSeisan(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_SuitochoSeisan �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_SuitochoSeisan �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_SuitochoSeisan");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_SuitochoSeisan, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Suitocho, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_SeisanDate, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_SeisanTorihiki, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_SeisanCost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_SeisanShohizei, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_SeisanMemo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
