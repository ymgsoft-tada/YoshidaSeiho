using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

using ComponentDebug;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// �o�b�N�O���E���h�^�X�N�p�̃t���[���t�H�[���ł��B
	/// </summary>
	public partial class FormBg_Progress : Form
	{
		#region *** Delegate ***
		/// <summary>
		/// �t�H�[�����[�h���ɌĂяo����܂��B
		/// </summary>
		public event EventHandler			LoadEvent;
		/// <summary>
		/// �o�b�N�O���E���h�Ŏ��s�����C�x���g�������ɌĂяo����܂��BDoWorkEvent��DoWorkEventEx�̂ǂ��炩��I���ł��܂��B
		/// </summary>
		public event DoWorkEventHandler		DoWorkEvent;
		/// <summary>
		/// �o�b�N�O���E���h�Ŏ��s�����C�x���g�������ɌĂяo����܂��BDoWorkEvent��DoWorkEventEx�̂ǂ��炩��I���ł��܂��B
		/// </summary>
		public event DoWorkEventHandlerEx	DoWorkEventEx;
		/// <summary>
		/// BgWorker���g�킸���s���邩�ǂ����B
		/// </summary>
		bool		nobgworker;
		#endregion
		
		#region *** Private Value ***
		/// <summary>
		/// �i�����B
		/// </summary>
		int			progress_perc;
		/// <summary>
		/// DoWorkEventHandler�Ŏ󂯎������B
		/// </summary>
		object		arg;
		/// <summary>
		/// DoWorkEventHandlerEx�Ŏ󂯎������B
		/// </summary>
		object[]	args;
		/// <summary>
		/// �A�C�R���p�^�[�����X�g
		/// </summary>
		Image[]		images;
		/// <summary>
		/// �A�C�R���\���p�^�[��
		/// </summary>
		int			iconPat;
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// �A�C�R���\��
		/// </summary>
		public bool		IconVisible
		{
			get
			{
				return IconIndicator.Visible;
			}
			set
			{
				IconIndicator.Visible = value;
				iconVisible	  = value;
			}
		}
		bool			iconVisible;
		/// <summary>
		/// BgWorker���g�킸���s���邩�ǂ�����ݒ肵�܂��B
		/// </summary>
		public bool		NoBgWorker
		{
			get
			{
				return nobgworker;
			}
			set
			{
				nobgworker = value;
			}
		}
		/// <summary>
		/// DoWorkEventHandler�Ŏ󂯎��������擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public object	Arg
		{
			get
			{
				return arg;
			}
			set
			{
				arg = value;
			}
		}
		/// <summary>
		/// DoWorkEventHandlerEx�Ŏ󂯎��������擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public object[]	Args
		{
			get
			{
				return args;
			}
			set
			{
				args = value;
			}
		}
		/// <summary>
		/// �t�H�[���̕���ݒ肵�܂��B
		/// </summary>
		public int FormWidth
		{
			set
			{
				if (value < (324 - 235 + 32))
				{
					value = 324 - 235 + 32;
				}
				
				this.Width		  = value;
				Picture.Width	  = value - 8;
				LblInfo.Width	  =
				ProgressBar.Width = (235 - 324) + value;
			}
			get
			{
				return this.Width;
			}
			
		}
		/// <summary>
		/// �^�C�g���ɕ\������e�L�X�g��ݒ肵�܂��B
		/// </summary>
		public string TitleText
		{
			set
			{
				if (this.InvokeRequired == true)
				{
					this.Invoke(
						(MethodInvoker)delegate()
						{
							this.Text = value;
						}
					);
				}
				else
				{
					this.Text = value;
				}				
			}
			get
			{
				return this.Text;
			}
		}
		/// <summary>
		/// ���x���ɕ\������e�L�X�g��ݒ肵�܂��B
		/// </summary>
		public string LabelText
		{
			set
			{
				if (this.InvokeRequired == true)
				{
					this.Invoke(
						(MethodInvoker)delegate()
						{
							LblInfo.Text = value;
						}
					);
				}
				else
				{
					LblInfo.Text = value;
				}
			}
			get
			{
				return LblInfo.Text;
			}
		}

		/// <summary>
		/// �v���O���X�o�[�̕\���L�����擾�E�ݒ肵�܂��B
		/// </summary>
		public bool ProgressBarVisible
		{
			set
			{
				ProgressBar.Visible = value;
				
				if (value == false)
				{
					// ���x���𒆉��֕\��
					LblInfo.Height = 45;
				}
			}
			get
			{
				return ProgressBar.Visible;
			}
		}

		/// <summary>
		/// �������ʂ̊i�[��
		/// </summary>
		public object Result { get; private set; }
		/// <summary>
		/// �t�H�[���́~�{�^���������Ȃ�����΍�B
		/// </summary>
		protected override CreateParams CreateParams
		{
			get
			{
				const int CS_NOCLOSE = 0x200;
				CreateParams cp = base.CreateParams;
				cp.ClassStyle = cp.ClassStyle | CS_NOCLOSE;
				
				return cp;
			}
		}
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		public FormBg_Progress()
		{
			InitializeComponent();
			
			progress_perc = 0;
			arg			  = null;
			nobgworker	  = false;
			iconVisible	  = true;
			
			PictureBox[]	imgctls	  = new PictureBox[]
			{
				img0,
				img1,
				img2,
				img3,
				img4,
				img5,
				img6,
				img7,
				img8,
				img9,
				img10,
				img11,
			};
			
			images = new Image[imgctls.Length];
			
			for (int i = 0; i < images.Length; i++)
			{
				images[i] = imgctls[i].Image;
			}
			
			this.BackColor = AppConst.FormBackColor;
			
			Picture.Controls.Add(IconIndicator);
			Picture.Controls.Add(LblInfo);
			Picture.Controls.Add(ProgressBar);
			
			this.Load += new EventHandler(Form_Load);
			this.Shown += new EventHandler(Form_Shown);
		}
		#endregion
		
		#region *** Public Method ***
		/// <summary>
		/// �i���������Z�b�g���܂��B
		/// </summary>
		public void	ResetProgress()
		{
			progress_perc = 0;
			
			bgWorker.ReportProgress(progress_perc);
		}
		
		/// <summary>
		/// �i���������������܂��B
		/// </summary>
		public void	FinishProgress()
		{
			SetProgress(100);
		}
		
		/// <summary>
		/// �i�������擾���܂��B
		/// </summary>
		public int	GetProgress()
		{
			return progress_perc;
		}
		
		/// <summary>
		/// �i������ݒ肵�܂��B
		/// </summary>
		/// <param name="perc">�Z�b�g���道</param>
		public void	SetProgress(int perc)
		{
			if (perc < 0)
			{
				perc = 0;
			}
			if (perc > 100)
			{
				perc = 100;
			}
			progress_perc = perc;
			
			bgWorker.ReportProgress(progress_perc);
		}
		
		/// <summary>
		/// �i������i�߂܂��B�ő�100%�܂ŗݐς��܂��B
		/// </summary>
		/// <param name="perc">�i�߂道</param>
		public void	AdvanceProgress(int perc)
		{
			progress_perc += perc;
			
			if (progress_perc > 100)
			{
				progress_perc = 100;
			}
			
			bgWorker.ReportProgress(progress_perc);
		}
		#endregion
		
		#region *** Protected Method ***
		/// <summary>
		/// �t�H�[�����[�h�B
		/// </summary>
		void Form_Load(object sender, EventArgs e)
		{
			if (LoadEvent != null)
			{
				LoadEvent(sender, e);
			}
		}

		/// <summary>
		/// Window���J���ꂽ��ɂP�񂾂����s����܂��B
		/// �ǂݍ��݃X���b�h�����s���܂��B
		/// </summary>
		void Form_Shown(object sender, EventArgs e)
		{
			if (this.DesignMode == true)
			{
				return;
			}

			// �X���b�h���s
			if (nobgworker == true)
			{
				ErrLog.WriteLine("NoBgWorker ���[�h�ŋN�����܂��B");
				
				bgWorker_DoWork(null, new DoWorkEventArgs(null));
				this.Close();
			}
			else
			{
				if (arg == null)
				{
					bgWorker.RunWorkerAsync();
				}
				else
				{
					bgWorker.RunWorkerAsync(arg);
				}
			}
			
			// �f�U�C�����ɓ��I�ȏ��������s���Ȃ��悤��
			if (this.DesignMode == false)
			{
				iconPat = 0;
				timer.Start();
			}

			// �����ȃL�[����i�t�@���N�V�����L�[���j�����o���A�؂邽�߂� KeyPreview = true �ɂ��Ă���
			this.KeyPreview = true;
			
			this.KeyDown += new KeyEventHandler(Form_KeyDown);
			this.FormClosing += new FormClosingEventHandler(Form_FormClosing);
		}

		/// <summary>
		/// �����ȃL�[����i�t�@���N�V�����L�[���j��S�Đ؂�
		/// </summary>
		void Form_KeyDown(object sender, KeyEventArgs e)
		{
			e.Handled = true;
		}
		
		/// <summary>
		/// �E�B���h�E�N���[�Y
		/// </summary>
		protected virtual void Form_FormClosing(object sender, FormClosingEventArgs e)
		{		
			bgWorker.CancelAsync();

			// bgWorker�̏������I������܂ő҂�
			while (bgWorker.IsBusy == true)
			{
				Application.DoEvents();
			}
		}
		
		/// <summary>
		/// �ʃX���b�hBgWorker�̎��s�����B
		/// </summary>
		protected virtual void bgWorker_DoWork(object sender, DoWorkEventArgs e)
		{
			if (DoWorkEvent != null)
			{
				DoWorkEvent(this, e);
				
				// �߂�l���i�[
				Result = e.Result;
			}
			else if (DoWorkEventEx != null)
			{
				DoWorkEventArgsEx eex = new DoWorkEventArgsEx(null);
				eex.Args = args;
				
				DoWorkEventEx(this, eex);
				
				// �߂�l���i�[
				Result = eex.Result;
			}
		}
		
		/// <summary>
		/// �ʃX���b�h�����̐i���󋵕\���B
		/// </summary>
		protected virtual void bgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			int		val = e.ProgressPercentage;
			
			if (val < 0)
			{
				val = 0;
			}
			if (val >= 100)
			{
				val = 100;
			}
			
			//http://dobon.net/vb/dotnet/control/pbdisableanimation.html
			// �l�𑝂₵�Ă��猸�炷���@

			if (ProgressBar.Value < val)
			{
				//�l�𑝂₷��
				if (val < ProgressBar.Maximum)
				{
					//�ړI�̒l����傫�����Ă���A�ړI�̒l�ɂ���
					ProgressBar.Value = val + 1;
					ProgressBar.Value = val;
				}
				else
				{
					//�ő�l�ɂ��鎞
					//�ő�l��1���₵�Ă���A���ɖ߂�
					ProgressBar.Maximum++;
					ProgressBar.Value = val + 1;
					ProgressBar.Value = val;
					ProgressBar.Maximum--;
				}
			}
			else
			{
				//�l�����炷���́A���̂܂�
				ProgressBar.Value = val;
			}

			//ProgressBar.Value = val;
		}
		
		/// <summary>
		/// �ʃX���b�h�����̏I���B
		/// </summary>
		protected virtual void bgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			// �ǂݍ��ݐ������Ă�����O���b�h�ɔ��f�B
			if (e.Cancelled == false)
			{
			}
			
			this.Close();
		}
		#endregion
		
		#region *** Private Method ***
		/// <summary>
		/// �C���W�P�[�^�^�C�}�[
		/// </summary>
		void timer_Tick(object sender, EventArgs e)
		{
			if (iconVisible == true)
			{
				IconIndicator.Image = images[iconPat];
				
				if (--iconPat < 0)
				{
					iconPat = images.Length - 1;
				}
			}
		}
		#endregion
	}
	
	/// <summary>
	/// �N���b�N���ꂽ�s�̓��e���܂� EventArgs �ł��B
	/// </summary>
	public class DoWorkEventArgsEx : DoWorkEventArgs
	{
		/// <summary>
		/// �N���b�N���ꂽ�s�̓��e�ł��B
		/// </summary>
		public object[]		Args;
		
		/// <summary>
		/// �R���X�g���N�^�B
		/// </summary>
		/// <param name="argument">RunWorkerAsync �œn���������B����������n���ꍇ��Args�ɂ���邱�ƁB</param>
		public DoWorkEventArgsEx(object argument) : base (argument)
		{
		}
	}
	
	/// <summary>
	/// �N���b�N���ꂽ�s�̓��e���܂� EventHandler �ł��B
	/// </summary>
	public delegate void DoWorkEventHandlerEx(object sender, DoWorkEventArgsEx e);
}