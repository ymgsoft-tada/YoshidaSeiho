using ComponentDB;
using ComponentDebug;
using ComponentIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
	/// <summary>
	/// [作成者 kj]
	/// Kintone 出納帳情報
	/// </summary>
	public class AppSuitocho
	{
		List<Suitocho> all_list;
		/// <summary>ID検索用</summary>
		Dictionary<int , Suitocho> dics_id;

		/// <summary>月分検索用</summary>
		Dictionary<DateTime, List<Suitocho>> dics_ym;

		/// <summary>Kintone アプリクラス</summary>
		KintoneAP app;

		/// <summary>参照用のビュー</summary>
		public DBView DbView { get; private set; }

		/// <summary>経費サブテール</summary>
		public DBView KeihiView { get; private set; }

		/// <summary>清算サブテール</summary>
		public DBView SeisanView { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AppSuitocho()
		{
			all_list = new List<Suitocho>();
			dics_id = new Dictionary<int, Suitocho>();
			dics_ym = new Dictionary<DateTime, List<Suitocho>>();
		}

		/// <summary>
		/// 初期化処理
		/// </summary>
		public void Init()
		{
			all_list.Clear();
			dics_id.Clear();

			if (AppGlobal.Kintone != null)
			{
				// APの取得
				app = AppGlobal.Kintone.GetAP(eKintoneID.Suitocho);

				if (app == null)
				{
					ErrLog.WriteLine("■■出納帳APが取得できません。");
					return;
				}

				DbView = new DBView(app.Table);

				for (int i = 0; i < DbView.Count; i++)
				{
					Suitocho obj = new Suitocho(DbView[i].Row);
					
					if (obj.ID != 0)
					{
						all_list.Add(obj);

						if (dics_id.ContainsKey(obj.ID) == false)
						{
							dics_id.Add(obj.ID, obj);
						}

						DateTime ym = new DateTime(obj.XRow.Suitocho_Date.Year, obj.XRow.Suitocho_Date.Month, 1);

						if (dics_ym.ContainsKey(ym) == false)
						{
							dics_ym.Add(ym, new List<Suitocho>());
						}

						dics_ym[ym].Add(obj);
					}
				}

				// 経費テーブルの登録
				if (app.SubTable != null && app.SubTable.ContainsKey(TableProp.k_SuitochoKeihi) == true)
				{
					KeihiView = new DBView(app.SubTable[TableProp.k_SuitochoKeihi]);

					// 不足しているカラムを追加
					if (KeihiView.DataTable.Columns.Contains(k_SuitochoKeihi.FID_Suitocho) == false)
					{
						KeihiView.DataTable.Columns.Add(k_SuitochoKeihi.FID_Suitocho, typeof(int));
					}
					if (KeihiView.DataTable.Columns.Contains(k_SuitochoKeihi.FID_SuitochoKeihi) == false)
					{
						KeihiView.DataTable.Columns.Add(k_SuitochoKeihi.FID_SuitochoKeihi, typeof(int));
					}

					for (int i = 0 ; i < KeihiView.Count; i++)
					{
						k_SuitochoKeihi xrow = new k_SuitochoKeihi(KeihiView[i]);

						//親IDフィールド値をID_Suitochoにセット
						xrow.ID_Suitocho = Cast.Int(xrow.Row[KintoneApiClient.Fld_ParentID]);

						//サブIDフィールド値をID_SuitochoKeihiにセット
						xrow.ID_SuitochoKeihi = Cast.Int(xrow.Row[KintoneApiClient.Fld_SubID]);

						if (dics_id.ContainsKey(xrow.ID_Suitocho) == true)
						{
							dics_id[xrow.ID_Suitocho].AddMeisaiKeihi(xrow);
						}
					}
				}
				else
				{
					ErrLog.WriteLine("■■出納帳経費テーブルが取得できませんでした。");
				}


				// 清算テーブルの登録
				if (app.SubTable != null && app.SubTable.ContainsKey(TableProp.k_SuitochoSeisan) == true)
				{
					SeisanView = new DBView(app.SubTable[TableProp.k_SuitochoSeisan]);

					// 不足しているカラムを追加
					if (SeisanView.DataTable.Columns.Contains(k_SuitochoSeisan.FID_Suitocho) == false)
					{
						SeisanView.DataTable.Columns.Add(k_SuitochoSeisan.FID_Suitocho, typeof(int));
					}
					if (SeisanView.DataTable.Columns.Contains(k_SuitochoSeisan.FID_SuitochoSeisan) == false)
					{
						SeisanView.DataTable.Columns.Add(k_SuitochoSeisan.FID_SuitochoSeisan, typeof(int));
					}

					for (int i = 0 ; i < SeisanView.Count; i++)
					{
						k_SuitochoSeisan xrow = new k_SuitochoSeisan(SeisanView[i]);

						//親IDフィールド値をID_Suitochoにセット
						xrow.ID_Suitocho = Cast.Int(xrow.Row[KintoneApiClient.Fld_ParentID]);

						//サブIDフィールド値をID_SuitochoKeihiにセット
						xrow.ID_SuitochoSeisan = Cast.Int(xrow.Row[KintoneApiClient.Fld_SubID]);

						if (dics_id.ContainsKey(xrow.ID_Suitocho) == true)
						{
							dics_id[xrow.ID_Suitocho].AddMeisaiSeisan(xrow);
						}
					}
				}
				else
				{
					ErrLog.WriteLine("■■出納帳清算テーブルが取得できませんでした。");
				}
			}
		}

		/// <summary>
		/// 指定されたID_Suitochoから出納帳クラスを返します。
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Suitocho Get(int id)
		{
			if (dics_id.ContainsKey(id) == true)
			{
				return dics_id[id];
			}

			return null;
		}

		/// <summary>
		/// 指定した月分の出納帳データを取得します。
		/// </summary>
		/// <param name="ym"></param>
		/// <returns></returns>
		public List<Suitocho> GetDateYM(DateTime ym)
		{
			DateTime date = new DateTime(ym.Year, ym.Month, 1);

			if (dics_ym.ContainsKey(date) == true)
			{
				return dics_ym[date];
			}
			else
			{
				ErrLog.WriteLine($"指定した月分の出納帳データは存在しません。月分:{ym.ToString("yyyy/MM")}");
			}

			return null;
		}

		/// <summary>
		/// 登録されているレコード数を返します。
		/// </summary>
		/// <returns></returns>
		public int Count()
		{
			return dics_id.Count;
		}
	}

	/// <summary>
	/// 出納帳クラス
	/// </summary>
	public class Suitocho
	{
		/// <summary>ID（行番号）</summary>
		public int ID { get; private set; }
		/// <summary>管理レコード</summary>
		public k_Suitocho XRow { get; private set; }

		// 経費明細
		List<k_SuitochoKeihi> keihi_list;
		// 清算明細
		List<k_SuitochoSeisan> seisan_list;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="row">レコード情報</param>
		public Suitocho(DataRow row)
		{
			keihi_list	= new List<k_SuitochoKeihi>();
			seisan_list = new List<k_SuitochoSeisan>();

			try
			{
				XRow = new k_Suitocho(row);
				ID	 = XRow.ID_Suitocho;
			}
			catch(Exception ex)
			{
				ErrLog.WriteException(ex);
			}
		}

		/// <summary>
		/// 経費明細レコードの登録
		/// </summary>
		/// <param name="subrow"></param>
		public void AddMeisaiKeihi(k_SuitochoKeihi subrow)
		{
			keihi_list.Add(subrow);
		}

		/// <summary>
		/// 清算明細レコードの登録
		/// </summary>
		/// <param name="subrow"></param>
		public void AddMeisaiSeisan(k_SuitochoSeisan subrow)
		{
			seisan_list.Add(subrow);
		}

		/// <summary>
		/// 経費レコードの取得
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<k_SuitochoKeihi> GetMeisaiKeihi(int? id = null)
		{
			if (id != null)
			{
				List<k_SuitochoKeihi> lst = new List<k_SuitochoKeihi>();
				lst.AddRange(keihi_list.FindAll(x => x.ID_Suitocho == id.Value));

				return lst;
			}
			else
			{
				return keihi_list;
			}
		}

		/// <summary>
		/// 清算レコードの取得
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public List<k_SuitochoSeisan> GetMeisaiSeisan(int? id = null)
		{
			if (id != null)
			{
				List<k_SuitochoSeisan> lst = new List<k_SuitochoSeisan>();
				lst.AddRange(seisan_list.FindAll(x => x.ID_Suitocho == id.Value));

				return lst;
			}
			else
			{
				return seisan_list;
			}
		}

		///// <summary>
		///// 明細レコードの取得
		///// </summary>
		///// <param name="id">nullであれば全レコード</param>
		///// <returns></returns>
		//public List<k_AnkenLease> GetMeisai(int? id = null)
		//{
		//	if (id != null)
		//	{
		//		List<k_AnkenLease> lst = new List<k_AnkenLease>();
		//		lst.Add(sub_list.Find(x => x.ID_AnkenLease == id.Value));

		//		return lst;
		//	}
		//	else
		//	{
		//		return sub_list;
		//	}
		//}
	}
}
