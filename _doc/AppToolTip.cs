
//
// ※このプログラムはSrcMakerForApplicationMessageにより自動的に生成されました。(fj)
//
// Inport File :
//		D:\usr\DotNet2.0_YMGLib2\Fujisan\FJChintai\_Doc\AppToolTip.csv
// Template File :
//		D:\usr\DotNet2.0_YMGLib2\Fujisan\FJChintai\_Doc\AppToolTip.cs.template
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;

namespace App
{
	/// <summary>
	/// AppToolTipIndex に準じたデータを示すクラスです。
	/// </summary>
	public class AppToolTipData
	{
		/// <summary>
		/// 表示タイプ。
		/// </summary>
		public ToolTipIcon			Icon;
		/// <summary>
		/// 表示タイトル。
		/// </summary>
		public string				Caption;
		/// <summary>
		/// 本文。
		/// </summary>
		public string				Text;
		/// <summary>
		/// ワークテキスト。GetData() を実行した際、引数変換後の値が入っています。
		/// </summary>
		public string				WorkText;
		
		/// <summary>
		/// コンストラクタ。
		/// </summary>
		public AppToolTipData()
		{
			Icon	= ToolTipIcon.None;
			Caption	= "";
			Text	= "";
		}
		
		/// <summary>
		/// コンストラクタ。
		/// </summary>
		public AppToolTipData(ToolTipIcon icon, string caption, string text)
		{
			Icon	= icon;
			Caption	= caption;
			Text	= text;
		}
	}
	
	/// <summary>
	/// アプリケーションで使用するツールチップインデックス名です。
	/// </summary>
	public enum AppToolTipIndex
	{
		/// <summary>
		/// 
		/// </summary>
		None,
		/// <summary>
		/// {0}
		/// </summary>
		AnythingTips,
		/// <summary>
		/// 空欄にする事はできません。
		/// </summary>
		CannotUseBlank,
		/// <summary>
		/// 補助科目を自動的にセットしました。
		/// </summary>
		AutoSetHojoKamoku,
		/// <summary>
		/// 1〜31までの数値を入力して下さい。
		/// </summary>
		IllegalNyukinYoteibi,
		/// <summary>
		/// CTRL+ENTER で改行します。
		/// </summary>
		ReturnByCtrlEnter,
		/// <summary>
		/// 契約開始日に変更されました。
		/// </summary>
		ChangeKeiyakuStartAndEnd,
	}
	
	/// <summary>
	/// ツールチップ情報。
	/// </summary>
	public partial class AppToolTip
	{
		static AppToolTipData[]	toolTipData =
		{
			new AppToolTipData(
				ToolTipIcon.None,
				"",
				""),
			new AppToolTipData(
				ToolTipIcon.None,
				"",
				"{0}"),
			new AppToolTipData(
				ToolTipIcon.Warning,
				"入力必須項目",
				"空欄にする事はできません。"),
			new AppToolTipData(
				ToolTipIcon.Info,
				"補助が存在する科目が指定されています。",
				"補助科目を自動的にセットしました。"),
			new AppToolTipData(
				ToolTipIcon.Warning,
				"入金予定日が正しくありません。",
				"1〜31までの数値を入力して下さい。"),
			new AppToolTipData(
				ToolTipIcon.None,
				"",
				"CTRL+ENTER で改行します。"),
			new AppToolTipData(
				ToolTipIcon.Info,
				"契約終了日が開始日より前になっています。",
				"契約開始日に変更されました。"),
		};
	}
	
	/// <summary>
	/// アプリケーションで使用するツールチップです。
	/// </summary>
	public partial class AppToolTip
	{
		#region *** Private Value ***
		/// <summary>
		/// ツールチップ
		/// </summary>
		ComponentForm.ToolTip	toolTip;
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// コンストラクタ
		/// </summary>
		/// <param name="form">ツールチップを表示するフォーム</param>
		public AppToolTip(Form form)
		{
			toolTip = new ComponentForm.ToolTip(form);
		}
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// AppToolTip で使用している ComponentForm.ToolTip クラスを取得します。
		/// 特に理由がない場合、このプロパティは使用しないでください。
		/// </summary>
		public ComponentForm.ToolTip	ToolTip
		{
			get
			{
				return toolTip;
			}
		}
		/// <summary>
		/// ツールチップが現在アクティブかどうかを示す値を取得します。
		/// </summary>
		public bool Active
		{
			get
			{
				return toolTip.Active;
			}
		}
		#endregion
		
		#region *** Public Method ***
		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="icon">メッセージタイプ</param>
		/// <param name="caption">メッセージタイトル</param>
		/// <param name="text">メッセージ本文</param>
		public void Show(ToolTipIcon icon, string caption, string text)
		{
			int			x0 = Cursor.Position.X + 32;
			int			y0 = Cursor.Position.Y + 16;
			
			// 現在表示があれば消す
			toolTip.Hide();

			// 表示タイプに応じたツールチップ呼び出し
			switch (icon)
			{
				case ToolTipIcon.None :
					toolTip.Tips(x0, y0, text);
					break;
				case ToolTipIcon.Info :
					toolTip.Info(x0, y0, caption, text);
					break;
				case ToolTipIcon.Warning :
					toolTip.Warning(x0, y0, caption, text);
					break;
				case ToolTipIcon.Error :
					toolTip.Error(x0, y0, caption, text);
					break;
			}
		}
		
		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="index">メッセージインデックス</param>
		/// <param name="arglist">メッセージテキストが「例えば{0}番目」といったものの場合、{0}を具体的内容に変換するための引数リスト</param>
		public void Show(AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// メッセージを取得
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(icon, caption, text);
		}
		
		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="ctl">指し示すコントロール</param>
		/// <param name="x0">コントロールからの相対座標X</param>
		/// <param name="y0">コントロールからの相対座標Y</param>
		/// <param name="icon">メッセージタイプ</param>
		/// <param name="caption">メッセージタイトル</param>
		/// <param name="text">メッセージ本文</param>
		public void Show(Control ctl, int x0, int y0, ToolTipIcon icon, string caption, string text)
		{
			// 現在表示があれば消す
			toolTip.Hide();

			// 表示タイプに応じたツールチップ呼び出し
			switch (icon)
			{
				case ToolTipIcon.None :
					toolTip.Tips(ctl, x0, y0, text);
					break;
				case ToolTipIcon.Info :
					toolTip.Info(ctl, x0, y0, caption, text);
					break;
				case ToolTipIcon.Warning :
					toolTip.Warning(ctl, x0, y0, caption, text);
					break;
				case ToolTipIcon.Error :
					toolTip.Error(ctl, x0, y0, caption, text);
					break;
			}
		}
		
		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="ctl">指し示すコントロール</param>
		/// <param name="x0">コントロールからの相対座標X</param>
		/// <param name="y0">コントロールからの相対座標Y</param>
		/// <param name="index">メッセージインデックス</param>
		/// <param name="arglist">メッセージテキストが「例えば{0}番目」といったものの場合、{0}を具体的内容に変換するための引数リスト</param>
		public void Show(Control ctl, int x0, int y0, AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// メッセージを取得
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(ctl, x0, y0, icon, caption, text);
		}
		
		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="ctl">指し示すコントロール</param>
		/// <param name="index">メッセージインデックス</param>
		/// <param name="arglist">メッセージテキストが「例えば{0}番目」といったものの場合、{0}を具体的内容に変換するための引数リスト</param>
		public void Show(Control ctl, AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// メッセージを取得
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(ctl, icon, caption, text);
		}

		/// <summary>
		/// ツールチップの表示
		/// </summary>
		/// <param name="ctl">指し示すコントロール</param>
		/// <param name="icon">メッセージタイプ</param>
		/// <param name="caption">メッセージタイトル</param>
		/// <param name="text">メッセージ本文</param>
		public void Show(Control ctl, ToolTipIcon icon, string caption, string text)
		{	
			// 現在表示があれば消す
			toolTip.Hide();

			// 表示タイプに応じたツールチップ呼び出し
			switch (icon)
			{
				case ToolTipIcon.None :
					toolTip.Tips(ctl, text);
					break;
				case ToolTipIcon.Info :
					toolTip.Info(ctl, caption, text);
					break;
				case ToolTipIcon.Warning :
					toolTip.Warning(ctl, caption, text);
					break;
				case ToolTipIcon.Error :
					toolTip.Error(ctl, caption, text);
					break;
			}
		}
		
		/// <summary>
		/// ツールチップを隠します。
		/// </summary>
		public void Hide()
		{
			toolTip.Hide();
		}
		#endregion

		#region *** Private Method ***
		/// <summary>
		/// 表示テキストを取得します。
		/// </summary>
		/// <param name="index">メッセージインデックス。</param>
		/// <param name="arglist">表示テキストの{0}などを変換するための情報。</param>
		/// <returns>ツールチップ情報。</returns>
		public static AppToolTipData GetData(AppToolTipIndex index, params object[] arglist)
		{
			int		idx = (int)index;
			
			if (idx < 0 || idx >= toolTipData.Length)
			{
				return null;
			}
			
			AppToolTipData		data = toolTipData[idx];
			
			data.WorkText = data.Text;
			
			// 固有パラメータの変換
			for (int i = 0; i < arglist.Length; i++)
			{
				string	param = "{" + i.ToString() + "}";
				
				data.WorkText = data.WorkText.Replace(param, arglist[i].ToString());
			}
			
			return data;
		}
		/// <summary>
		/// 表示テキストを取得します。
		/// </summary>
		/// <param name="index">メッセージインデックス。</param>
		/// <param name="arglist">表示テキストの{0}などを変換するための情報。</param>
		/// <returns>表示テキスト。</returns>
		public static string GetText(AppToolTipIndex index, params object[] arglist)
		{
			AppToolTipData		data = GetData(index, arglist);
			
			if (data == null)
			{
				return "";
			}
			
			return data.WorkText;
		}
		/// <summary>
		/// メッセージを取得します。
		/// </summary>
		/// <param name="index">メッセージインデックス。</param>
		/// <param name="caption">タイトルキャプション。</param>
		/// <param name="text">表示テキスト。</param>
		/// <param name="icon">表示タイプ。</param>
		/// <param name="arglist">表示テキストの{0}などを変換するための情報。</param>
		public static void GetMessage(AppToolTipIndex index, out string caption, out string text, out ToolTipIcon icon, params object[] arglist)
		{
			AppToolTipData		data = GetData(index, arglist);
			
			if (data == null)
			{
				caption = "";
				text    = "";
				icon    = ToolTipIcon.None;
			}
			else
			{
				icon	= data.Icon;
				text	= data.WorkText;
				caption = data.Caption;
			}
		}
		#endregion
	}
}


