
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
	public partial class k_SuitochoKeihi : FieldProp
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
		/// �t�B�[���h[�o�[���o��ID]�B
		/// </summary>
		public const string FID_SuitochoKeihi = "ID_SuitochoKeihi";
		/// <summary>
		/// �o�[���o��ID
		/// </summary>
		public int ID_SuitochoKeihi
		{
			get	{	return Cast.Int(row == null ? null : row[FID_SuitochoKeihi]);	}
			set	{	_set(FID_SuitochoKeihi, value);	}
		}
		
		/// <summary>
		/// �o�[���o��ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_SuitochoKeihi_Null
		{
			get	{	if (row == null || row[FID_SuitochoKeihi] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_SuitochoKeihi]); }	}
			set	{	_set(FID_SuitochoKeihi, value);	}
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
		public const string FSuitocho_KeihiDate = "Suitocho_KeihiDate";
		/// <summary>
		/// ���t
		/// </summary>
		public string Suitocho_KeihiDate
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiDate]);	}
			set	{	_set(FSuitocho_KeihiDate, value);	}
		}
		
		/// <summary>
		/// ���t�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_KeihiDate_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiDate] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiDate]); }	}
			set	{	_set(FSuitocho_KeihiDate, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���]�B
		/// </summary>
		public const string FSuitocho_KeihiHimoku = "Suitocho_KeihiHimoku";
		/// <summary>
		/// ���
		/// </summary>
		public string Suitocho_KeihiHimoku
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiHimoku]);	}
			set	{	_set(FSuitocho_KeihiHimoku, value);	}
		}
		
		/// <summary>
		/// ��ځBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_KeihiHimoku_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiHimoku] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiHimoku]); }	}
			set	{	_set(FSuitocho_KeihiHimoku, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���z]�B
		/// </summary>
		public const string FSuitocho_KeihiCost = "Suitocho_KeihiCost";
		/// <summary>
		/// ���z
		/// </summary>
		public decimal Suitocho_KeihiCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiCost]);	}
			set	{	_set(FSuitocho_KeihiCost, value);	}
		}
		
		/// <summary>
		/// ���z�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_KeihiCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiCost]); }	}
			set	{	_set(FSuitocho_KeihiCost, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�������]�B
		/// </summary>
		public const string FSuitocho_KeihiShohizei = "Suitocho_KeihiShohizei";
		/// <summary>
		/// �������
		/// </summary>
		public decimal Suitocho_KeihiShohizei
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiShohizei]);	}
			set	{	_set(FSuitocho_KeihiShohizei, value);	}
		}
		
		/// <summary>
		/// ������ŁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_KeihiShohizei_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShohizei] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiShohizei]); }	}
			set	{	_set(FSuitocho_KeihiShohizei, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ԗ�]�B
		/// </summary>
		public const string FSuitocho_KeihiSharyo = "Suitocho_KeihiSharyo";
		/// <summary>
		/// �Ԗ�
		/// </summary>
		public string Suitocho_KeihiSharyo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiSharyo]);	}
			set	{	_set(FSuitocho_KeihiSharyo, value);	}
		}
		
		/// <summary>
		/// �Ԗ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_KeihiSharyo_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiSharyo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiSharyo]); }	}
			set	{	_set(FSuitocho_KeihiSharyo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�x����]�B
		/// </summary>
		public const string FSuitocho_KeihiShiharaiUser = "Suitocho_KeihiShiharaiUser";
		/// <summary>
		/// �x����
		/// </summary>
		public string Suitocho_KeihiShiharaiUser
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiShiharaiUser]);	}
			set	{	_set(FSuitocho_KeihiShiharaiUser, value);	}
		}
		
		/// <summary>
		/// �x���ҁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_KeihiShiharaiUser_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShiharaiUser] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiShiharaiUser]); }	}
			set	{	_set(FSuitocho_KeihiShiharaiUser, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[����]�B
		/// </summary>
		public const string FSuitocho_KeihiMemo = "Suitocho_KeihiMemo";
		/// <summary>
		/// ����
		/// </summary>
		public string Suitocho_KeihiMemo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiMemo]);	}
			set	{	_set(FSuitocho_KeihiMemo, value);	}
		}
		
		/// <summary>
		/// �����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_KeihiMemo_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiMemo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiMemo]); }	}
			set	{	_set(FSuitocho_KeihiMemo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���v�i���z�j]�B
		/// </summary>
		public const string FSuitocho_KeihiLeaseTotalCost = "Suitocho_KeihiLeaseTotalCost";
		/// <summary>
		/// ���v�i���z�j
		/// </summary>
		public decimal Suitocho_KeihiLeaseTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiLeaseTotalCost]);	}
			set	{	_set(FSuitocho_KeihiLeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// ���v�i���z�j�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_KeihiLeaseTotalCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiLeaseTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiLeaseTotalCost]); }	}
			set	{	_set(FSuitocho_KeihiLeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���v�i����Łj]�B
		/// </summary>
		public const string FSuitocho_KeihiShohizeiTotalCost = "Suitocho_KeihiShohizeiTotalCost";
		/// <summary>
		/// ���v�i����Łj
		/// </summary>
		public decimal Suitocho_KeihiShohizeiTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiShohizeiTotalCost]);	}
			set	{	_set(FSuitocho_KeihiShohizeiTotalCost, value);	}
		}
		
		/// <summary>
		/// ���v�i����Łj�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_KeihiShohizeiTotalCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShohizeiTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiShohizeiTotalCost]); }	}
			set	{	_set(FSuitocho_KeihiShohizeiTotalCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_SuitochoKeihi(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_SuitochoKeihi �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_SuitochoKeihi �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_SuitochoKeihi");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_SuitochoKeihi, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Suitocho, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiDate, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiHimoku, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiCost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiShohizei, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiSharyo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiShiharaiUser, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiMemo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiLeaseTotalCost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiShohizeiTotalCost, typeof(decimal));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
