
//
// ※このプログラムはDBAutoProperties2Access2000により自動的に生成されました。(fj)
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
	/// [作成者 fj]
	/// テーブル編集の際に使うクラスです。
	/// </summary>
	public partial class k_AnkenLease : FieldProp
	{
		/// <summary>
		/// フィールド[Access 高速検索用]。
		/// </summary>
		public const string FID_Auto = "ID_Auto";
		/// <summary>
		/// Access 高速検索用
		/// </summary>
		public int ID_Auto
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Auto]);	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// Access 高速検索用。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Auto_Null
		{
			get	{	if (row == null || row[FID_Auto] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Auto]); }	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// フィールド[契約車両ID]。
		/// </summary>
		public const string FID_AnkenLease = "ID_AnkenLease";
		/// <summary>
		/// 契約車両ID
		/// </summary>
		public int ID_AnkenLease
		{
			get	{	return Cast.Int(row == null ? null : row[FID_AnkenLease]);	}
			set	{	_set(FID_AnkenLease, value);	}
		}
		
		/// <summary>
		/// 契約車両ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_AnkenLease_Null
		{
			get	{	if (row == null || row[FID_AnkenLease] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_AnkenLease]); }	}
			set	{	_set(FID_AnkenLease, value);	}
		}
		
		/// <summary>
		/// フィールド[案件ID]。
		/// </summary>
		public const string FID_Anken = "ID_Anken";
		/// <summary>
		/// 案件ID
		/// </summary>
		public int ID_Anken
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Anken]);	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// 案件ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Anken_Null
		{
			get	{	if (row == null || row[FID_Anken] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Anken]); }	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// フィールド[車名]。
		/// </summary>
		public const string FAnken_LeaseSharyoName = "Anken_LeaseSharyoName";
		/// <summary>
		/// 車名
		/// </summary>
		public string Anken_LeaseSharyoName
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseSharyoName]);	}
			set	{	_set(FAnken_LeaseSharyoName, value);	}
		}
		
		/// <summary>
		/// 車名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_LeaseSharyoName_Null
		{
			get	{	if (row == null || row[FAnken_LeaseSharyoName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseSharyoName]); }	}
			set	{	_set(FAnken_LeaseSharyoName, value);	}
		}
		
		/// <summary>
		/// フィールド[型式]。
		/// </summary>
		public const string FAnken_LeaseKatashiki = "Anken_LeaseKatashiki";
		/// <summary>
		/// 型式
		/// </summary>
		public string Anken_LeaseKatashiki
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseKatashiki]);	}
			set	{	_set(FAnken_LeaseKatashiki, value);	}
		}
		
		/// <summary>
		/// 型式。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_LeaseKatashiki_Null
		{
			get	{	if (row == null || row[FAnken_LeaseKatashiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseKatashiki]); }	}
			set	{	_set(FAnken_LeaseKatashiki, value);	}
		}
		
		/// <summary>
		/// フィールド[種別]。
		/// </summary>
		public const string FAnken_LeaseShubetsu = "Anken_LeaseShubetsu";
		/// <summary>
		/// 種別
		/// </summary>
		public string Anken_LeaseShubetsu
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_LeaseShubetsu]);	}
			set	{	_set(FAnken_LeaseShubetsu, value);	}
		}
		
		/// <summary>
		/// 種別。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_LeaseShubetsu_Null
		{
			get	{	if (row == null || row[FAnken_LeaseShubetsu] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_LeaseShubetsu]); }	}
			set	{	_set(FAnken_LeaseShubetsu, value);	}
		}
		
		/// <summary>
		/// フィールド[登録番号]。
		/// </summary>
		public const string FAnken_LeaseTorokuNumber = "Anken_LeaseTorokuNumber";
		/// <summary>
		/// 登録番号
		/// </summary>
		public int Anken_LeaseTorokuNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FAnken_LeaseTorokuNumber]);	}
			set	{	_set(FAnken_LeaseTorokuNumber, value);	}
		}
		
		/// <summary>
		/// 登録番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Anken_LeaseTorokuNumber_Null
		{
			get	{	if (row == null || row[FAnken_LeaseTorokuNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FAnken_LeaseTorokuNumber]); }	}
			set	{	_set(FAnken_LeaseTorokuNumber, value);	}
		}
		
		/// <summary>
		/// フィールド[リース料]。
		/// </summary>
		public const string FAnken_LeaseCost = "Anken_LeaseCost";
		/// <summary>
		/// リース料
		/// </summary>
		public decimal Anken_LeaseCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FAnken_LeaseCost]);	}
			set	{	_set(FAnken_LeaseCost, value);	}
		}
		
		/// <summary>
		/// リース料。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Anken_LeaseCost_Null
		{
			get	{	if (row == null || row[FAnken_LeaseCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FAnken_LeaseCost]); }	}
			set	{	_set(FAnken_LeaseCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_AnkenLease(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_AnkenLease 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_AnkenLease 型の空テーブル</returns>
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
