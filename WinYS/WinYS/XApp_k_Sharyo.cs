
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
	public partial class k_Sharyo : FieldProp
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
		/// フィールド[車両ID]。
		/// </summary>
		public const string FID_Sharyo = "ID_Sharyo";
		/// <summary>
		/// 車両ID
		/// </summary>
		public int ID_Sharyo
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Sharyo]);	}
			set	{	_set(FID_Sharyo, value);	}
		}
		
		/// <summary>
		/// 車両ID。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? ID_Sharyo_Null
		{
			get	{	if (row == null || row[FID_Sharyo] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Sharyo]); }	}
			set	{	_set(FID_Sharyo, value);	}
		}
		
		/// <summary>
		/// フィールド[車名]。
		/// </summary>
		public const string FSharyo_Name = "Sharyo_Name";
		/// <summary>
		/// 車名
		/// </summary>
		public string Sharyo_Name
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Name]);	}
			set	{	_set(FSharyo_Name, value);	}
		}
		
		/// <summary>
		/// 車名。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Name_Null
		{
			get	{	if (row == null || row[FSharyo_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Name]); }	}
			set	{	_set(FSharyo_Name, value);	}
		}
		
		/// <summary>
		/// フィールド[管理番号]。
		/// </summary>
		public const string FSharyo_KanriNumber = "Sharyo_KanriNumber";
		/// <summary>
		/// 管理番号
		/// </summary>
		public int Sharyo_KanriNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_KanriNumber]);	}
			set	{	_set(FSharyo_KanriNumber, value);	}
		}
		
		/// <summary>
		/// 管理番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_KanriNumber_Null
		{
			get	{	if (row == null || row[FSharyo_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_KanriNumber]); }	}
			set	{	_set(FSharyo_KanriNumber, value);	}
		}
		
		/// <summary>
		/// フィールド[型式]。
		/// </summary>
		public const string FSharyo_Katashiki = "Sharyo_Katashiki";
		/// <summary>
		/// 型式
		/// </summary>
		public string Sharyo_Katashiki
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Katashiki]);	}
			set	{	_set(FSharyo_Katashiki, value);	}
		}
		
		/// <summary>
		/// 型式。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Katashiki_Null
		{
			get	{	if (row == null || row[FSharyo_Katashiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Katashiki]); }	}
			set	{	_set(FSharyo_Katashiki, value);	}
		}
		
		/// <summary>
		/// フィールド[種別]。
		/// </summary>
		public const string FSharyo_Shubetsu = "Sharyo_Shubetsu";
		/// <summary>
		/// 種別
		/// </summary>
		public string Sharyo_Shubetsu
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Shubetsu]);	}
			set	{	_set(FSharyo_Shubetsu, value);	}
		}
		
		/// <summary>
		/// 種別。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Shubetsu_Null
		{
			get	{	if (row == null || row[FSharyo_Shubetsu] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Shubetsu]); }	}
			set	{	_set(FSharyo_Shubetsu, value);	}
		}
		
		/// <summary>
		/// フィールド[車体形状]。
		/// </summary>
		public const string FSharyo_ShataiKejo = "Sharyo_ShataiKejo";
		/// <summary>
		/// 車体形状
		/// </summary>
		public string Sharyo_ShataiKejo
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_ShataiKejo]);	}
			set	{	_set(FSharyo_ShataiKejo, value);	}
		}
		
		/// <summary>
		/// 車体形状。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_ShataiKejo_Null
		{
			get	{	if (row == null || row[FSharyo_ShataiKejo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_ShataiKejo]); }	}
			set	{	_set(FSharyo_ShataiKejo, value);	}
		}
		
		/// <summary>
		/// フィールド[登録番号]。
		/// </summary>
		public const string FSharyo_TorokuNumber = "Sharyo_TorokuNumber";
		/// <summary>
		/// 登録番号
		/// </summary>
		public int Sharyo_TorokuNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_TorokuNumber]);	}
			set	{	_set(FSharyo_TorokuNumber, value);	}
		}
		
		/// <summary>
		/// 登録番号。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_TorokuNumber_Null
		{
			get	{	if (row == null || row[FSharyo_TorokuNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_TorokuNumber]); }	}
			set	{	_set(FSharyo_TorokuNumber, value);	}
		}
		
		/// <summary>
		/// フィールド[リース価格（税込）]。
		/// </summary>
		public const string FSharyo_Cost = "Sharyo_Cost";
		/// <summary>
		/// リース価格（税込）
		/// </summary>
		public decimal Sharyo_Cost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSharyo_Cost]);	}
			set	{	_set(FSharyo_Cost, value);	}
		}
		
		/// <summary>
		/// リース価格（税込）。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Sharyo_Cost_Null
		{
			get	{	if (row == null || row[FSharyo_Cost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSharyo_Cost]); }	}
			set	{	_set(FSharyo_Cost, value);	}
		}
		
		/// <summary>
		/// フィールド[減価償却費]。
		/// </summary>
		public const string FSharyo_Genka = "Sharyo_Genka";
		/// <summary>
		/// 減価償却費
		/// </summary>
		public decimal Sharyo_Genka
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSharyo_Genka]);	}
			set	{	_set(FSharyo_Genka, value);	}
		}
		
		/// <summary>
		/// 減価償却費。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public decimal? Sharyo_Genka_Null
		{
			get	{	if (row == null || row[FSharyo_Genka] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSharyo_Genka]); }	}
			set	{	_set(FSharyo_Genka, value);	}
		}
		
		/// <summary>
		/// フィールド[登録日]。
		/// </summary>
		public const string FSharyo_DateToroku = "Sharyo_DateToroku";
		/// <summary>
		/// 登録日
		/// </summary>
		public DateTime Sharyo_DateToroku
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateToroku]);	}
			set	{	_set(FSharyo_DateToroku, value);	}
		}
		
		/// <summary>
		/// 登録日。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Sharyo_DateToroku_Null
		{
			get	{	if (row == null || row[FSharyo_DateToroku] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateToroku]); }	}
			set	{	_set(FSharyo_DateToroku, value);	}
		}
		
		/// <summary>
		/// フィールド[車検有効期限]。
		/// </summary>
		public const string FSharyo_DateKigen = "Sharyo_DateKigen";
		/// <summary>
		/// 車検有効期限
		/// </summary>
		public DateTime Sharyo_DateKigen
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateKigen]);	}
			set	{	_set(FSharyo_DateKigen, value);	}
		}
		
		/// <summary>
		/// 車検有効期限。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Sharyo_DateKigen_Null
		{
			get	{	if (row == null || row[FSharyo_DateKigen] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateKigen]); }	}
			set	{	_set(FSharyo_DateKigen, value);	}
		}
		
		/// <summary>
		/// フィールド[自賠責保険 開始日]。
		/// </summary>
		public const string FSharyo_DateFrom = "Sharyo_DateFrom";
		/// <summary>
		/// 自賠責保険 開始日
		/// </summary>
		public DateTime Sharyo_DateFrom
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateFrom]);	}
			set	{	_set(FSharyo_DateFrom, value);	}
		}
		
		/// <summary>
		/// 自賠責保険 開始日。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Sharyo_DateFrom_Null
		{
			get	{	if (row == null || row[FSharyo_DateFrom] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateFrom]); }	}
			set	{	_set(FSharyo_DateFrom, value);	}
		}
		
		/// <summary>
		/// フィールド[自賠責保険 終了日]。
		/// </summary>
		public const string FSharyo_DateTo = "Sharyo_DateTo";
		/// <summary>
		/// 自賠責保険 終了日
		/// </summary>
		public DateTime Sharyo_DateTo
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateTo]);	}
			set	{	_set(FSharyo_DateTo, value);	}
		}
		
		/// <summary>
		/// 自賠責保険 終了日。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public DateTime? Sharyo_DateTo_Null
		{
			get	{	if (row == null || row[FSharyo_DateTo] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateTo]); }	}
			set	{	_set(FSharyo_DateTo, value);	}
		}
		
		/// <summary>
		/// フィールド[添付ファイル]。
		/// </summary>
		public const string FSharyo_File = "Sharyo_File";
		/// <summary>
		/// 添付ファイル
		/// </summary>
		public string Sharyo_File
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_File]);	}
			set	{	_set(FSharyo_File, value);	}
		}
		
		/// <summary>
		/// 添付ファイル。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_File_Null
		{
			get	{	if (row == null || row[FSharyo_File] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_File]); }	}
			set	{	_set(FSharyo_File, value);	}
		}
		
		/// <summary>
		/// フィールド[車両情報詳細]。
		/// </summary>
		public const string FSharyo_Joho = "Sharyo_Joho";
		/// <summary>
		/// 車両情報詳細
		/// </summary>
		public string Sharyo_Joho
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Joho]);	}
			set	{	_set(FSharyo_Joho, value);	}
		}
		
		/// <summary>
		/// 車両情報詳細。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Joho_Null
		{
			get	{	if (row == null || row[FSharyo_Joho] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Joho]); }	}
			set	{	_set(FSharyo_Joho, value);	}
		}
		
		/// <summary>
		/// フィールド[用途]。
		/// </summary>
		public const string FSharyo_Yoto = "Sharyo_Yoto";
		/// <summary>
		/// 用途
		/// </summary>
		public string Sharyo_Yoto
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Yoto]);	}
			set	{	_set(FSharyo_Yoto, value);	}
		}
		
		/// <summary>
		/// 用途。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Yoto_Null
		{
			get	{	if (row == null || row[FSharyo_Yoto] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Yoto]); }	}
			set	{	_set(FSharyo_Yoto, value);	}
		}
		
		/// <summary>
		/// フィールド[乗車定員]。
		/// </summary>
		public const string FSharyo_Teiin = "Sharyo_Teiin";
		/// <summary>
		/// 乗車定員
		/// </summary>
		public int Sharyo_Teiin
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Teiin]);	}
			set	{	_set(FSharyo_Teiin, value);	}
		}
		
		/// <summary>
		/// 乗車定員。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Teiin_Null
		{
			get	{	if (row == null || row[FSharyo_Teiin] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Teiin]); }	}
			set	{	_set(FSharyo_Teiin, value);	}
		}
		
		/// <summary>
		/// フィールド[最大積載量]。
		/// </summary>
		public const string FSharyo_Sekisai = "Sharyo_Sekisai";
		/// <summary>
		/// 最大積載量
		/// </summary>
		public int Sharyo_Sekisai
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Sekisai]);	}
			set	{	_set(FSharyo_Sekisai, value);	}
		}
		
		/// <summary>
		/// 最大積載量。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Sekisai_Null
		{
			get	{	if (row == null || row[FSharyo_Sekisai] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Sekisai]); }	}
			set	{	_set(FSharyo_Sekisai, value);	}
		}
		
		/// <summary>
		/// フィールド[車両重量]。
		/// </summary>
		public const string FSharyo_Weight = "Sharyo_Weight";
		/// <summary>
		/// 車両重量
		/// </summary>
		public int Sharyo_Weight
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Weight]);	}
			set	{	_set(FSharyo_Weight, value);	}
		}
		
		/// <summary>
		/// 車両重量。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Weight_Null
		{
			get	{	if (row == null || row[FSharyo_Weight] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Weight]); }	}
			set	{	_set(FSharyo_Weight, value);	}
		}
		
		/// <summary>
		/// フィールド[車両総重量]。
		/// </summary>
		public const string FSharyo_TotalWeight = "Sharyo_TotalWeight";
		/// <summary>
		/// 車両総重量
		/// </summary>
		public int Sharyo_TotalWeight
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_TotalWeight]);	}
			set	{	_set(FSharyo_TotalWeight, value);	}
		}
		
		/// <summary>
		/// 車両総重量。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_TotalWeight_Null
		{
			get	{	if (row == null || row[FSharyo_TotalWeight] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_TotalWeight]); }	}
			set	{	_set(FSharyo_TotalWeight, value);	}
		}
		
		/// <summary>
		/// フィールド[長さ]。
		/// </summary>
		public const string FSharyo_Length = "Sharyo_Length";
		/// <summary>
		/// 長さ
		/// </summary>
		public int Sharyo_Length
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Length]);	}
			set	{	_set(FSharyo_Length, value);	}
		}
		
		/// <summary>
		/// 長さ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Length_Null
		{
			get	{	if (row == null || row[FSharyo_Length] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Length]); }	}
			set	{	_set(FSharyo_Length, value);	}
		}
		
		/// <summary>
		/// フィールド[幅]。
		/// </summary>
		public const string FSharyo_Width = "Sharyo_Width";
		/// <summary>
		/// 幅
		/// </summary>
		public int Sharyo_Width
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Width]);	}
			set	{	_set(FSharyo_Width, value);	}
		}
		
		/// <summary>
		/// 幅。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Width_Null
		{
			get	{	if (row == null || row[FSharyo_Width] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Width]); }	}
			set	{	_set(FSharyo_Width, value);	}
		}
		
		/// <summary>
		/// フィールド[高さ]。
		/// </summary>
		public const string FSharyo_Height = "Sharyo_Height";
		/// <summary>
		/// 高さ
		/// </summary>
		public int Sharyo_Height
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Height]);	}
			set	{	_set(FSharyo_Height, value);	}
		}
		
		/// <summary>
		/// 高さ。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Height_Null
		{
			get	{	if (row == null || row[FSharyo_Height] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Height]); }	}
			set	{	_set(FSharyo_Height, value);	}
		}
		
		/// <summary>
		/// フィールド[前後軸重]。
		/// </summary>
		public const string FSharyo_Zenko = "Sharyo_Zenko";
		/// <summary>
		/// 前後軸重
		/// </summary>
		public int Sharyo_Zenko
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Zenko]);	}
			set	{	_set(FSharyo_Zenko, value);	}
		}
		
		/// <summary>
		/// 前後軸重。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Zenko_Null
		{
			get	{	if (row == null || row[FSharyo_Zenko] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Zenko]); }	}
			set	{	_set(FSharyo_Zenko, value);	}
		}
		
		/// <summary>
		/// フィールド[前前軸重]。
		/// </summary>
		public const string FSharyo_Zenzen = "Sharyo_Zenzen";
		/// <summary>
		/// 前前軸重
		/// </summary>
		public int Sharyo_Zenzen
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Zenzen]);	}
			set	{	_set(FSharyo_Zenzen, value);	}
		}
		
		/// <summary>
		/// 前前軸重。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Zenzen_Null
		{
			get	{	if (row == null || row[FSharyo_Zenzen] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Zenzen]); }	}
			set	{	_set(FSharyo_Zenzen, value);	}
		}
		
		/// <summary>
		/// フィールド[後後軸重]。
		/// </summary>
		public const string FSharyo_Koko = "Sharyo_Koko";
		/// <summary>
		/// 後後軸重
		/// </summary>
		public int Sharyo_Koko
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Koko]);	}
			set	{	_set(FSharyo_Koko, value);	}
		}
		
		/// <summary>
		/// 後後軸重。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Koko_Null
		{
			get	{	if (row == null || row[FSharyo_Koko] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Koko]); }	}
			set	{	_set(FSharyo_Koko, value);	}
		}
		
		/// <summary>
		/// フィールド[後前軸重]。
		/// </summary>
		public const string FSharyo_Kozen = "Sharyo_Kozen";
		/// <summary>
		/// 後前軸重
		/// </summary>
		public int Sharyo_Kozen
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Kozen]);	}
			set	{	_set(FSharyo_Kozen, value);	}
		}
		
		/// <summary>
		/// 後前軸重。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public int? Sharyo_Kozen_Null
		{
			get	{	if (row == null || row[FSharyo_Kozen] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Kozen]); }	}
			set	{	_set(FSharyo_Kozen, value);	}
		}
		
		/// <summary>
		/// フィールド[備考]。
		/// </summary>
		public const string FSharyo_Memo = "Sharyo_Memo";
		/// <summary>
		/// 備考
		/// </summary>
		public string Sharyo_Memo
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Memo]);	}
			set	{	_set(FSharyo_Memo, value);	}
		}
		
		/// <summary>
		/// 備考。System.DBNull.Value の場合 null を示します。
		/// </summary>
		public string Sharyo_Memo_Null
		{
			get	{	if (row == null || row[FSharyo_Memo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Memo]); }	}
			set	{	_set(FSharyo_Memo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="o">編集する行のDataRow、DataRowView、DBViewのどれか。DBViewの場合、現在指している行のデータになります。</param>
		public k_Sharyo(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Sharyo 型の空テーブルを作成し、返します。
		/// </summary>
		/// <returns>k_Sharyo 型の空テーブル</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_Sharyo");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Sharyo, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_KanriNumber, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Katashiki, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Shubetsu, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_ShataiKejo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_TorokuNumber, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Cost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Genka, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateToroku, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateKigen, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateFrom, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateTo, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_File, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Joho, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Yoto, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Teiin, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Sekisai, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Weight, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_TotalWeight, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Length, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Width, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Height, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Zenko, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Zenzen, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Koko, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Kozen, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Memo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
