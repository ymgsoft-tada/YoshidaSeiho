
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
	public partial class k_Suitocho : FieldProp
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
		/// �t�B�[���h[�N���x]�B
		/// </summary>
		public const string FSuitocho_Date = "Suitocho_Date";
		/// <summary>
		/// �N���x
		/// </summary>
		public DateTime Suitocho_Date
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSuitocho_Date]);	}
			set	{	_set(FSuitocho_Date, value);	}
		}
		
		/// <summary>
		/// �N���x�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Suitocho_Date_Null
		{
			get	{	if (row == null || row[FSuitocho_Date] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSuitocho_Date]); }	}
			set	{	_set(FSuitocho_Date, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Č���]�B
		/// </summary>
		public const string FSuitocho_AnkenName = "Suitocho_AnkenName";
		/// <summary>
		/// �Č���
		/// </summary>
		public string Suitocho_AnkenName
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_AnkenName]);	}
			set	{	_set(FSuitocho_AnkenName, value);	}
		}
		
		/// <summary>
		/// �Č����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Suitocho_AnkenName_Null
		{
			get	{	if (row == null || row[FSuitocho_AnkenName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_AnkenName]); }	}
			set	{	_set(FSuitocho_AnkenName, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X��]�B
		/// </summary>
		public const string FSuitocho_LeaseCost = "Suitocho_LeaseCost";
		/// <summary>
		/// ���[�X��
		/// </summary>
		public decimal Suitocho_LeaseCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_LeaseCost]);	}
			set	{	_set(FSuitocho_LeaseCost, value);	}
		}
		
		/// <summary>
		/// ���[�X���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_LeaseCost_Null
		{
			get	{	if (row == null || row[FSuitocho_LeaseCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_LeaseCost]); }	}
			set	{	_set(FSuitocho_LeaseCost, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�o��Z�z]�B
		/// </summary>
		public const string FSuitocho_KeihiSeisan = "Suitocho_KeihiSeisan";
		/// <summary>
		/// �o��Z�z
		/// </summary>
		public decimal Suitocho_KeihiSeisan
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiSeisan]);	}
			set	{	_set(FSuitocho_KeihiSeisan, value);	}
		}
		
		/// <summary>
		/// �o��Z�z�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_KeihiSeisan_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiSeisan] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiSeisan]); }	}
			set	{	_set(FSuitocho_KeihiSeisan, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�����Z���z]�B
		/// </summary>
		public const string FSuitocho_Miseisan = "Suitocho_Miseisan";
		/// <summary>
		/// �����Z���z
		/// </summary>
		public decimal Suitocho_Miseisan
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_Miseisan]);	}
			set	{	_set(FSuitocho_Miseisan, value);	}
		}
		
		/// <summary>
		/// �����Z���z�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Suitocho_Miseisan_Null
		{
			get	{	if (row == null || row[FSuitocho_Miseisan] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_Miseisan]); }	}
			set	{	_set(FSuitocho_Miseisan, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_Suitocho(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Suitocho �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_Suitocho �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_Suitocho");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Suitocho, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_Date, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_AnkenName, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_LeaseCost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_KeihiSeisan, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSuitocho_Miseisan, typeof(decimal));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
