
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
	public partial class k_AnkenLease : FieldProp
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
		/// �t�B�[���h[�_��ԗ�ID]�B
		/// </summary>
		public const string FID_AnkenLease = "ID_AnkenLease";
		/// <summary>
		/// �_��ԗ�ID
		/// </summary>
		public int ID_AnkenLease
		{
			get	{	return Cast.Int(row == null ? null : row[FID_AnkenLease]);	}
			set	{	_set(FID_AnkenLease, value);	}
		}
		
		/// <summary>
		/// �_��ԗ�ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_AnkenLease_Null
		{
			get	{	if (row == null || row[FID_AnkenLease] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_AnkenLease]); }	}
			set	{	_set(FID_AnkenLease, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Č�ID]�B
		/// </summary>
		public const string FID_Anken = "ID_Anken";
		/// <summary>
		/// �Č�ID
		/// </summary>
		public int ID_Anken
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Anken]);	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// �Č�ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Anken_Null
		{
			get	{	if (row == null || row[FID_Anken] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Anken]); }	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ԗ�]�B
		/// </summary>
		public const string FAnken_LeaseSharyoName = "Anken_LeaseSharyoName";
		/// <summary>
		/// �Ԗ�
		/// </summary>
		public string Anken_LeaseSharyoName
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseSharyoName]);	}
			set	{	_set(FAnken_LeaseSharyoName, value);	}
		}
		
		/// <summary>
		/// �Ԗ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_LeaseSharyoName_Null
		{
			get	{	if (row == null || row[FAnken_LeaseSharyoName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseSharyoName]); }	}
			set	{	_set(FAnken_LeaseSharyoName, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�^��]�B
		/// </summary>
		public const string FAnken_LeaseKatashiki = "Anken_LeaseKatashiki";
		/// <summary>
		/// �^��
		/// </summary>
		public string Anken_LeaseKatashiki
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseKatashiki]);	}
			set	{	_set(FAnken_LeaseKatashiki, value);	}
		}
		
		/// <summary>
		/// �^���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_LeaseKatashiki_Null
		{
			get	{	if (row == null || row[FAnken_LeaseKatashiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseKatashiki]); }	}
			set	{	_set(FAnken_LeaseKatashiki, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���]�B
		/// </summary>
		public const string FAnken_LeaseShubetsu = "Anken_LeaseShubetsu";
		/// <summary>
		/// ���
		/// </summary>
		public string Anken_LeaseShubetsu
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseShubetsu]);	}
			set	{	_set(FAnken_LeaseShubetsu, value);	}
		}
		
		/// <summary>
		/// ��ʁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Anken_LeaseShubetsu_Null
		{
			get	{	if (row == null || row[FAnken_LeaseShubetsu] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseShubetsu]); }	}
			set	{	_set(FAnken_LeaseShubetsu, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�o�^�ԍ�]�B
		/// </summary>
		public const string FAnken_LeaseTorokuNumber = "Anken_LeaseTorokuNumber";
		/// <summary>
		/// �o�^�ԍ�
		/// </summary>
		public int Anken_LeaseTorokuNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FAnken_LeaseTorokuNumber]);	}
			set	{	_set(FAnken_LeaseTorokuNumber, value);	}
		}
		
		/// <summary>
		/// �o�^�ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Anken_LeaseTorokuNumber_Null
		{
			get	{	if (row == null || row[FAnken_LeaseTorokuNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FAnken_LeaseTorokuNumber]); }	}
			set	{	_set(FAnken_LeaseTorokuNumber, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X��]�B
		/// </summary>
		public const string FAnken_LeaseCost = "Anken_LeaseCost";
		/// <summary>
		/// ���[�X��
		/// </summary>
		public decimal Anken_LeaseCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FAnken_LeaseCost]);	}
			set	{	_set(FAnken_LeaseCost, value);	}
		}
		
		/// <summary>
		/// ���[�X���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Anken_LeaseCost_Null
		{
			get	{	if (row == null || row[FAnken_LeaseCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FAnken_LeaseCost]); }	}
			set	{	_set(FAnken_LeaseCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_AnkenLease(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_AnkenLease �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_AnkenLease �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_AnkenLease");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_AnkenLease, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Anken, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseSharyoName, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseKatashiki, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseShubetsu, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseTorokuNumber, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FAnken_LeaseCost, typeof(decimal));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
