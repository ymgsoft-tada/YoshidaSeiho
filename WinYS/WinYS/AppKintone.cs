﻿using ComponentDebug;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
	/// <summary>
	/// KintoneアプリIDの列挙
	/// </summary>
	public enum eKintoneID
	{
		/// <summary>リース顧客管理マスタ</summary>
		MasterKokyaku	= 174,
		/// <summary>リース車両管理マスタ</summary>
		MasterSharyo	= 175,
		/// <summary>リース契約台帳</summary>
		KeiyakuDaicho	= 176,
		/// <summary>リース車両費出納帳</summary>
		Suitocho		= 177,
	}

	/// <summary>
	/// [作成者 kj]
	/// Kintoneアプリのデータ管理クラス
	/// </summary>
	public class AppKintone
	{
		/// <summary>Kintoneのサブドメイン</summary>
		public const string SubDomain = "gtdbh9cblh36";

		/// <summary>各アプリの情報</summary>
		Dictionary<eKintoneID, KintoneAP> apps;

		/// <summary>
		/// 顧客管理
		/// </summary>
		public AppKokyaku KokyakuInfo { get; private set; }

		/// <summary>
		/// 車両管理
		/// </summary>
		public AppSharyo SharyoInfo { get; private set; }

		/// <summary>
		/// 契約台帳管理
		/// </summary>
		public AppKeiyakuDaicho KeiyakuInfo { get; private set; }

		/// <summary>
		/// 出納帳管理
		/// </summary>
		public AppSuitocho SuitochoInfo { get; private set; }

		/// <summary>
		/// 初期化処理
		/// </summary>
		public void Init()
		{
			if (apps == null)
			{
				apps = new Dictionary<eKintoneID, KintoneAP>();
				apps.Add(eKintoneID.MasterKokyaku,	new KintoneAP("リース顧客管理マスタ",	eKintoneID.MasterKokyaku,	"ANPfbSuhSiYFpkjsEMJLxRGqp2hqYICR0W2vdDGc"));
				apps.Add(eKintoneID.MasterSharyo,	new KintoneAP("リース車両管理マスタ",	eKintoneID.MasterSharyo,	"B6cL2X8rxbmjc34fu9SXiwnpgqDlRa32I2T2EH7i"));
				apps.Add(eKintoneID.KeiyakuDaicho,	new KintoneAP("リース契約台帳",			eKintoneID.KeiyakuDaicho,	"s8ehWpM3p70zQow2iEwCOuoPuyuiWWy0Filik7Zn"));
				apps.Add(eKintoneID.Suitocho,		new KintoneAP("リース車両費出納帳",		eKintoneID.Suitocho,		"4MycEuf9qrcVj2UZCwMl9mDu3OFyvQDBIfpC4cpy"));
			}

			FetchAll();

			// 各アプリ情報クラスの初期化
			KokyakuInfo = new AppKokyaku();
			KokyakuInfo.Init();

			SharyoInfo  = new AppSharyo();
			SharyoInfo.Init();

			KeiyakuInfo = new AppKeiyakuDaicho();
			KeiyakuInfo.Init();

			SuitochoInfo = new AppSuitocho();
			SuitochoInfo.Init();
			
		}

		/// <summary>
		/// 指定したアプリIDのクラス情報を取得します。
		/// </summary>
		/// <param name="kid"></param>
		/// <returns></returns>
		public KintoneAP GetAP(eKintoneID kid)
		{
			if (apps.ContainsKey(kid) == true)
			{
				return apps[kid];
			}

			return null;
		}

		/// <summary>
		/// 全てのアプリのデータ取得します。
		/// </summary>
		public void FetchAll()
		{
			FormBg_Progress prog = new FormBg_Progress();
			prog.TitleText = "しばらくお待ちください。";
			prog.LabelText = "データを取得しています。";
			prog.DoWorkEvent += prog_DoWorkEventAll;
			prog.ShowDialog();
			prog.Dispose();
		
		}

		private void prog_DoWorkEventAll(object sender, System.ComponentModel.DoWorkEventArgs e)
		{
			FormBg_Progress prog = (FormBg_Progress)sender;

			int cnt = 0;

			foreach (var kvp in apps)
			{
				kvp.Value.Fetch();
				cnt++;

				while(!kvp.Value.FetchDone)
				{
					// 取得完了通知がくるまで待つ
				}

				prog.SetProgress(cnt / apps.Count*100);
			}
		}

		/// <summary>
		/// 指定したアプリIDのデータを取得します。
		/// </summary>
		/// <param name="kid"></param>
		public void Fetch(eKintoneID kid)
		{
			if (apps.ContainsKey(kid) == true)
			{
				apps[kid].Fetch();
			}
		}
	}

	/// <summary>
	/// Kintoneのユーザー選択情報を管理するクラス
	/// </summary>
	public class KintoneUser
	{
		public string Code { get; set; }
		public string Name { get; set; }
	}

	/// <summary>
	/// Kintoneアプリ情報クラス
	/// </summary>
	public class KintoneAP
	{
		/// <summary>アプリ名</summary>
		public string AppName { get; private set; }

		/// <summary>アプリID</summary>
		public eKintoneID AppID { get; private set; }

		/// <summary>テーブル</summary>
		public DataTable Table { get; private set; }

		/// <summary>サブテーブル</summary>
		public Dictionary<string, DataTable> SubTable { get; private set; }

		// Kintone用API
		KintoneApiClient kpc;

		public bool FetchDone = false;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public KintoneAP(string appname, eKintoneID appid, params string[] token)
		{
			AppName = appname;
			AppID	= appid;

			kpc = new KintoneApiClient(AppKintone.SubDomain, $"{(int)appid}", token.ToList());
		}

		/// <summary>
		/// Kintoneからレコード情報を取得します。
		/// </summary>
		public async void Fetch()
		{
			try
			{
				FetchDone = false;

				// 非同期で全レコードを取得
				List<JObject> allRecords = await kpc.GetAllRecordsAsync();

				AppLog.WriteLine($"●Succeed Fetch Data　ID:{(int)AppID}");

				// JSONからデータテーブルに変換
				var (table, subTable) = await Task.Run(() => kpc.ConvertJsonToDataTable(allRecords));

				// 結果を格納
				Table = table;
				SubTable = subTable;

				AppLog.WriteLine($"●Succeed JSON To DataTable　ID:{(int)AppID}");

				FetchDone = true;
			}
			catch (Exception ex)
			{
				AppMsgBox.Show(AppMsgBoxIndex.AnythingMessage,$"アプリID:{(int)AppID} データの取得に失敗しました。");
				ErrLog.WriteException(ex);
			}
		}
	}
}
