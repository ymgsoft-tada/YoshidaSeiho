
//
// ※このプログラムはDBAutoProperties2Access2000により自動的に生成されました。(fj)
//
// MDB File :
//		D:\client\DotNet4.6_YMGLib5\Yoshidaseiho\WinYS\WinYS\bin\Debug\system\Data.mdb
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
	public partial class k_SuitochoKeihi : FieldProp
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
		/// フィールド[出納帳経費ID]。
		/// </summary>
		public const string FID_SuitochoKeihi = "ID_SuitochoKeihi";
		/// <summary>
		/// 出納帳経費ID
		/// </summary>
		public int ID_SuitochoKeihi
		{
			get	{	return Cast.Int(row == null ? null : row[FID_SuitochoKeihi]);	}
			set	{	_set(FID_SuitochoKeihi, value);	}
		}
		
		/// <summary>
		/// 出納帳経費ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_SuitochoKeihi_Null
		{
			get	{	if (row == null || row[FID_SuitochoKeihi] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_SuitochoKeihi]); }	}
			set	{	_set(FID_SuitochoKeihi, value);	}
		}
		
		/// <summary>
		/// フィールド[出納帳ID]。
		/// </summary>
		public const string FID_Suitocho = "ID_Suitocho";
		/// <summary>
		/// 出納帳ID
		/// </summary>
		public int ID_Suitocho
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Suitocho]);	}
			set	{	_set(FID_Suitocho, value);	}
		}
		
		/// <summary>
		/// 出納帳ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Suitocho_Null
		{
			get	{	if (row == null || row[FID_Suitocho] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Suitocho]); }	}
			set	{	_set(FID_Suitocho, value);	}
		}
		
		/// <summary>
		/// フィールド[日付]。
		/// </summary>
		public const string FSuitocho_KeihiDate = "Suitocho_KeihiDate";
		/// <summary>
		/// 日付
		/// </summary>
		public string Suitocho_KeihiDate
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiDate]);	}
			set	{	_set(FSuitocho_KeihiDate, value);	}
		}
		
		/// <summary>
		/// 日付。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_KeihiDate_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiDate] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiDate]); }	}
			set	{	_set(FSuitocho_KeihiDate, value);	}
		}
		
		/// <summary>
		/// フィールド[費目]。
		/// </summary>
		public const string FSuitocho_KeihiHimoku = "Suitocho_KeihiHimoku";
		/// <summary>
		/// 費目
		/// </summary>
		public string Suitocho_KeihiHimoku
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiHimoku]);	}
			set	{	_set(FSuitocho_KeihiHimoku, value);	}
		}
		
		/// <summary>
		/// 費目。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_KeihiHimoku_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiHimoku] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiHimoku]); }	}
			set	{	_set(FSuitocho_KeihiHimoku, value);	}
		}
		
		/// <summary>
		/// フィールド[金額]。
		/// </summary>
		public const string FSuitocho_KeihiCost = "Suitocho_KeihiCost";
		/// <summary>
		/// 金額
		/// </summary>
		public decimal Suitocho_KeihiCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiCost]);	}
			set	{	_set(FSuitocho_KeihiCost, value);	}
		}
		
		/// <summary>
		/// 金額。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_KeihiCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiCost]); }	}
			set	{	_set(FSuitocho_KeihiCost, value);	}
		}
		
		/// <summary>
		/// フィールド[内消費税]。
		/// </summary>
		public const string FSuitocho_KeihiShohizei = "Suitocho_KeihiShohizei";
		/// <summary>
		/// 内消費税
		/// </summary>
		public decimal Suitocho_KeihiShohizei
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiShohizei]);	}
			set	{	_set(FSuitocho_KeihiShohizei, value);	}
		}
		
		/// <summary>
		/// 内消費税。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_KeihiShohizei_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShohizei] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiShohizei]); }	}
			set	{	_set(FSuitocho_KeihiShohizei, value);	}
		}
		
		/// <summary>
		/// フィールド[車名]。
		/// </summary>
		public const string FSuitocho_KeihiSharyo = "Suitocho_KeihiSharyo";
		/// <summary>
		/// 車名
		/// </summary>
		public string Suitocho_KeihiSharyo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiSharyo]);	}
			set	{	_set(FSuitocho_KeihiSharyo, value);	}
		}
		
		/// <summary>
		/// 車名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_KeihiSharyo_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiSharyo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiSharyo]); }	}
			set	{	_set(FSuitocho_KeihiSharyo, value);	}
		}
		
		/// <summary>
		/// フィールド[支払者]。
		/// </summary>
		public const string FSuitocho_KeihiShiharaiUser = "Suitocho_KeihiShiharaiUser";
		/// <summary>
		/// 支払者
		/// </summary>
		public string Suitocho_KeihiShiharaiUser
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiShiharaiUser]);	}
			set	{	_set(FSuitocho_KeihiShiharaiUser, value);	}
		}
		
		/// <summary>
		/// 支払者。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_KeihiShiharaiUser_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShiharaiUser] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiShiharaiUser]); }	}
			set	{	_set(FSuitocho_KeihiShiharaiUser, value);	}
		}
		
		/// <summary>
		/// フィールド[メモ]。
		/// </summary>
		public const string FSuitocho_KeihiMemo = "Suitocho_KeihiMemo";
		/// <summary>
		/// メモ
		/// </summary>
		public string Suitocho_KeihiMemo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_KeihiMemo]);	}
			set	{	_set(FSuitocho_KeihiMemo, value);	}
		}
		
		/// <summary>
		/// メモ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_KeihiMemo_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiMemo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_KeihiMemo]); }	}
			set	{	_set(FSuitocho_KeihiMemo, value);	}
		}
		
		/// <summary>
		/// フィールド[小計（金額）]。
		/// </summary>
		public const string FSuitocho_KeihiLeaseTotalCost = "Suitocho_KeihiLeaseTotalCost";
		/// <summary>
		/// 小計（金額）
		/// </summary>
		public decimal Suitocho_KeihiLeaseTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiLeaseTotalCost]);	}
			set	{	_set(FSuitocho_KeihiLeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// 小計（金額）。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_KeihiLeaseTotalCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiLeaseTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiLeaseTotalCost]); }	}
			set	{	_set(FSuitocho_KeihiLeaseTotalCost, value);	}
		}
		
		/// <summary>
		/// フィールド[小計（消費税）]。
		/// </summary>
		public const string FSuitocho_KeihiShohizeiTotalCost = "Suitocho_KeihiShohizeiTotalCost";
		/// <summary>
		/// 小計（消費税）
		/// </summary>
		public decimal Suitocho_KeihiShohizeiTotalCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiShohizeiTotalCost]);	}
			set	{	_set(FSuitocho_KeihiShohizeiTotalCost, value);	}
		}
		
		/// <summary>
		/// 小計（消費税）。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_KeihiShohizeiTotalCost_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiShohizeiTotalCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiShohizeiTotalCost]); }	}
			set	{	_set(FSuitocho_KeihiShohizeiTotalCost, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_SuitochoKeihi(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_SuitochoKeihi 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_SuitochoKeihi 型の空テーブル</returns>
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
