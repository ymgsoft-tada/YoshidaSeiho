
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
	public partial class k_KokyakuKanri : FieldProp
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
		/// フィールド[顧客ID]。
		/// </summary>
		public const string FID_Kokyaku = "ID_Kokyaku";
		/// <summary>
		/// 顧客ID
		/// </summary>
		public int ID_Kokyaku
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Kokyaku]);	}
			set	{	_set(FID_Kokyaku, value);	}
		}
		
		/// <summary>
		/// 顧客ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Kokyaku_Null
		{
			get	{	if (row == null || row[FID_Kokyaku] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Kokyaku]); }	}
			set	{	_set(FID_Kokyaku, value);	}
		}
		
		/// <summary>
		/// フィールド[顧客名]。
		/// </summary>
		public const string FKokyaku_Name = "Kokyaku_Name";
		/// <summary>
		/// 顧客名
		/// </summary>
		public string Kokyaku_Name
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Name]);	}
			set	{	_set(FKokyaku_Name, value);	}
		}
		
		/// <summary>
		/// 顧客名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Name_Null
		{
			get	{	if (row == null || row[FKokyaku_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Name]); }	}
			set	{	_set(FKokyaku_Name, value);	}
		}
		
		/// <summary>
		/// フィールド[敬称]。
		/// </summary>
		public const string FKokyaku_Keisho = "Kokyaku_Keisho";
		/// <summary>
		/// 敬称
		/// </summary>
		public string Kokyaku_Keisho
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Keisho]);	}
			set	{	_set(FKokyaku_Keisho, value);	}
		}
		
		/// <summary>
		/// 敬称。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Keisho_Null
		{
			get	{	if (row == null || row[FKokyaku_Keisho] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Keisho]); }	}
			set	{	_set(FKokyaku_Keisho, value);	}
		}
		
		/// <summary>
		/// フィールド[フリガナ]。
		/// </summary>
		public const string FKokyaku_NameFurigana = "Kokyaku_NameFurigana";
		/// <summary>
		/// フリガナ
		/// </summary>
		public string Kokyaku_NameFurigana
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_NameFurigana]);	}
			set	{	_set(FKokyaku_NameFurigana, value);	}
		}
		
		/// <summary>
		/// フリガナ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_NameFurigana_Null
		{
			get	{	if (row == null || row[FKokyaku_NameFurigana] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_NameFurigana]); }	}
			set	{	_set(FKokyaku_NameFurigana, value);	}
		}
		
		/// <summary>
		/// フィールド[担当者]。
		/// </summary>
		public const string FKokyaku_TantoshaName = "Kokyaku_TantoshaName";
		/// <summary>
		/// 担当者
		/// </summary>
		public string Kokyaku_TantoshaName
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_TantoshaName]);	}
			set	{	_set(FKokyaku_TantoshaName, value);	}
		}
		
		/// <summary>
		/// 担当者。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_TantoshaName_Null
		{
			get	{	if (row == null || row[FKokyaku_TantoshaName] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_TantoshaName]); }	}
			set	{	_set(FKokyaku_TantoshaName, value);	}
		}
		
		/// <summary>
		/// フィールド[管理番号]。
		/// </summary>
		public const string FKokyaku_KanriNumber = "Kokyaku_KanriNumber";
		/// <summary>
		/// 管理番号
		/// </summary>
		public string Kokyaku_KanriNumber
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_KanriNumber]);	}
			set	{	_set(FKokyaku_KanriNumber, value);	}
		}
		
		/// <summary>
		/// 管理番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_KanriNumber_Null
		{
			get	{	if (row == null || row[FKokyaku_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_KanriNumber]); }	}
			set	{	_set(FKokyaku_KanriNumber, value);	}
		}
		
		/// <summary>
		/// フィールド[〒]。
		/// </summary>
		public const string FKokyaku_Zip1 = "Kokyaku_Zip1";
		/// <summary>
		/// 〒
		/// </summary>
		public string Kokyaku_Zip1
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Zip1]);	}
			set	{	_set(FKokyaku_Zip1, value);	}
		}
		
		/// <summary>
		/// 〒。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Zip1_Null
		{
			get	{	if (row == null || row[FKokyaku_Zip1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Zip1]); }	}
			set	{	_set(FKokyaku_Zip1, value);	}
		}
		
		/// <summary>
		/// フィールド[住所1]。
		/// </summary>
		public const string FKokyaku_Address1 = "Kokyaku_Address1";
		/// <summary>
		/// 住所1
		/// </summary>
		public string Kokyaku_Address1
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address1]);	}
			set	{	_set(FKokyaku_Address1, value);	}
		}
		
		/// <summary>
		/// 住所1。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Address1_Null
		{
			get	{	if (row == null || row[FKokyaku_Address1] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address1]); }	}
			set	{	_set(FKokyaku_Address1, value);	}
		}
		
		/// <summary>
		/// フィールド[住所2]。
		/// </summary>
		public const string FKokyaku_Address2 = "Kokyaku_Address2";
		/// <summary>
		/// 住所2
		/// </summary>
		public string Kokyaku_Address2
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address2]);	}
			set	{	_set(FKokyaku_Address2, value);	}
		}
		
		/// <summary>
		/// 住所2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Address2_Null
		{
			get	{	if (row == null || row[FKokyaku_Address2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address2]); }	}
			set	{	_set(FKokyaku_Address2, value);	}
		}
		
		/// <summary>
		/// フィールド[電話番号1]。
		/// </summary>
		public const string FKokyaku_Tel1 = "Kokyaku_Tel1";
		/// <summary>
		/// 電話番号1
		/// </summary>
		public int Kokyaku_Tel1
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel1]);	}
			set	{	_set(FKokyaku_Tel1, value);	}
		}
		
		/// <summary>
		/// 電話番号1。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Tel1_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel1] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel1]); }	}
			set	{	_set(FKokyaku_Tel1, value);	}
		}
		
		/// <summary>
		/// フィールド[電話番号2]。
		/// </summary>
		public const string FKokyaku_Tel2 = "Kokyaku_Tel2";
		/// <summary>
		/// 電話番号2
		/// </summary>
		public int Kokyaku_Tel2
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel2]);	}
			set	{	_set(FKokyaku_Tel2, value);	}
		}
		
		/// <summary>
		/// 電話番号2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Tel2_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel2] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel2]); }	}
			set	{	_set(FKokyaku_Tel2, value);	}
		}
		
		/// <summary>
		/// フィールド[電話番号3]。
		/// </summary>
		public const string FKokyaku_Tel3 = "Kokyaku_Tel3";
		/// <summary>
		/// 電話番号3
		/// </summary>
		public int Kokyaku_Tel3
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Tel3]);	}
			set	{	_set(FKokyaku_Tel3, value);	}
		}
		
		/// <summary>
		/// 電話番号3。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Tel3_Null
		{
			get	{	if (row == null || row[FKokyaku_Tel3] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Tel3]); }	}
			set	{	_set(FKokyaku_Tel3, value);	}
		}
		
		/// <summary>
		/// フィールド[FAX番号1]。
		/// </summary>
		public const string FKokyaku_Fax1 = "Kokyaku_Fax1";
		/// <summary>
		/// FAX番号1
		/// </summary>
		public int Kokyaku_Fax1
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax1]);	}
			set	{	_set(FKokyaku_Fax1, value);	}
		}
		
		/// <summary>
		/// FAX番号1。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Fax1_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax1] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax1]); }	}
			set	{	_set(FKokyaku_Fax1, value);	}
		}
		
		/// <summary>
		/// フィールド[FAX番号2]。
		/// </summary>
		public const string FKokyaku_Fax2 = "Kokyaku_Fax2";
		/// <summary>
		/// FAX番号2
		/// </summary>
		public int Kokyaku_Fax2
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax2]);	}
			set	{	_set(FKokyaku_Fax2, value);	}
		}
		
		/// <summary>
		/// FAX番号2。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Fax2_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax2] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax2]); }	}
			set	{	_set(FKokyaku_Fax2, value);	}
		}
		
		/// <summary>
		/// フィールド[FAX番号3]。
		/// </summary>
		public const string FKokyaku_Fax3 = "Kokyaku_Fax3";
		/// <summary>
		/// FAX番号3
		/// </summary>
		public int Kokyaku_Fax3
		{
			get	{	return Cast.Int(row == null ? null : row[FKokyaku_Fax3]);	}
			set	{	_set(FKokyaku_Fax3, value);	}
		}
		
		/// <summary>
		/// FAX番号3。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Kokyaku_Fax3_Null
		{
			get	{	if (row == null || row[FKokyaku_Fax3] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FKokyaku_Fax3]); }	}
			set	{	_set(FKokyaku_Fax3, value);	}
		}
		
		/// <summary>
		/// フィールド[メールアドレス]。
		/// </summary>
		public const string FKokyaku_Mail = "Kokyaku_Mail";
		/// <summary>
		/// メールアドレス
		/// </summary>
		public string Kokyaku_Mail
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Mail]);	}
			set	{	_set(FKokyaku_Mail, value);	}
		}
		
		/// <summary>
		/// メールアドレス。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Mail_Null
		{
			get	{	if (row == null || row[FKokyaku_Mail] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Mail]); }	}
			set	{	_set(FKokyaku_Mail, value);	}
		}
		
		/// <summary>
		/// フィールド[ご担当者名]。
		/// </summary>
		public const string FKokyaku_LeaseTantosha = "Kokyaku_LeaseTantosha";
		/// <summary>
		/// ご担当者名
		/// </summary>
		public string Kokyaku_LeaseTantosha
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_LeaseTantosha]);	}
			set	{	_set(FKokyaku_LeaseTantosha, value);	}
		}
		
		/// <summary>
		/// ご担当者名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_LeaseTantosha_Null
		{
			get	{	if (row == null || row[FKokyaku_LeaseTantosha] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_LeaseTantosha]); }	}
			set	{	_set(FKokyaku_LeaseTantosha, value);	}
		}
		
		/// <summary>
		/// フィールド[連絡先が異なる場合〒]。
		/// </summary>
		public const string FKokyaku_Zip2 = "Kokyaku_Zip2";
		/// <summary>
		/// 連絡先が異なる場合〒
		/// </summary>
		public string Kokyaku_Zip2
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Zip2]);	}
			set	{	_set(FKokyaku_Zip2, value);	}
		}
		
		/// <summary>
		/// 連絡先が異なる場合〒。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Zip2_Null
		{
			get	{	if (row == null || row[FKokyaku_Zip2] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Zip2]); }	}
			set	{	_set(FKokyaku_Zip2, value);	}
		}
		
		/// <summary>
		/// フィールド[住所3]。
		/// </summary>
		public const string FKokyaku_Address3 = "Kokyaku_Address3";
		/// <summary>
		/// 住所3
		/// </summary>
		public string Kokyaku_Address3
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address3]);	}
			set	{	_set(FKokyaku_Address3, value);	}
		}
		
		/// <summary>
		/// 住所3。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Address3_Null
		{
			get	{	if (row == null || row[FKokyaku_Address3] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address3]); }	}
			set	{	_set(FKokyaku_Address3, value);	}
		}
		
		/// <summary>
		/// フィールド[住所4]。
		/// </summary>
		public const string FKokyaku_Address4 = "Kokyaku_Address4";
		/// <summary>
		/// 住所4
		/// </summary>
		public string Kokyaku_Address4
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Address4]);	}
			set	{	_set(FKokyaku_Address4, value);	}
		}
		
		/// <summary>
		/// 住所4。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Address4_Null
		{
			get	{	if (row == null || row[FKokyaku_Address4] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Address4]); }	}
			set	{	_set(FKokyaku_Address4, value);	}
		}
		
		/// <summary>
		/// フィールド[備考]。
		/// </summary>
		public const string FKokyaku_Memo = "Kokyaku_Memo";
		/// <summary>
		/// 備考
		/// </summary>
		public string Kokyaku_Memo
		{
			get	{	return Cast.String(row == null ? null : row[FKokyaku_Memo]);	}
			set	{	_set(FKokyaku_Memo, value);	}
		}
		
		/// <summary>
		/// 備考。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Kokyaku_Memo_Null
		{
			get	{	if (row == null || row[FKokyaku_Memo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FKokyaku_Memo]); }	}
			set	{	_set(FKokyaku_Memo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_KokyakuKanri(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_KokyakuKanri 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_KokyakuKanri 型の空テーブル</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_KokyakuKanri");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Kokyaku, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Keisho, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_NameFurigana, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_TantoshaName, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_KanriNumber, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Zip1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address1, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel1, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel2, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Tel3, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax1, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax2, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Fax3, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Mail, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_LeaseTantosha, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Zip2, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address3, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Address4, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FKokyaku_Memo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
