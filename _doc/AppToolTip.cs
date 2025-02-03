
//
// �����̃v���O������SrcMakerForApplicationMessage�ɂ�莩���I�ɐ�������܂����B(fj)
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
	/// AppToolTipIndex �ɏ������f�[�^�������N���X�ł��B
	/// </summary>
	public class AppToolTipData
	{
		/// <summary>
		/// �\���^�C�v�B
		/// </summary>
		public ToolTipIcon			Icon;
		/// <summary>
		/// �\���^�C�g���B
		/// </summary>
		public string				Caption;
		/// <summary>
		/// �{���B
		/// </summary>
		public string				Text;
		/// <summary>
		/// ���[�N�e�L�X�g�BGetData() �����s�����ہA�����ϊ���̒l�������Ă��܂��B
		/// </summary>
		public string				WorkText;
		
		/// <summary>
		/// �R���X�g���N�^�B
		/// </summary>
		public AppToolTipData()
		{
			Icon	= ToolTipIcon.None;
			Caption	= "";
			Text	= "";
		}
		
		/// <summary>
		/// �R���X�g���N�^�B
		/// </summary>
		public AppToolTipData(ToolTipIcon icon, string caption, string text)
		{
			Icon	= icon;
			Caption	= caption;
			Text	= text;
		}
	}
	
	/// <summary>
	/// �A�v���P�[�V�����Ŏg�p����c�[���`�b�v�C���f�b�N�X���ł��B
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
		/// �󗓂ɂ��鎖�͂ł��܂���B
		/// </summary>
		CannotUseBlank,
		/// <summary>
		/// �⏕�Ȗڂ������I�ɃZ�b�g���܂����B
		/// </summary>
		AutoSetHojoKamoku,
		/// <summary>
		/// 1�`31�܂ł̐��l����͂��ĉ������B
		/// </summary>
		IllegalNyukinYoteibi,
		/// <summary>
		/// CTRL+ENTER �ŉ��s���܂��B
		/// </summary>
		ReturnByCtrlEnter,
		/// <summary>
		/// �_��J�n���ɕύX����܂����B
		/// </summary>
		ChangeKeiyakuStartAndEnd,
	}
	
	/// <summary>
	/// �c�[���`�b�v���B
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
				"���͕K�{����",
				"�󗓂ɂ��鎖�͂ł��܂���B"),
			new AppToolTipData(
				ToolTipIcon.Info,
				"�⏕�����݂���Ȗڂ��w�肳��Ă��܂��B",
				"�⏕�Ȗڂ������I�ɃZ�b�g���܂����B"),
			new AppToolTipData(
				ToolTipIcon.Warning,
				"�����\���������������܂���B",
				"1�`31�܂ł̐��l����͂��ĉ������B"),
			new AppToolTipData(
				ToolTipIcon.None,
				"",
				"CTRL+ENTER �ŉ��s���܂��B"),
			new AppToolTipData(
				ToolTipIcon.Info,
				"�_��I�������J�n�����O�ɂȂ��Ă��܂��B",
				"�_��J�n���ɕύX����܂����B"),
		};
	}
	
	/// <summary>
	/// �A�v���P�[�V�����Ŏg�p����c�[���`�b�v�ł��B
	/// </summary>
	public partial class AppToolTip
	{
		#region *** Private Value ***
		/// <summary>
		/// �c�[���`�b�v
		/// </summary>
		ComponentForm.ToolTip	toolTip;
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="form">�c�[���`�b�v��\������t�H�[��</param>
		public AppToolTip(Form form)
		{
			toolTip = new ComponentForm.ToolTip(form);
		}
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// AppToolTip �Ŏg�p���Ă��� ComponentForm.ToolTip �N���X���擾���܂��B
		/// ���ɗ��R���Ȃ��ꍇ�A���̃v���p�e�B�͎g�p���Ȃ��ł��������B
		/// </summary>
		public ComponentForm.ToolTip	ToolTip
		{
			get
			{
				return toolTip;
			}
		}
		/// <summary>
		/// �c�[���`�b�v�����݃A�N�e�B�u���ǂ����������l���擾���܂��B
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
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="icon">���b�Z�[�W�^�C�v</param>
		/// <param name="caption">���b�Z�[�W�^�C�g��</param>
		/// <param name="text">���b�Z�[�W�{��</param>
		public void Show(ToolTipIcon icon, string caption, string text)
		{
			int			x0 = Cursor.Position.X + 32;
			int			y0 = Cursor.Position.Y + 16;
			
			// ���ݕ\��������Ώ���
			toolTip.Hide();

			// �\���^�C�v�ɉ������c�[���`�b�v�Ăяo��
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
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X</param>
		/// <param name="arglist">���b�Z�[�W�e�L�X�g���u�Ⴆ��{0}�Ԗځv�Ƃ��������̂̏ꍇ�A{0}����̓I���e�ɕϊ����邽�߂̈������X�g</param>
		public void Show(AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// ���b�Z�[�W���擾
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(icon, caption, text);
		}
		
		/// <summary>
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="ctl">�w�������R���g���[��</param>
		/// <param name="x0">�R���g���[������̑��΍��WX</param>
		/// <param name="y0">�R���g���[������̑��΍��WY</param>
		/// <param name="icon">���b�Z�[�W�^�C�v</param>
		/// <param name="caption">���b�Z�[�W�^�C�g��</param>
		/// <param name="text">���b�Z�[�W�{��</param>
		public void Show(Control ctl, int x0, int y0, ToolTipIcon icon, string caption, string text)
		{
			// ���ݕ\��������Ώ���
			toolTip.Hide();

			// �\���^�C�v�ɉ������c�[���`�b�v�Ăяo��
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
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="ctl">�w�������R���g���[��</param>
		/// <param name="x0">�R���g���[������̑��΍��WX</param>
		/// <param name="y0">�R���g���[������̑��΍��WY</param>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X</param>
		/// <param name="arglist">���b�Z�[�W�e�L�X�g���u�Ⴆ��{0}�Ԗځv�Ƃ��������̂̏ꍇ�A{0}����̓I���e�ɕϊ����邽�߂̈������X�g</param>
		public void Show(Control ctl, int x0, int y0, AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// ���b�Z�[�W���擾
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(ctl, x0, y0, icon, caption, text);
		}
		
		/// <summary>
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="ctl">�w�������R���g���[��</param>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X</param>
		/// <param name="arglist">���b�Z�[�W�e�L�X�g���u�Ⴆ��{0}�Ԗځv�Ƃ��������̂̏ꍇ�A{0}����̓I���e�ɕϊ����邽�߂̈������X�g</param>
		public void Show(Control ctl, AppToolTipIndex index, params object[] arglist)
		{
			string			caption;
			string			text;
			ToolTipIcon		icon;
			
			// ���b�Z�[�W���擾
			GetMessage(index, out caption, out text, out icon, arglist);
			
			Show(ctl, icon, caption, text);
		}

		/// <summary>
		/// �c�[���`�b�v�̕\��
		/// </summary>
		/// <param name="ctl">�w�������R���g���[��</param>
		/// <param name="icon">���b�Z�[�W�^�C�v</param>
		/// <param name="caption">���b�Z�[�W�^�C�g��</param>
		/// <param name="text">���b�Z�[�W�{��</param>
		public void Show(Control ctl, ToolTipIcon icon, string caption, string text)
		{	
			// ���ݕ\��������Ώ���
			toolTip.Hide();

			// �\���^�C�v�ɉ������c�[���`�b�v�Ăяo��
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
		/// �c�[���`�b�v���B���܂��B
		/// </summary>
		public void Hide()
		{
			toolTip.Hide();
		}
		#endregion

		#region *** Private Method ***
		/// <summary>
		/// �\���e�L�X�g���擾���܂��B
		/// </summary>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X�B</param>
		/// <param name="arglist">�\���e�L�X�g��{0}�Ȃǂ�ϊ����邽�߂̏��B</param>
		/// <returns>�c�[���`�b�v���B</returns>
		public static AppToolTipData GetData(AppToolTipIndex index, params object[] arglist)
		{
			int		idx = (int)index;
			
			if (idx < 0 || idx >= toolTipData.Length)
			{
				return null;
			}
			
			AppToolTipData		data = toolTipData[idx];
			
			data.WorkText = data.Text;
			
			// �ŗL�p�����[�^�̕ϊ�
			for (int i = 0; i < arglist.Length; i++)
			{
				string	param = "{" + i.ToString() + "}";
				
				data.WorkText = data.WorkText.Replace(param, arglist[i].ToString());
			}
			
			return data;
		}
		/// <summary>
		/// �\���e�L�X�g���擾���܂��B
		/// </summary>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X�B</param>
		/// <param name="arglist">�\���e�L�X�g��{0}�Ȃǂ�ϊ����邽�߂̏��B</param>
		/// <returns>�\���e�L�X�g�B</returns>
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
		/// ���b�Z�[�W���擾���܂��B
		/// </summary>
		/// <param name="index">���b�Z�[�W�C���f�b�N�X�B</param>
		/// <param name="caption">�^�C�g���L���v�V�����B</param>
		/// <param name="text">�\���e�L�X�g�B</param>
		/// <param name="icon">�\���^�C�v�B</param>
		/// <param name="arglist">�\���e�L�X�g��{0}�Ȃǂ�ϊ����邽�߂̏��B</param>
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


