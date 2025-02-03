
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
	public partial class k_SuitochoSeisan : FieldProp
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
		/// フィールド[出納帳清算ID]。
		/// </summary>
		public const string FID_SuitochoSeisan = "ID_SuitochoSeisan";
		/// <summary>
		/// 出納帳清算ID
		/// </summary>
		public int ID_SuitochoSeisan
		{
			get	{	return Cast.Int(row == null ? null : row[FID_SuitochoSeisan]);	}
			set	{	_set(FID_SuitochoSeisan, value);	}
		}
		
		/// <summary>
		/// 出納帳清算ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_SuitochoSeisan_Null
		{
			get	{	if (row == null || row[FID_SuitochoSeisan] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_SuitochoSeisan]); }	}
			set	{	_set(FID_SuitochoSeisan, value);	}
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
		public const string FSuitocho_SeisanDate = "Suitocho_SeisanDate";
		/// <summary>
		/// 日付
		/// </summary>
		public DateTime Suitocho_SeisanDate
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSuitocho_SeisanDate]);	}
			set	{	_set(FSuitocho_SeisanDate, value);	}
		}
		
		/// <summary>
		/// 日付。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Suitocho_SeisanDate_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanDate] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSuitocho_SeisanDate]); }	}
			set	{	_set(FSuitocho_SeisanDate, value);	}
		}
		
		/// <summary>
		/// フィールド[取引内容]。
		/// </summary>
		public const string FSuitocho_SeisanTorihiki = "Suitocho_SeisanTorihiki";
		/// <summary>
		/// 取引内容
		/// </summary>
		public string Suitocho_SeisanTorihiki
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_SeisanTorihiki]);	}
			set	{	_set(FSuitocho_SeisanTorihiki, value);	}
		}
		
		/// <summary>
		/// 取引内容。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_SeisanTorihiki_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanTorihiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_SeisanTorihiki]); }	}
			set	{	_set(FSuitocho_SeisanTorihiki, value);	}
		}
		
		/// <summary>
		/// フィールド[金額]。
		/// </summary>
		public const string FSuitocho_SeisanCost = "Suitocho_SeisanCost";
		/// <summary>
		/// 金額
		/// </summary>
		public decimal Suitocho_SeisanCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_SeisanCost]);	}
			set	{	_set(FSuitocho_SeisanCost, value);	}
		}
		
		/// <summary>
		/// 金額。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_SeisanCost_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_SeisanCost]); }	}
			set	{	_set(FSuitocho_SeisanCost, value);	}
		}
		
		/// <summary>
		/// フィールド[内消費税]。
		/// </summary>
		public const string FSuitocho_SeisanShohizei = "Suitocho_SeisanShohizei";
		/// <summary>
		/// 内消費税
		/// </summary>
		public decimal Suitocho_SeisanShohizei
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_SeisanShohizei]);	}
			set	{	_set(FSuitocho_SeisanShohizei, value);	}
		}
		
		/// <summary>
		/// 内消費税。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_SeisanShohizei_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanShohizei] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_SeisanShohizei]); }	}
			set	{	_set(FSuitocho_SeisanShohizei, value);	}
		}
		
		/// <summary>
		/// フィールド[メモ]。
		/// </summary>
		public const string FSuitocho_SeisanMemo = "Suitocho_SeisanMemo";
		/// <summary>
		/// メモ
		/// </summary>
		public string Suitocho_SeisanMemo
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_SeisanMemo]);	}
			set	{	_set(FSuitocho_SeisanMemo, value);	}
		}
		
		/// <summary>
		/// メモ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_SeisanMemo_Null
		{
			get	{	if (row == null || row[FSuitocho_SeisanMemo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_SeisanMemo]); }	}
			set	{	_set(FSuitocho_SeisanMemo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_SuitochoSeisan(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_SuitochoSeisan 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_SuitochoSeisan 型の空テーブル</returns>
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
