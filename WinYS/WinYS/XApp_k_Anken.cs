
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
	public partial class k_Anken : FieldProp
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
		/// �t�B�[���h[�s�ԍ�]�B
		/// </summary>
		public const string FID_Anken = "ID_Anken";
		/// <summary>
		/// �s�ԍ�
		/// </summary>
		public int ID_Anken
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Anken]);	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// �s�ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Anken_Null
		{
			get	{	if (row == null || row[FID_Anken] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Anken]); }	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Č���]�B
		/// </summary>
		public const string FAnken_Name = "Anken_Name";
		/// <summary>
		/// �Č���
		/// </summary>
		public string Anken_Name
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_Name]);	}
			set	{	_set(FAnken_Name, value);	}
		}
		
		/// <summary>
		/// �Č����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_Name_Null
		{
			get	{	if (row == null || row[FAnken_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_Name]); }	}
			set	{	_set(FAnken_Name, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ǘ��ԍ�]�B
		/// </summary>
		public const string FAnken_KanriNumber = "Anken_KanriNumber";
		/// <summary>
		/// �Ǘ��ԍ�
		/// </summary>
		public string Anken_KanriNumber
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KanriNumber]);	}
			set	{	_set(FAnken_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �Ǘ��ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_KanriNumber_Null
		{
			get	{	if (row == null || row[FAnken_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KanriNumber]); }	}
			set	{	_set(FAnken_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ڋq��]�B
		/// </summary>
		public const string FAnken_KokyakuName = "Anken_KokyakuName";
		/// <summary>
		/// �ڋq��
		/// </summary>
		public string Anken_KokyakuName
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KokyakuName]);	}
			set	{	_set(FAnken_KokyakuName, value);	}
		}
		
		/// <summary>
		/// �ڋq���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_KokyakuName_Null
		{
			get	{	if (row == null || row[FAnken_KokyakuName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KokyakuName]); }	}
			set	{	_set(FAnken_KokyakuName, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�S����]�B
		/// </summary>
		public const string FAnken_KokyakuTantosha = "Anken_KokyakuTantosha";
		/// <summary>
		/// �S����
		/// </summary>
		public string Anken_KokyakuTantosha
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KokyakuTantosha]);	}
			set	{	_set(FAnken_KokyakuTantosha, value);	}
		}
		
		/// <summary>
		/// �S���ҁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_KokyakuTantosha_Null
		{
			get	{	if (row == null || row[FAnken_KokyakuTantosha] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KokyakuTantosha]); }	}
			set	{	_set(FAnken_KokyakuTantosha, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X���� �J�n��]�B
		/// </summary>
		public const string FAnken_DateFrom = "Anken_DateFrom";
		/// <summary>
		/// ���[�X���� �J�n��
		/// </summary>
		public DateTime Anken_DateFrom
		{
			get	{	return Cast.DateTime(row == null ? null : row[FAnken_DateFrom]);	}
			set	{	_set(FAnken_DateFrom, value);	}
		}
		
		/// <summary>
		/// ���[�X���� �J�n���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Anken_DateFrom_Null
		{
			get	{	if (row == null || row[FAnken_DateFrom] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FAnken_DateFrom]); }	}
			set	{	_set(FAnken_DateFrom, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X���� �I����]�B
		/// </summary>
		public const string FAnken_DateTo = "Anken_DateTo";
		/// <summary>
		/// ���[�X���� �I����
		/// </summary>
		public DateTime Anken_DateTo
		{
			get	{	return Cast.DateTime(row == null ? null : row[FAnken_DateTo]);	}
			set	{	_set(FAnken_DateTo, value);	}
		}
		
		/// <summary>
		/// ���[�X���� �I�����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Anken_DateTo_Null
		{
			get	{	if (row == null || row[FAnken_DateTo] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FAnken_DateTo]); }	}
			set	{	_set(FAnken_DateTo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X���v���z]�B
		/// </summary>
		public const string FAnken_LeaseTotalCost = "Anken_LeaseTotalCost";
		/// <summary>
		/// ���[�X���v���z
		/// </summary>
		public decimal Anken_LeaseTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FAnken_LeaseTotalCost]);	}
			set	{	_set(FAnken_LeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// ���[�X���v���z�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Anken_LeaseTotalCost_Null
		{
			get	{	if (row == null || row[FAnken_LeaseTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FAnken_LeaseTotalCost]); }	}
			set	{	_set(FAnken_LeaseTotalCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_Anken(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Anken �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_Anken �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_Anken");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Anken, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_KanriNumber, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_KokyakuName, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_KokyakuTantosha, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_DateFrom, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_DateTo, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseTotalCost, typeof(decimal));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
