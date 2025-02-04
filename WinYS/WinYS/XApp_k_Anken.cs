
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
	public partial class k_Anken : FieldProp
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
		/// フィールド[行番号]。
		/// </summary>
		public const string FID_Anken = "ID_Anken";
		/// <summary>
		/// 行番号
		/// </summary>
		public int ID_Anken
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Anken]);	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// 行番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Anken_Null
		{
			get	{	if (row == null || row[FID_Anken] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Anken]); }	}
			set	{	_set(FID_Anken, value);	}
		}
		
		/// <summary>
		/// フィールド[案件名]。
		/// </summary>
		public const string FAnken_Name = "Anken_Name";
		/// <summary>
		/// 案件名
		/// </summary>
		public string Anken_Name
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_Name]);	}
			set	{	_set(FAnken_Name, value);	}
		}
		
		/// <summary>
		/// 案件名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_Name_Null
		{
			get	{	if (row == null || row[FAnken_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_Name]); }	}
			set	{	_set(FAnken_Name, value);	}
		}
		
		/// <summary>
		/// フィールド[管理番号]。
		/// </summary>
		public const string FAnken_KanriNumber = "Anken_KanriNumber";
		/// <summary>
		/// 管理番号
		/// </summary>
		public string Anken_KanriNumber
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KanriNumber]);	}
			set	{	_set(FAnken_KanriNumber, value);	}
		}
		
		/// <summary>
		/// 管理番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_KanriNumber_Null
		{
			get	{	if (row == null || row[FAnken_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KanriNumber]); }	}
			set	{	_set(FAnken_KanriNumber, value);	}
		}
		
		/// <summary>
		/// フィールド[顧客名]。
		/// </summary>
		public const string FAnken_KokyakuName = "Anken_KokyakuName";
		/// <summary>
		/// 顧客名
		/// </summary>
		public string Anken_KokyakuName
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KokyakuName]);	}
			set	{	_set(FAnken_KokyakuName, value);	}
		}
		
		/// <summary>
		/// 顧客名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_KokyakuName_Null
		{
			get	{	if (row == null || row[FAnken_KokyakuName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KokyakuName]); }	}
			set	{	_set(FAnken_KokyakuName, value);	}
		}
		
		/// <summary>
		/// フィールド[担当者]。
		/// </summary>
		public const string FAnken_KokyakuTantosha = "Anken_KokyakuTantosha";
		/// <summary>
		/// 担当者
		/// </summary>
		public string Anken_KokyakuTantosha
		{
			get	{	return Cast.String(row == null ? null : row[FAnken_KokyakuTantosha]);	}
			set	{	_set(FAnken_KokyakuTantosha, value);	}
		}
		
		/// <summary>
		/// 担当者。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Anken_KokyakuTantosha_Null
		{
			get	{	if (row == null || row[FAnken_KokyakuTantosha] == System.DBNull.Value) { return null; } else { return Cast.String(row[FAnken_KokyakuTantosha]); }	}
			set	{	_set(FAnken_KokyakuTantosha, value);	}
		}
		
		/// <summary>
		/// フィールド[リース期間 開始日]。
		/// </summary>
		public const string FAnken_DateFrom = "Anken_DateFrom";
		/// <summary>
		/// リース期間 開始日
		/// </summary>
		public DateTime Anken_DateFrom
		{
			get	{	return Cast.DateTime(row == null ? null : row[FAnken_DateFrom]);	}
			set	{	_set(FAnken_DateFrom, value);	}
		}
		
		/// <summary>
		/// リース期間 開始日。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Anken_DateFrom_Null
		{
			get	{	if (row == null || row[FAnken_DateFrom] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FAnken_DateFrom]); }	}
			set	{	_set(FAnken_DateFrom, value);	}
		}
		
		/// <summary>
		/// フィールド[リース期間 終了日]。
		/// </summary>
		public const string FAnken_DateTo = "Anken_DateTo";
		/// <summary>
		/// リース期間 終了日
		/// </summary>
		public DateTime Anken_DateTo
		{
			get	{	return Cast.DateTime(row == null ? null : row[FAnken_DateTo]);	}
			set	{	_set(FAnken_DateTo, value);	}
		}
		
		/// <summary>
		/// リース期間 終了日。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Anken_DateTo_Null
		{
			get	{	if (row == null || row[FAnken_DateTo] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FAnken_DateTo]); }	}
			set	{	_set(FAnken_DateTo, value);	}
		}
		
		/// <summary>
		/// フィールド[リース合計金額]。
		/// </summary>
		public const string FAnken_LeaseTotalCost = "Anken_LeaseTotalCost";
		/// <summary>
		/// リース合計金額
		/// </summary>
		public decimal Anken_LeaseTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FAnken_LeaseTotalCost]);	}
			set	{	_set(FAnken_LeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// リース合計金額。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Anken_LeaseTotalCost_Null
		{
			get	{	if (row == null || row[FAnken_LeaseTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FAnken_LeaseTotalCost]); }	}
			set	{	_set(FAnken_LeaseTotalCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_Anken(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Anken 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_Anken 型の空テーブル</returns>
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
