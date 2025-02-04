
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
	public partial class t_kamoku : FieldProp
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
		/// フィールド[科目ID]。
		/// </summary>
		public const string FID_Kamoku = "ID_Kamoku";
		/// <summary>
		/// 科目ID
		/// </summary>
		public int ID_Kamoku
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Kamoku]);	}
			set	{	_set(FID_Kamoku, value);	}
		}
		
		/// <summary>
		/// 科目ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Kamoku_Null
		{
			get	{	if (row == null || row[FID_Kamoku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Kamoku]); }	}
			set	{	_set(FID_Kamoku, value);	}
		}
		
		/// <summary>
		/// フィールド[キントーン科目名]。
		/// </summary>
		public const string FKMK_NameKintone = "KMK_NameKintone";
		/// <summary>
		/// キントーン科目名
		/// </summary>
		public string KMK_NameKintone
		{
			get	{	return Cast.String(row == null ? null : row[FKMK_NameKintone]);	}
			set	{	_set(FKMK_NameKintone, value);	}
		}
		
		/// <summary>
		/// キントーン科目名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string KMK_NameKintone_Null
		{
			get	{	if (row == null || row[FKMK_NameKintone] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKMK_NameKintone]); }	}
			set	{	_set(FKMK_NameKintone, value);	}
		}
		
		/// <summary>
		/// フィールド[サクラス科目コード]。
		/// </summary>
		public const string FKMK_SakurasCode = "KMK_SakurasCode";
		/// <summary>
		/// サクラス科目コード
		/// </summary>
		public int KMK_SakurasCode
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasCode]);	}
			set	{	_set(FKMK_SakurasCode, value);	}
		}
		
		/// <summary>
		/// サクラス科目コード。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? KMK_SakurasCode_Null
		{
			get	{	if (row == null || row[FKMK_SakurasCode] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasCode]); }	}
			set	{	_set(FKMK_SakurasCode, value);	}
		}
		
		/// <summary>
		/// フィールド[サクラス補助科目コード]。
		/// </summary>
		public const string FKMK_SakurasCodeHojo = "KMK_SakurasCodeHojo";
		/// <summary>
		/// サクラス補助科目コード
		/// </summary>
		public int KMK_SakurasCodeHojo
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasCodeHojo]);	}
			set	{	_set(FKMK_SakurasCodeHojo, value);	}
		}
		
		/// <summary>
		/// サクラス補助科目コード。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? KMK_SakurasCodeHojo_Null
		{
			get	{	if (row == null || row[FKMK_SakurasCodeHojo] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasCodeHojo]); }	}
			set	{	_set(FKMK_SakurasCodeHojo, value);	}
		}
		
		/// <summary>
		/// フィールド[サクラス課税区分コード]。
		/// </summary>
		public const string FKMK_SakurasZeiku = "KMK_SakurasZeiku";
		/// <summary>
		/// サクラス課税区分コード
		/// </summary>
		public int KMK_SakurasZeiku
		{
			get	{	return Cast.Int(row == null ? null : row[FKMK_SakurasZeiku]);	}
			set	{	_set(FKMK_SakurasZeiku, value);	}
		}
		
		/// <summary>
		/// サクラス課税区分コード。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? KMK_SakurasZeiku_Null
		{
			get	{	if (row == null || row[FKMK_SakurasZeiku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKMK_SakurasZeiku]); }	}
			set	{	_set(FKMK_SakurasZeiku, value);	}
		}
		
		/// <summary>
		/// フィールド[[要時間]最終更新日時]。
		/// </summary>
		public const string FLastUpdate = "LastUpdate";
		/// <summary>
		/// [要時間]最終更新日時
		/// </summary>
		public DateTime LastUpdate
		{
			get	{	return Cast.DateTime(row == null ? null : row[FLastUpdate]);	}
			set	{	_set_datetime(FLastUpdate, value);	}
		}
		
		/// <summary>
		/// [要時間]最終更新日時。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? LastUpdate_Null
		{
			get	{	if (row == null || row[FLastUpdate] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FLastUpdate]); }	}
			set	{	_set_datetime(FLastUpdate, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public t_kamoku(object o) : base(o) {}
		#endregion
		/// <summary>
		/// t_kamoku 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>t_kamoku 型の空テーブル</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("t_kamoku");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Kamoku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_NameKintone, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasCode, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasCodeHojo, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKMK_SakurasZeiku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FLastUpdate, typeof(DateTime));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
