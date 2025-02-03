using ComponentDB;
using ComponentFile;
using ComponentIO;
using ComponentRegistry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App
{
	/// <summary>
	/// [作成者 kj]
	/// グローバル値の管理
	/// </summary>
	public class AppGlobal
	{
		/// <summary>DB</summary>
		public static AppDb DB { get; private set; }

		/// <summary>基本情報</summary>
		public static t_basic Basic { get; private set; }

		/// <summary>KintoneApp</summary>
		public static AppKintone Kintone { get; private set; }

		/// <summary>
		/// 全初期化
		/// </summary>
		public static void Init()
		{
			enumKbn.InitEnumDictionary();
			AppDbRule.Initialize();

			RegCommon.SetMasterKey(AppConst.RegKey);

			//			ComponentGGridDB.GGridDBCommon.GridSortVectorUp		= Properties.Resources.GridSortVecUp;
			//			ComponentGGridDB.GGridDBCommon.GridSortVectorDown	= Properties.Resources.GridSortVecDown;

			initBasic();

			initKintone();
			
		}

		/// <summary>
		/// 基本情報の初期化
		/// </summary>
		static void initBasic()
		{
			DBView dv = new DBView(DB.GetFillTable(TableProp.t_basic));

			Basic = new t_basic(dv[0]);

			// 西暦表示固定
			AppDate.SetDispSeireki(true);
		}

		/// <summary>
		/// Kintone情報の初期化
		/// </summary>
		static void initKintone()
		{
			Kintone = new AppKintone();
			Kintone.Init();
		}


		/// <summary>
		/// DBの初期化処理
		/// </summary>
		public static bool InitDB()
		{
			if (FileIO.Exists(AppConst.DBPath) == false)
			{
				FileIO.Copy(AppConst.SystemDBPath, AppConst.DBPath);
			}

			DB = new AppDb();

			return DB.Init();
		}

		/// <summary>
		/// 終了処理
		/// </summary>
		public static void Finish()
		{
			if (DB != null)
			{
				DB.Finish();
			}
		}

		/// <summary>
		/// 金額の小数点以下の端数処理をおこないます。
		/// </summary>
		/// <param name="cost">金額</param>
		/// <param name="hasu">端数処理</param>
		/// <param name="n">端数処理をする小数位</param>
		/// <returns></returns>
		public static decimal Round(decimal cost, eHasu hasu, int n = 0)
		{
			double pow = Math.Pow(10, n);
			double dob = (double)cost * pow;

			switch(hasu)
			{
				case eHasu.Kiriage :
					dob = Math.Ceiling(dob)/pow;
					break;
				case eHasu.Kirisute :
					dob = Math.Truncate(dob)/pow;
					break;
				case eHasu.Shishagonyu :
					dob = Math.Round(dob,MidpointRounding.AwayFromZero)/pow;
					break;
				default :
					break;
			}

			if (dob - Math.Truncate(dob) == 0)
			{
				// 「#.0」と言った表示はさせない。
				dob = Math.Truncate(dob);
			}

			return Cast.Decimal(dob);
		}
	}
}
