using C1.Win.C1TrueDBGrid;
using ComponentDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
	public partial class FormTest : FormFrame
	{
		Dictionary<KintoneAP, C1TrueDBGrid> dics;

		public FormTest()
		{
			InitializeComponent();
		}

		protected override void FormFrame_Shown(object sender, EventArgs e)
		{
			dics = new Dictionary<KintoneAP, C1TrueDBGrid>()
			{
				{AppGlobal.Kintone.GetAP(eKintoneID.MasterKokyaku), c1TrueDBGrid1},
				{AppGlobal.Kintone.GetAP(eKintoneID.MasterSharyo),	c1TrueDBGrid2},
				{AppGlobal.Kintone.GetAP(eKintoneID.KeiyakuDaicho), c1TrueDBGrid3},
				{AppGlobal.Kintone.GetAP(eKintoneID.Suitocho),		c1TrueDBGrid4},
			};

			foreach(var kvp in dics)
			{
				kvp.Value.Caption		= kvp.Key.AppName;
				kvp.Value.DataSource	= kvp.Key.Table;
				kvp.Value.RowHeight		= 20;
			}

			base.FormFrame_Shown(sender, e);
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;

			foreach(var kvp in dics)
			{
				kvp.Value.SuspendBinding();
			}

			AppGlobal.Kintone.Init();

			foreach(var kvp in dics)
			{
				kvp.Value.SetDataBinding(kvp.Key.Table, "", true, true);
				kvp.Value.ResumeBinding();
				kvp.Value.Refresh();
			}

			this.Cursor = Cursors.Default;

			MessageBox.Show(this, "データを取得しました。", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
	}
}
