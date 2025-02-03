
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
	public partial class k_Suitocho : FieldProp
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
		/// フィールド[年月度]。
		/// </summary>
		public const string FSuitocho_Date = "Suitocho_Date";
		/// <summary>
		/// 年月度
		/// </summary>
		public DateTime Suitocho_Date
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSuitocho_Date]);	}
			set	{	_set(FSuitocho_Date, value);	}
		}
		
		/// <summary>
		/// 年月度。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Suitocho_Date_Null
		{
			get	{	if (row == null || row[FSuitocho_Date] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSuitocho_Date]); }	}
			set	{	_set(FSuitocho_Date, value);	}
		}
		
		/// <summary>
		/// フィールド[案件名]。
		/// </summary>
		public const string FSuitocho_AnkenName = "Suitocho_AnkenName";
		/// <summary>
		/// 案件名
		/// </summary>
		public string Suitocho_AnkenName
		{
			get	{	return Cast.String(row == null ? null : row[FSuitocho_AnkenName]);	}
			set	{	_set(FSuitocho_AnkenName, value);	}
		}
		
		/// <summary>
		/// 案件名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Suitocho_AnkenName_Null
		{
			get	{	if (row == null || row[FSuitocho_AnkenName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSuitocho_AnkenName]); }	}
			set	{	_set(FSuitocho_AnkenName, value);	}
		}
		
		/// <summary>
		/// フィールド[リース料]。
		/// </summary>
		public const string FSuitocho_LeaseCost = "Suitocho_LeaseCost";
		/// <summary>
		/// リース料
		/// </summary>
		public decimal Suitocho_LeaseCost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_LeaseCost]);	}
			set	{	_set(FSuitocho_LeaseCost, value);	}
		}
		
		/// <summary>
		/// リース料。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_LeaseCost_Null
		{
			get	{	if (row == null || row[FSuitocho_LeaseCost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_LeaseCost]); }	}
			set	{	_set(FSuitocho_LeaseCost, value);	}
		}
		
		/// <summary>
		/// フィールド[経費精算額]。
		/// </summary>
		public const string FSuitocho_KeihiSeisan = "Suitocho_KeihiSeisan";
		/// <summary>
		/// 経費精算額
		/// </summary>
		public decimal Suitocho_KeihiSeisan
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_KeihiSeisan]);	}
			set	{	_set(FSuitocho_KeihiSeisan, value);	}
		}
		
		/// <summary>
		/// 経費精算額。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_KeihiSeisan_Null
		{
			get	{	if (row == null || row[FSuitocho_KeihiSeisan] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_KeihiSeisan]); }	}
			set	{	_set(FSuitocho_KeihiSeisan, value);	}
		}
		
		/// <summary>
		/// フィールド[未精算差額]。
		/// </summary>
		public const string FSuitocho_Miseisan = "Suitocho_Miseisan";
		/// <summary>
		/// 未精算差額
		/// </summary>
		public decimal Suitocho_Miseisan
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSuitocho_Miseisan]);	}
			set	{	_set(FSuitocho_Miseisan, value);	}
		}
		
		/// <summary>
		/// 未精算差額。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Suitocho_Miseisan_Null
		{
			get	{	if (row == null || row[FSuitocho_Miseisan] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSuitocho_Miseisan]); }	}
			set	{	_set(FSuitocho_Miseisan, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_Suitocho(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Suitocho 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_Suitocho 型の空テーブル</returns>
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
