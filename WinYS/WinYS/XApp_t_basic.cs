
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
	public partial class t_basic : FieldProp
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
		/// フィールド[会社名]。
		/// </summary>
		public const string FBAS_Name = "BAS_Name";
		/// <summary>
		/// 会社名
		/// </summary>
		public string BAS_Name
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Name]);	}
			set	{	_set(FBAS_Name, value);	}
		}
		
		/// <summary>
		/// 会社名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Name_Null
		{
			get	{	if (row == null || row[FBAS_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Name]); }	}
			set	{	_set(FBAS_Name, value);	}
		}
		
		/// <summary>
		/// フィールド[会社名フリガナ]。
		/// </summary>
		public const string FBAS_NameFurigana = "BAS_NameFurigana";
		/// <summary>
		/// 会社名フリガナ
		/// </summary>
		public string BAS_NameFurigana
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameFurigana]);	}
			set	{	_set(FBAS_NameFurigana, value);	}
		}
		
		/// <summary>
		/// 会社名フリガナ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_NameFurigana_Null
		{
			get	{	if (row == null || row[FBAS_NameFurigana] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameFurigana]); }	}
			set	{	_set(FBAS_NameFurigana, value);	}
		}
		
		/// <summary>
		/// フィールド[代表者名]。
		/// </summary>
		public const string FBAS_NameDaihyo = "BAS_NameDaihyo";
		/// <summary>
		/// 代表者名
		/// </summary>
		public string BAS_NameDaihyo
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameDaihyo]);	}
			set	{	_set(FBAS_NameDaihyo, value);	}
		}
		
		/// <summary>
		/// 代表者名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_NameDaihyo_Null
		{
			get	{	if (row == null || row[FBAS_NameDaihyo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameDaihyo]); }	}
			set	{	_set(FBAS_NameDaihyo, value);	}
		}
		
		/// <summary>
		/// フィールド[会社名2]。
		/// </summary>
		public const string FBAS_Name2 = "BAS_Name2";
		/// <summary>
		/// 会社名2
		/// </summary>
		public string BAS_Name2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Name2]);	}
			set	{	_set(FBAS_Name2, value);	}
		}
		
		/// <summary>
		/// 会社名2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Name2_Null
		{
			get	{	if (row == null || row[FBAS_Name2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Name2]); }	}
			set	{	_set(FBAS_Name2, value);	}
		}
		
		/// <summary>
		/// フィールド[代表者名2]。
		/// </summary>
		public const string FBAS_NameDaihyo2 = "BAS_NameDaihyo2";
		/// <summary>
		/// 代表者名2
		/// </summary>
		public string BAS_NameDaihyo2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_NameDaihyo2]);	}
			set	{	_set(FBAS_NameDaihyo2, value);	}
		}
		
		/// <summary>
		/// 代表者名2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_NameDaihyo2_Null
		{
			get	{	if (row == null || row[FBAS_NameDaihyo2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_NameDaihyo2]); }	}
			set	{	_set(FBAS_NameDaihyo2, value);	}
		}
		
		/// <summary>
		/// フィールド[郵便番号]。
		/// </summary>
		public const string FBAS_Post = "BAS_Post";
		/// <summary>
		/// 郵便番号
		/// </summary>
		public string BAS_Post
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Post]);	}
			set	{	_set(FBAS_Post, value);	}
		}
		
		/// <summary>
		/// 郵便番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Post_Null
		{
			get	{	if (row == null || row[FBAS_Post] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Post]); }	}
			set	{	_set(FBAS_Post, value);	}
		}
		
		/// <summary>
		/// フィールド[住所１]。
		/// </summary>
		public const string FBAS_Addr1 = "BAS_Addr1";
		/// <summary>
		/// 住所１
		/// </summary>
		public string BAS_Addr1
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Addr1]);	}
			set	{	_set(FBAS_Addr1, value);	}
		}
		
		/// <summary>
		/// 住所１。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Addr1_Null
		{
			get	{	if (row == null || row[FBAS_Addr1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Addr1]); }	}
			set	{	_set(FBAS_Addr1, value);	}
		}
		
		/// <summary>
		/// フィールド[住所２]。
		/// </summary>
		public const string FBAS_Addr2 = "BAS_Addr2";
		/// <summary>
		/// 住所２
		/// </summary>
		public string BAS_Addr2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Addr2]);	}
			set	{	_set(FBAS_Addr2, value);	}
		}
		
		/// <summary>
		/// 住所２。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Addr2_Null
		{
			get	{	if (row == null || row[FBAS_Addr2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Addr2]); }	}
			set	{	_set(FBAS_Addr2, value);	}
		}
		
		/// <summary>
		/// フィールド[電話１]。
		/// </summary>
		public const string FBAS_Tel1 = "BAS_Tel1";
		/// <summary>
		/// 電話１
		/// </summary>
		public string BAS_Tel1
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Tel1]);	}
			set	{	_set(FBAS_Tel1, value);	}
		}
		
		/// <summary>
		/// 電話１。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Tel1_Null
		{
			get	{	if (row == null || row[FBAS_Tel1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Tel1]); }	}
			set	{	_set(FBAS_Tel1, value);	}
		}
		
		/// <summary>
		/// フィールド[電話2]。
		/// </summary>
		public const string FBAS_Tel2 = "BAS_Tel2";
		/// <summary>
		/// 電話2
		/// </summary>
		public string BAS_Tel2
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Tel2]);	}
			set	{	_set(FBAS_Tel2, value);	}
		}
		
		/// <summary>
		/// 電話2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Tel2_Null
		{
			get	{	if (row == null || row[FBAS_Tel2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Tel2]); }	}
			set	{	_set(FBAS_Tel2, value);	}
		}
		
		/// <summary>
		/// フィールド[FAX]。
		/// </summary>
		public const string FBAS_Fax = "BAS_Fax";
		/// <summary>
		/// FAX
		/// </summary>
		public string BAS_Fax
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_Fax]);	}
			set	{	_set(FBAS_Fax, value);	}
		}
		
		/// <summary>
		/// FAX。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_Fax_Null
		{
			get	{	if (row == null || row[FBAS_Fax] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_Fax]); }	}
			set	{	_set(FBAS_Fax, value);	}
		}
		
		/// <summary>
		/// フィールド[DBVersion]。
		/// </summary>
		public const string FBAS_DBVersion = "BAS_DBVersion";
		/// <summary>
		/// DBVersion
		/// </summary>
		public string BAS_DBVersion
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_DBVersion]);	}
			set	{	_set(FBAS_DBVersion, value);	}
		}
		
		/// <summary>
		/// DBVersion。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_DBVersion_Null
		{
			get	{	if (row == null || row[FBAS_DBVersion] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_DBVersion]); }	}
			set	{	_set(FBAS_DBVersion, value);	}
		}
		
		/// <summary>
		/// フィールド[最終データ取得日付]。
		/// </summary>
		public const string FBAS_LastDateDownload = "BAS_LastDateDownload";
		/// <summary>
		/// 最終データ取得日付
		/// </summary>
		public DateTime BAS_LastDateDownload
		{
			get	{	return Cast.DateTime(row == null ? null : row[FBAS_LastDateDownload]);	}
			set	{	_set(FBAS_LastDateDownload, value);	}
		}
		
		/// <summary>
		/// 最終データ取得日付。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? BAS_LastDateDownload_Null
		{
			get	{	if (row == null || row[FBAS_LastDateDownload] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FBAS_LastDateDownload]); }	}
			set	{	_set(FBAS_LastDateDownload, value);	}
		}
		
		/// <summary>
		/// フィールド[システムパスワード]。
		/// </summary>
		public const string FBAS_SystemPWD = "BAS_SystemPWD";
		/// <summary>
		/// システムパスワード
		/// </summary>
		public string BAS_SystemPWD
		{
			get	{	return Cast.String(row == null ? null : row[FBAS_SystemPWD]);	}
			set	{	_set(FBAS_SystemPWD, value);	}
		}
		
		/// <summary>
		/// システムパスワード。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string BAS_SystemPWD_Null
		{
			get	{	if (row == null || row[FBAS_SystemPWD] == System.DBNull.Value) { return null; } else { return Cast.String(row[FBAS_SystemPWD]); }	}
			set	{	_set(FBAS_SystemPWD, value);	}
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
		public t_basic(object o) : base(o) {}
		#endregion
		/// <summary>
		/// t_basic 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>t_basic 型の空テーブル</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("t_basic");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameFurigana, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameDaihyo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 50;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Name2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_NameDaihyo2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 50;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Post, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Addr1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Addr2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Tel1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Tel2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_Fax, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_DBVersion, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_LastDateDownload, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FBAS_SystemPWD, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FLastUpdate, typeof(DateTime));
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
