using ComponentDB;
using ComponentDebug;
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
	/// Kintone 顧客管理マスタ情報
	/// </summary>
	public class AppKokyaku
	{
		List<Kokyaku> all_list;
		/// <summary>ID検索用</summary>
		Dictionary<int , Kokyaku> dics_id;

		/// <summary>Kintone アプリクラス</summary>
		KintoneAP app;

		/// <summary>参照用のビュー</summary>
		public DBView DbView { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		public AppKokyaku()
		{
			all_list = new List<Kokyaku>();
			dics_id = new Dictionary<int, Kokyaku>();
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
				app = AppGlobal.Kintone.GetAP(eKintoneID.MasterKokyaku);

				DbView = new DBView(app.Table);

				for (int i = 0; i < DbView.Count; i++)
				{
					Kokyaku obj = new Kokyaku(DbView[i].Row);
					
					if (obj.ID != 0)
					{
						all_list.Add(obj);

						if (dics_id.ContainsKey(obj.ID) == false)
						{
							dics_id.Add(obj.ID, obj);
						}
					}
				}
			}
		}

		/// <summary>
		/// 指定されたIDから顧客クラスを返します。
		/// </summary>
		/// <param name="id"></param>
		/// <returns></returns>
		public Kokyaku Get(int id)
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
	/// 顧客情報
	/// </summary>
	public class Kokyaku
	{
		/// <summary>顧客ID（行番号）</summary>
		public int ID { get; private set; }
		/// <summary>顧客管理レコード</summary>
		public k_KokyakuKanri XRow { get; private set; }

		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="row">レコード情報</param>
		public Kokyaku(DataRow row)
		{
			try
			{
				XRow = new k_KokyakuKanri(row);
				ID	 = XRow.ID_Kokyaku;
			}
			catch(Exception ex)
			{
				ErrLog.WriteException(ex);
			}		
		}
	}
}
