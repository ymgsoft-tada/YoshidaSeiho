
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
	/// [列挙] 端数処理
	/// </summary>
	public enum eHasu
	{
		/// <summary>
		/// 
		/// </summary>
		None = 0,
		/// <summary>
		/// 切捨
		/// </summary>
		Kirisute = 1,
		/// <summary>
		/// 切上
		/// </summary>
		Kiriage = 2,
		/// <summary>
		/// 四捨五入
		/// </summary>
		Shishagonyu = 3,
	}
	
	/// <summary>
	/// [作成者 fj]
	/// テーブル編集の際に使うクラスです。
	/// </summary>
	public static class enumKbn
	{
		/// <summary>
		/// eHasu に対応した辞書です。
		/// </summary>
		public static Dictionary<int, string> DHasu;
		
		/// <summary>
		/// 列挙辞書を初期化します。
		/// </summary>
		public static void InitEnumDictionary()
		{
			DHasu = new Dictionary<int, string>();
			DHasu.Add((int)eHasu.None, "");
			DHasu.Add((int)eHasu.Kirisute, "切捨");
			DHasu.Add((int)eHasu.Kiriage, "切上");
			DHasu.Add((int)eHasu.Shishagonyu, "四捨五入");
		}
	}
}
