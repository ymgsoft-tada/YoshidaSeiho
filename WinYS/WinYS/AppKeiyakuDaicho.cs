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
	/// Kintone 契約台帳情報
	/// </summary>
	public class AppKeiyakuDaicho
	{
		List<KeiyakuDaicho> all_list;
		/// <summary>ID検索用</summary>
		Dictionary<int , KeiyakuDaicho> dics_id;

		/// <summary>Kintone アプリクラス</summary>
		KintoneAP app;

		/// <summary>参照用のビュー</summary>
		public DBView DbView { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AppKeiyakuDaicho()
		{
			all_list = new List<KeiyakuDaicho>();
			dics_id = new Dictionary<int, KeiyakuDaicho>();
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
				app = AppGlobal.Kintone.GetAP(eKintoneID.KeiyakuDaicho);

				DbView = new DBView(app.Table);

				for (int i = 0; i < DbView.Count; i++)
				{
					KeiyakuDaicho obj = new KeiyakuDaicho(DbView[i].Row);
					
					if (obj.ID != 0)
					{
						all_list.Add(obj);

						if (dics_id.ContainsKey(obj.ID) == false)
						{
							dics_id.Add(obj.ID, obj);
						}
					}
				}

				// 明細テーブルの登録
				if (app.SubTable != null && app.SubTable.ContainsKey(TableProp.k_AnkenLease) == true)
				{
					DBView dv = new DBView(app.SubTable[TableProp.k_AnkenLease]);

					// 不足しているカラムを追加
					if (dv.DataTable.Columns.Contains(k_AnkenLease.FID_Anken) == false)
					{
						dv.DataTable.Columns.Add(k_AnkenLease.FID_Anken, typeof(int));
					}
					if (dv.DataTable.Columns.Contains(k_AnkenLease.FID_AnkenLease) == false)
					{
						dv.DataTable.Columns.Add(k_AnkenLease.FID_AnkenLease, typeof(int));
					}

					for (int i = 0 ; i < dv.Count; i++)
					{
						k_AnkenLease xrow = new k_AnkenLease(dv[i]);

						//親IDフィールド値をID_Ankenにセット
						xrow.ID_Anken = Cast.Int(xrow.Row[KintoneApiClient.Fld_ParentID]);

						//サブIDフィールド値をID_AnkenLeaseにセット
						xrow.ID_AnkenLease = Cast.Int(xrow.Row[KintoneApiClient.Fld_SubID]);

						if (dics_id.ContainsKey(xrow.ID_Anken) == true)
						{
							dics_id[xrow.ID_Anken].AddMeisai(xrow);
						}
					}
				}
				else
				{
					
				}
			}
		}

		/// <summary>
		/// 指定されたID_Ankenから契約台帳クラスを返します。
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public KeiyakuDaicho Get(int id)
		{
			if (dics_id.ContainsKey(id) == true)
			{
				return dics_id[id];
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
	/// 契約台帳クラス
	/// </summary>
	public class KeiyakuDaicho
	{
		/// <summary>ID（行番号）</summary>
		public int ID { get; private set; }
		/// <summary>管理レコード</summary>
		public k_Anken XRow { get; private set; }

		List<k_AnkenLease> sub_list;

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="row">レコード情報</param>
		public KeiyakuDaicho(DataRow row)
		{
			sub_list = new List<k_AnkenLease>();

			try
			{
				XRow = new k_Anken(row);
				ID	 = XRow.ID_Anken;
			}
			catch(Exception ex)
			{
				ErrLog.WriteException(ex);
			}
		}

		/// <summary>
		/// 明細レコードの登録
		/// </summary>
		/// <param name="subrow"></param>
		public void AddMeisai(k_AnkenLease subrow)
		{
			sub_list.Add(subrow);
		}

		/// <summary>
		/// 明細レコードの取得
		/// </summary>
		/// <param name="id">nullであれば全レコード</param>
		/// <returns></returns>
		public List<k_AnkenLease> GetMeisai(int? id = null)
		{
			if (id != null)
			{
				List<k_AnkenLease> lst = new List<k_AnkenLease>();
				lst.Add(sub_list.Find(x => x.ID_AnkenLease == id.Value));

				return lst;
			}
			else
			{
				return sub_list;
			}
		}
	}
}
