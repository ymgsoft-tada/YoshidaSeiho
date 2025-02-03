using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Diagnostics;

using GrapeCity.Win.Editors;

using ComponentDB;
using ComponentIO;
using ComponentRegistry;
using GControlGcComboBoxEx;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// DBView(DataView)��DataSource�ɃZ�b�g����^�C�v��ComboBox�ł��B
	/// �C���N�������^���T�[�`�@�\����������Ă��܂��B
	/// </summary>
	public partial class UcTableComboBox : UcInputControl_Super
	{
		#region *** Event ***
		/// <summary>
		/// �R���{�{�b�N�X�̃e�L�X�g������������ꂽ���ɌĂяo����܂��B
		/// </summary>
		public new event EventHandler	TextChanged;
		/// <summary>
		/// �R���{�{�b�N�X��index���ύX���ꂽ���ɌĂяo����܂��B
		/// </summary>
		public event EventHandler		SelectIndexChanged;
		/// <summary>
		/// �R���{�{�b�N�X�̓��͌���
		/// </summary>
		public event EventHandler ValidateComboBox;
		#endregion
		
		#region *** Private Value ***
		/// <summary>
		/// �e�[�u�����(DBView)�B
		/// </summary>
		DBView		dv = null;
		/// <summary>
		/// �T�[�`�p�e�[�u�����(DBView)�B
		/// </summary>
		DBView		dv_search = null;
		/// <summary>
		/// �R���{�e�L�X�g�����񂪋󗓂̂��̂ɂ��Ă͑I�ׂȂ��悤�ɂ���t�B���^�ł��B
		/// </summary>
		string		exceptblank_rowfilter = "";
		/// <summary>
		/// �e�[�u���ɂ�����t�B���^���ł��B
		/// </summary>
		string		rowfilter = "";
		/// <summary>
		/// exceptblank_rowfilter �� rowfilter �����킹���t�B���^���ł��B
		/// </summary>
		string		allfilter = "";
		/// <summary>
		/// �������͂����̂��A�J�[�\���ړ��������̂����m�F���邽�߂̃t���O�B
		/// </summary>
		bool		wordInput = false;
		/// <summary>
		/// �\���J�����C���f�b�N�X�B
		/// </summary>
		int			textSubIndex = -1;
		/// <summary>
		/// �Z���N�g�����Ƀt�H�[�J�X�ړ�����ꍇ�ɁA�����I�ɑI�΂��� INDEX�B
		/// </summary>
		int			selectedIndexNullLeave = -1;
		/// <summary>
		/// �h���b�v�_�E���{�b�N�X���J���̂��֎~���܂��B
		/// </summary>
		bool		disabledDropDown = true;
		/// <summary>
		/// �A�C�R����\�����邩�ǂ�����ݒ肵�܂��B
		/// </summary>
		bool		iconVisible = true;
		/// <summary>
		/// �h���b�v�_�E���{�b�N�X�̃T�C�Y�B
		/// </summary>
		Size		sizeDropDown;
		/// <summary>
		/// Ime�̏�����ԁB
		/// </summary>
		ImeMode		enterImeMode = ImeMode.NoControl;
		/// <summary>
		/// �Z�p���[�^�B
		/// </summary>
		static string   seperator = "��������";
		/// <summary>
		/// �A�C�R���̃C���[�W�摜���擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		static Image	iconImage = null;
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// �A�C�R���̃C���[�W�摜���擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public static Image IconImage
		{
			set
			{
				iconImage = value;
			}
			get
			{
				return iconImage;
			}
		}
		/// <summary>
		/// �Z�p���[�^�B
		/// </summary>
		public static string Seperator
		{
			get
			{
				return seperator;
			}
		}
		/// <summary>
		/// �R���g���[���̋��E���̎�ނ��擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public BorderStyle ComboBorderStyle
		{
			get
			{
				return cmb.BorderStyle;
			}
			set
			{
				cmb.BorderStyle = value;
			}
		}

		/// <summary>
		/// �񊈐����̔w�i�F��ݒ肵�܂��B
		/// </summary>
		public Color DiabledBackColor
		{
			get { return cmb.DisabledBackColor; }
			set { cmb.DisabledBackColor = value; }
		}

		/// <summary>
		/// �񊈐����̕����F��ݒ肵�܂��B
		/// </summary>
		public Color DisabledForeColor
		{
			get { return cmb.DisabledForeColor; }
			set { cmb.DisabledForeColor = value; }
		}

		/// <summary>
		/// �A�C�R����\�����邩�ǂ����擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		[Description("�A�C�R����\�����邩�ǂ����擾�A�܂��͐ݒ肵�܂��B")]
		[DefaultValue( true )]
		public bool		IconVisible
		{
			get
			{
				return iconVisible;
			}
			set
			{
				iconVisible = value;
				pic.Visible = value;
				
				sizeRefresh();
			}
		}
		/// <summary>
		/// �R���{�{�b�N�X���擾���܂��B
		/// </summary>
		public GcComboBoxEx	ComboBox
		{
			get
			{
				return cmb;
			}
		}
		/// <summary>
		/// �R���{�{�b�N�X�� Value �Ɣ�r���邽�߂̔�r�t�B�[���h���擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public string CompareValue
		{
			get
			{
				return cmb.ExCompareValue;
			}
			set
			{
				cmb.ExCompareValue = value;
			}
		}
		/// <summary>
		/// �e�[�u�����(DBView)�B
		/// </summary>
		public DBView DBView
		{
			set
			{
				string		text = cmb.Text;
				
				cmb.TextChanged		-= new EventHandler(cmb_TextChanged);
				
				if (value != null)
				{
					dv		  = new DBView(value.DataTable);
					dv_search = new DBView(value.DataTable);
				}
				else
				{
					dv		  = null;
					dv_search = null;
				}
				
				if (dv != null)
				{
					cmb.ExDataSource = dv.DataView;
				}
				else
				{
					cmb.ExDataSource = null;
				}
				
				for (int i = 0; i < cmb.ListColumns.Count; i++)
				{
					cmb.ListColumns[i].Visible	= false;
				}
				
				cmb.Text = text;
				
				cmb.TextChanged		+= new EventHandler(cmb_TextChanged);
			}
			get
			{
				return dv;
			}
		}
		/// <summary>
		/// �e�[�u���ɂ�����t�B���^���ł��B
		/// </summary>
		public string RowFilter
		{
			get
			{
				return rowfilter;
			}
			set
			{
				rowfilter = value;
				allfilter = makeAllFilter();
				
				if (dv != null)
				{
					string	text = cmb.Text;
					
					dv.RowFilter = allfilter;
					if (text.Length > 0)
					{
						if (cmb.ListColumns.Count > cmb.TextSubItemIndex)
						{
							cmb.SelectedIndex = dv.Search(cmb.ListColumns[cmb.TextSubItemIndex].DataPropertyName, text);
						}
					}
					else
					{
						cmb.SelectedIndex = -1;
					}
					if (cmb.SelectedIndex < 0)
					{
						cmb.Text = text;
					}
				}
			}
		}
		/// <summary>
		/// �e�[�u���ɂ�����t�B���^���ł��B
		/// </summary>
		public string Sort
		{
			get
			{
				if (dv != null)
				{
					return dv.Sort;
				}
				return "";
			}
			set
			{
				if (dv != null)
				{
					dv.Sort = value;
				}
			}
		}
		/// <summary>
		/// �w�肳�ꂽ������ɊY������s��T���A�s���ړ����܂��B
		/// </summary>
		public string Find
		{
			set
			{
				int		index;
				
				if (value != null && value.Length > 0)
				{
					index = dv.Search(cmb.ListColumns[cmb.TextSubItemIndex].DataPropertyName, value);
				}
				else
				{
					index = -1;
				}
				
				if (index != cmb.SelectedIndex)
				{
					cmb.SelectedIndex = index;
				}
			}
		}
		/// <summary>
		/// �R���{�̃h���b�v�_�E�����X�g�̏����T�C�Y���擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public Size DropDownSize
		{
			set
			{
				sizeDropDown	  =
				cmb.DropDown.Size = value;
			}
			get
			{
				return cmb.DropDown.Size;
			}
		}
		/// <summary>
		/// �Z���N�g�����Ƀt�H�[�J�X�ړ�����ꍇ�ɁA�����I�ɑI�΂��� INDEX�B
		/// </summary>
		public int SelectedIndexNullLeave
		{
			set
			{
				selectedIndexNullLeave = value;
			}
			get
			{
				return selectedIndexNullLeave;
			}
		}
		/// <summary>
		/// �R���{���I�����ꂽ���ɕ\�����鍀�ڂ̗�ԍ����擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public int TextSubItemIndex
		{
			set
			{
				if (value < 0)
				{
					// ���ݒ�l�Ȃ̂ŏ������Ȃ��B
					return;
				}

				string	text  = cmb.Text;
				int		count = 0;
				int		i;
				
				cmb.TextChanged		-= new EventHandler(cmb_TextChanged);
				
				for (i = 0; i < cmb.ListColumns.Count; i++)
				{
					if (cmb.ListColumns[i].Visible == true)
					{
						if (count++ == value)
						{
							string colname = cmb.ListColumns[i].DataPropertyName;

							//��2023/3/23 kj �J�����̌^�Ŕ��f
							// �\�������񂪋󗓂̍s�͑I���ł��Ȃ��悤�ɃJ�b�g����t�B���^�B
							exceptblank_rowfilter = DBQuery.GetSql($"({colname} IS NOT NULL)");

							if (dv.DataTable.Columns[colname].DataType == typeof(string))
							{
								exceptblank_rowfilter = $"({exceptblank_rowfilter} AND (LEN({colname}) > 0))";
							}

							//exceptblank_rowfilter = DBQuery.GetSql("(({0} IS NOT NULL) AND (LEN({0}) > 0))", cmb.ListColumns[i].DataPropertyName);
							
							allfilter = makeAllFilter();
							
							if (dv != null)
							{
								dv.RowFilter = allfilter;
								if (cmb.Text.Length > 0)
								{
									cmb.SelectedIndex = dv.Search(cmb.ListColumns[cmb.TextSubItemIndex].DataPropertyName, cmb.Text);
								}
								else
								{
									cmb.SelectedIndex = -1;
								}
							}
							break;
						}
					}
				}
				if (i == cmb.ListColumns.Count)
				{
					Debug.WriteLine("�� �w�肵����͑��݂��܂���ł����B");
					i = 0;
				}
				
				cmb.TextSubItemIndex = i;
				textSubIndex		 = value;
				cmb.Text			 = text;
				
				cmb.TextChanged		+= new EventHandler(cmb_TextChanged);
			}
			get
			{
				return textSubIndex;
			}
		}
		/// <summary>
		/// �e�L�X�g�{�b�N�X�̕����񂪑I������Ă�����̂Ɠ��ꂩ�擾���܂��B
		/// </summary>
		public bool TextSubItemMatch
		{
			get
			{
				if (cmb.SelectedItem == null)
				{
					return false;
				}
				
				return cmb.SelectedItem.SubItems[cmb.TextSubItemIndex].Value.ToString() == cmb.Text;
			}
		}
		/// <summary>
		/// �R���g���[�����t�H�[�J�X���󂯎�������ɁA�������I�����邩�ǂ������擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public bool HighlightText
		{
			set
			{
				cmb.HighlightText = value;
			}
			get
			{
				return cmb.HighlightText;
			}
		}
		/// <summary>
		/// �R���g���[�����ɕ\������e�L�X�g�̔z�u���擾�A�܂��͐ݒ肵�܂��B
		/// </summary>
		public ContentAlignment ContentAlignment
		{
			set
			{
				cmb.ContentAlignment = value;
			}
			get
			{
				return cmb.ContentAlignment;
			}
		}
		///	<summary>
		/// �h���b�v�_�E���{�b�N�X���\������Ă��邩�ǂ������擾���܂��B
		/// </summary>
		public bool DroppedDown
		{
			get
			{
				return cmb.DroppedDown;
			}
		}
		/// <summary>
		/// �I������Ă���e�L�X�g�̕�������擾�܂��͐ݒ肵�܂��B
		/// </summary>
		public new string Text
		{
			get
			{
				return cmb.Text;
			}
			set
			{
				this.Find = value;
				
				if (cmb.Text != value)
				{
					cmb.Text = value;
				}
			}
		}
		/// <summary>
		/// �I������Ă���e�L�X�g�� Value ���擾���܂��B
		/// </summary>
		public object Value
		{
			get
			{
				return cmb.ExGetValue();
			}
		}
		/// <summary>
		/// �t�H�[�J�XIN����ImeMode
		/// </summary>
		public ImeMode EnterImeMode
		{
			set
			{
				enterImeMode = value;
				cmb.ImeMode = enterImeMode;
			}
			get
			{
				return enterImeMode;
			}
		}
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		public UcTableComboBox()
		{
			InitializeComponent();
			
			if (iconImage != null)
			{
				pic.Image = iconImage;
			}
			
			this.Load		 += new EventHandler(UcTableComboBox_Load);
			this.SizeChanged += new EventHandler(UcTableComboBox_SizeChanged);
		}
		#endregion
		
		/// <summary>
		/// �����ɍ����s���������A�J�[�\�������킹�܂��B
		/// </summary>
		/// <param name="field">�t�B�[���h</param>
		/// <param name="value">�l</param>
		public void Search(string field, object value)
		{
			int		index = dv.Search(field, value);
			
			if (index != cmb.SelectedIndex)
			{
				cmb.SelectedIndex = index;
			}
		}
		
		/// <summary>
		/// �R���g���[���̍ĕ`����ꎞ��~���܂��B
		/// </summary>
		public void BeginUpdate()
		{
			cmb.BeginUpdate();
		}
		
		/// <summary>
		/// BeginUpdate() �ɂ���Ē�~����Ă����R���g���[���̍ĕ`����ĊJ���܂��B
		/// </summary>
		public void EndUpdate()
		{
			cmb.TextChanged	-= new EventHandler(cmb_TextChanged);
			
			// �\���A�C�e�����I������Ă��Ȃ��B
			if (textSubIndex == -1)
			{
				Debug.WriteLine("�� TextSubItemIndex ���ݒ肳��Ă��܂���B");
				this.TextSubItemIndex = 0;
			}
			
			int		index = cmb.SelectedIndex;
			
			// EndUpdate �� SelectedIndex ������� 0 �ɐݒ肳���B�B�B
			cmb.EndUpdate();
			
			cmb.SelectedIndex = index;
			
			cmb.TextChanged	+= new EventHandler(cmb_TextChanged);
			
			// ���W�X�g���́i�ۑ����Ă���΁j������ݒ�B
			int		height = 0;//Cast.Int(RegControl.Pop(cmb, "Height"));
			
			if (height != 0)
			{
				sizeDropDown	  =
				cmb.DropDown.Size = new Size(sizeDropDown.Width, height);
			}
		}
		
		/// <summary>
		/// ���ݒ肵�܂��B
		/// </summary>
		/// <param name="field">�t�B�[���h���B</param>
		/// <param name="text">�񖼁B</param>
		/// <param name="width">�񕝁B</param>
		public void SetColumn(string field, string text, int width)
		{
			SetColumn(field, text, width, ContentAlignment.MiddleLeft);
		}
		
		/// <summary>
		/// ���ݒ肵�܂��B
		/// </summary>
		/// <param name="field">�t�B�[���h���B</param>
		/// <param name="text">�񖼁B</param>
		/// <param name="width">�񕝁B</param>
		/// <param name="align">�񖼂̕\���ʒu�B</param>
		public void SetColumn(string field, string text, int width, ContentAlignment align)
		{
			int		colno = getColumn(field);
			
			if (colno == -1)
			{
				return;
			}
			cmb.ListColumns[colno].Visible					= true;
			cmb.ListColumns[colno].Width					= width;
			cmb.ListColumns[colno].Header.Text				= text;
			cmb.ListColumns[colno].Header.ContentAlignment	= ContentAlignment.MiddleCenter;
			
			cmb.ListColumns[colno].Header.ForeColor			= Color.DimGray;
			cmb.ListColumns[colno].DefaultSubItem.ContentAlignment = align;
		}
		
		#region *** Event ***
		/// <summary>
		/// �t�H�[�����[�h
		/// </summary>
		void UcTableComboBox_Load(object sender, EventArgs e)
		{
			// ��w�b�_��\������B
			cmb.ListHeaderPane.Visible	= true;

			// 'a%5%' ���������� 'a��5%' a��5���擪�ɂ��镶���� �Ɛ������t�B���^�ł���悤�ɔ��p�L���͓��͂ł��Ȃ�����B
			cmb.Format = "^@";
			
			// �h���b�v�_�E���`��
			cmb.AutoSelect				= false;
			cmb.AutoCompleteMode		= AutoCompleteMode.None;
			cmb.AutoCompleteSource		= AutoCompleteSource.None;
			cmb.DropDownStyle			= ComboBoxStyle.DropDown;
			cmb.DropDown.AllowResize	= true;
			cmb.DropDown.ShowShadow		= true;
			
			//cmb.DisabledBackColor		= cmb.BackColor;
			
			cmb.ScrollBarMode			= ScrollBarMode.Fixed;
			cmb.ImeMode					= enterImeMode;
			
			//�� �C�x���g�ݒ�
			this.Enter			+= new EventHandler(UcTableComboBox_Enter);
			this.Leave			+= new EventHandler(UcTableComboBox_Leave);
			cmb.TextChanging	+= new TextChangingEventHandler(cmb_TextChanging);
			cmb.TextChanged		-= new EventHandler(cmb_TextChanged);
			cmb.TextChanged		+= new EventHandler(cmb_TextChanged);
			cmb.KeyPress		+= new KeyPressEventHandler(cmb_KeyPress);
			cmb.KeyDown			+= new KeyEventHandler(cmb_KeyDown);
			cmb.KeyUp			+= new KeyEventHandler(cmb_KeyUp);
			cmb.DropDownOpening += new EventHandler<DropDownOpeningEventArgs>(cmb_DropDownOpening);
			cmb.DropDownOpened	+= new EventHandler(cmb_DropDownOpened);
			cmb.DropDownClosing += new EventHandler<DropDownClosingEventArgs>(cmb_DropDownClosing);
			cmb.DropDownClosed	+= new EventHandler(cmb_DropDownClosed);
			cmb.SelectedIndexChanged += new EventHandler(cmb_SelectedIndexChanged);
			cmb.PreviewKeyDown += new PreviewKeyDownEventHandler(cmb_PreviewKeyDown);
			cmb.Validated += cmb_Validated;
			pic.Click += new EventHandler(pic_Click);
		}

		/// <summary>
		/// �R���{�{�b�N�X�̌��؏���
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		void cmb_Validated(object sender, EventArgs e)
		{
			if (ValidateComboBox != null)
			{
				ValidateComboBox(cmb, e);
			}
		}
		
		/// <summary>
		/// �R���{�{�b�N�X�Ƀt�H�[�J�XIN������
		/// </summary>
		void UcTableComboBox_Enter(object sender, EventArgs e)
		{
			cmb.Select();
			cmb.SelectAll();
		}
		
		/// <summary>
		/// �t�H�[�J�X�A�E�g�B�I�����Ȃ��ꍇ�ɁA�����I�ɍ��ڂ����蓖�Ă邱�Ƃ��ł��܂��B
		/// </summary>
		void UcTableComboBox_Leave(object sender, EventArgs e)
		{
			if (cmb.SelectedIndex < 0)
			{
				if (selectedIndexNullLeave >= 0)
				{
					if (cmb.Items.Count > 0)
					{
						cmb.SelectedIndex = selectedIndexNullLeave;
					}
				}

				// ���I���Ȃ̂œ��͒l���N���A���Ă����B
				cmb.Text = "";
			}
			
			// �h���b�v�_�E���֎~�ŏI��点��B
			disabledDropDown = true;
		}
		
		/// <summary>
		/// ���[�U�[�R���g���[���̃T�C�Y�ύX�ɃR���{�{�b�N�X��Ǐ]������B
		/// </summary>
		void UcTableComboBox_SizeChanged(object sender, EventArgs e)
		{
			sizeRefresh();
		}
		
		/// <summary>
		/// �A�C�R���G���N���b�N�������̏���
		/// </summary>
		void pic_Click(object sender, EventArgs e)
		{
			cmb.Select();
			cmb.SelectAll();
		}
		
		#region ComboBox
		void cmb_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
		{
			
		}
		
		/// <summary>
		/// �L�[���������B
		/// </summary>
		void cmb_KeyDown(object sender, KeyEventArgs e)
		{
			GcComboBoxEx	cbox = (GcComboBoxEx)sender;
			bool			cursor_move = false;
			
//Debug.WriteLine("--- KeyDown");
//Debug.WriteLine("  Key " + e.KeyCode);
//Debug.WriteLine("  SelectedIndex " + cbox.SelectedIndex);
			
			// �h���b�v�_�E�����B
			disabledDropDown = false;
			
			switch (e.KeyCode)
			{
				case Keys.Delete :
				case Keys.Back :
					wordInput = true;
					disabledDropDown = true;
					break;
				case Keys.PageUp :
				case Keys.PageDown :
				case Keys.Up :
				case Keys.Down :
					// -1 �Ƃ����Ȃ���A������ dv.Count �𒴂����l������ɕێ����Ă����肷��B
					// ���̂܂܃J�[�\���𓮂����Ƃ��肦�Ȃ� Index �ŗ�����̂ŁA�����ł��̒l���N���A�B
					if (cbox.SelectedIndex == -1)
					{
						if (dv.Count > 0)
						{
							cbox.TextChanging  += new TextChangingEventHandler(cancelTextChanging);
							// �l���N���A�B
							cbox.SelectedIndex =  0;
							
							if (dv.Count > 1)
							{
								// ��I���ɖ߂��A�擪����J�[�\�����ړ�����悤�ɁB
								// ���Ȃ�Ӗ��s�������ACount = 1 �����Ȃ��ꍇ�ɂ�������ƁASelectIndex�̒l���ǂ������Ƃ�����̃G���[�ŗ�����B
								cbox.SelectedIndex = -1;
							}
							cbox.TextChanging  -= new TextChangingEventHandler(cancelTextChanging);
						}
					}
					
					wordInput = false;
					cursor_move = true;
					break;
				case Keys.Tab :
					wordInput = false;
					cursor_move = true;
					break;
				case Keys.Enter :
					wordInput = false;
					break;
				default :
					wordInput = true;
					break;
			}
			
			if (cursor_move == true)
			{
				if (cbox.DroppedDown == false)
				{
					if (disabledDropDown == false)
					{
						// �e�L�X�g���������ɕύX�����̂𖳗����h���B
						cbox.TextChanging  += new TextChangingEventHandler(cancelTextChanging);
						cbox.DroppedDown	= true;
						cbox.TextChanging  -= new TextChangingEventHandler(cancelTextChanging);
					}
				}
				
				// �}�E�X�J�[�\�����I���̎ז������Ȃ��悤�Ɉړ����Ă���
				Cursor.Position = this.PointToScreen(new Point(cbox.Left + cbox.Width, cbox.Top + cbox.Height));
			}
//Debug.WriteLine("  WordInput " + wordInput);
		}
		
		/// <summary>
		/// �L�[���������B
		/// </summary>
		void cmb_KeyUp(object sender, KeyEventArgs e)
		{
//Debug.WriteLine("--- KeyUp");
			// �h���b�v�_�E���֎~�B
			disabledDropDown = true;
		}
		
		/// <summary>
		/// �L�[�����Ă��鎞�B
		/// </summary>
		void cmb_KeyPress(object sender, KeyPressEventArgs e)
		{
//Debug.WriteLine("--- KeyPress");
		}

		void cmb_TextChanging(object sender, TextChangingEventArgs e)
		{
			if (e.Result == seperator)
			{
				e.Cancel = true;
			}
		}
		
		/// <summary>
		/// �e�L�X�g�`�F���W�������L�����Z���B
		/// </summary>
		void cancelTextChanging(object sender, TextChangingEventArgs e)
		{
			e.Cancel = true;
		}
		
		/// <summary>
		/// �e�L�X�g�ύX���B
		/// </summary>
		void cmb_TextChanged(object sender, EventArgs e)
		{
			GcComboBox	cbox = (GcComboBox)sender;
			int			pos	 = cbox.SelectionStart;
			string		text = cbox.Text;
			
			if (dv == null)
			{
				return;
			}
//Debug.WriteLine("--- TextChanged�@" + cbox.SelectedIndex);
			
			// �J�[�\���㉺�Ȃǂ̑I���ł̓t�B���^�ω������Ȃ��i���X�g�\�����Ƀt�B���^��ύX����ƁAIndex�����������Ȃ��ė�����j
			if (wordInput == false)
			{
				// �O���� TextChanged �ʒm
				if (TextChanged != null)
				{
					TextChanged(this, e);
				}
				return;
			}
//Debug.WriteLine("--- TextChanged�@" + cbox.Text);
			// Text�v���p�e�B�̖������������i�����C�x���g�Ăяo���j���֎~�B
			cbox.TextChanged -= new EventHandler(cmb_TextChanged);
			
			if (text.Length == 0)
			{
				if (cbox.DroppedDown == true)
				{
					cbox.DroppedDown = false;
				}
				else
				{
					// �C���N�������^���T�[�`����������B�t�B���^�����Ă������ڂ͑S�Č��ɖ߂��B
					cbox.TextChanging += new TextChangingEventHandler(cancelTextChanging);
					dv.RowFilterQuery(allfilter);
					
					try
					{
						cbox.SelectedIndex = dv.Search(cbox.ListColumns[cbox.TextSubItemIndex].DataPropertyName, cbox.Text);
					}
					catch(Exception ex)
					{
						Debug.WriteLine(ex.Message);
					}
					cbox.TextChanging -= new TextChangingEventHandler(cancelTextChanging);
				}
			}
			else if (cbox.SelectedIndex == -1)
			{
				// �O��̃T�[�`������ƈ���Ă����猟���J�n�B
				//�� �C���N�������^���T�[�`���[�h
				//
				// �L����@��
				//	|   1|�L����� A|
				//	|   3|�L����� C|
				//	|  31|�L����� AA|
				//	| 100|�L����� DD|
				//
				// �u�L����Ёv�Ƃ������t�Ń��X�g�A�b�v�������ł̌������o����B
//Debug.WriteLine("  �T�[�`[" + text + "," + cbox.DroppedDown + "," + cbox.SelectedIndex + "]");
				string		filter = "";
				
				for (int i = 0; i < cbox.ListColumns.Count; i++)
				{
					if (cbox.ListColumns[i].Visible == false)
					{
						continue;
					}
					
					if (dv.DataTable.Columns[i].DataType == typeof(string))
					{
						if (text.Length == 1)
						{
							// �P�����̏ꍇ�͐擪����
							filter += $"{DBQuery.CreateLikeKanaString(dv.DataTable.Columns[i].Caption, getFilter(text))} OR ";
							//filter += DBQuery.GetSql("({0} LIKE '{1}%') OR ",
							//	dv.DataTable.Columns[i].Caption,
							//	getFilter(text)
							//	);
						}
						else
						{
							// �Q�������z���镶����́A���t�Ԃɂ����Ă��T�[�`����B
							filter += $"{DBQuery.CreateLikeKanaString(dv.DataTable.Columns[i].Caption, getFilter(text), true)} OR ";
							//filter += DBQuery.GetSql("({0} LIKE '%{1}%') OR ",
							//	dv.DataTable.Columns[i].Caption,
							//	getFilter(text)
							//	);
						}
					}
					else
					{
						// �����͐擪������͂��Ă���Ƃ݂Ȃ��T�[�`�B
						filter += DBQuery.GetSql("(Convert({0}, 'System.String') LIKE '{1}%') OR ", 
							dv.DataTable.Columns[i].Caption,
							getFilter(text)
							);
					}
				}
				if (filter != "")
				{
					// �Ō�� AND �������B
					filter = filter.Remove(filter.LastIndexOf(" OR "), 4);
				}
				
				if (allfilter != "")
				{
					dv_search.RowFilterQuery("({0}) AND ({1})", allfilter, filter);
				}
				else
				{
					dv_search.RowFilterQuery("{0}'", filter);
				}
					
//Debug.WriteLine("  filter(" + dv_search.Count + ") [" + dv_search.RowFilter + "]");
				
				if (dv_search.RowFilter != dv.RowFilter)
				{
//Debug.WriteLine("  filter changed. '" + cbox.SelectedIndex + "'");
					//�� ���X�g�Ƀt�B���^��������B
					// �e�L�X�g���������ɕύX�����̂𖳗����h���B
					cbox.TextChanging  += new TextChangingEventHandler(cancelTextChanging);
					dv.RowFilter		= dv_search.RowFilter;
					
					// �t�B���^�����Ȃ����̂ŁA��I���Ƃ���B
					cbox.SelectedIndex = -1;
					
					cbox.TextChanging  -= new TextChangingEventHandler(cancelTextChanging);
				}
				
				if (dv.Count == 0)
				{
//Debug.WriteLine("  drop down closing.");
					if (cbox.DroppedDown == true)
					{
//Debug.WriteLine("  drop down closed.");
						cbox.DroppedDown = false;
					}
				}
				else
				{
					if (cbox.DroppedDown == false)
					{
//Debug.WriteLine("  drop down opencheck.");
						if (disabledDropDown == false)
						{
//Debug.WriteLine("  drop down opening. '" + cbox.SelectedIndex + "'");
							// �e�L�X�g���������ɕύX�����̂𖳗����h���B
							cbox.TextChanging  += new TextChangingEventHandler(cancelTextChanging);
							cbox.DroppedDown	= true;
							
							if (dv.Count == 1)
							{
								cbox.SelectedIndex = 0;
							}
							else
							{
								// �I�[�v�����͔�I���B
								cbox.SelectedIndex = -1;
							}

							cbox.TextChanging  -= new TextChangingEventHandler(cancelTextChanging);
//Debug.WriteLine("  drop down opened. '" + cbox.SelectedIndex + "'");
						}
					}
					else
					{
						if (dv.Count == 1)
						{
							cbox.SelectedIndex = 0;
						}
					}
				}
				cbox.Text = text;
//Debug.WriteLine("  text[" + text + "] cbox.Text[" + cbox.Text + "]");
				cbox.SelectionStart = pos > cbox.Text.Length ? cbox.Text.Length : pos;
				cbox.Refresh();
			}
			
			// �O���� TextChanged �ʒm
			if (TextChanged != null)
			{
				TextChanged(this, e);
			}
			
			// �C�x���g���������ɖ߂�
			cbox.TextChanged += new EventHandler(cmb_TextChanged);
			
//Debug.WriteLine("--- textchange end[" + cbox.Text + "," + cbox.DroppedDown + "]");
		}
		
		/// <summary>
		/// index ���ύX���ꂽ���ɌĂяo����܂��B
		/// </summary>
		void cmb_SelectedIndexChanged(object sender, EventArgs e)
		{
//Debug.WriteLine("--- SelectedIndexChanged " + cmb.SelectedIndex);
			if (SelectIndexChanged != null)
			{
				SelectIndexChanged(this, e);
			}
		}
		
		/// <summary>
		/// �h���b�v�_�E�����J�����O�ł��B
		/// </summary>
		void cmb_DropDownOpening(object sender, DropDownOpeningEventArgs e)
		{
//Debug.WriteLine("--- DropDownOpening");
//Debug.WriteLine("  Focused : " + ((Control)sender).Focused);
			// DropDown ���L�����Z������ƃT�C�Y������ɏ����������̂ŁA�Đݒ肷��B
			GcComboBox	cbox  = (GcComboBox)sender;
			
			if (cbox.Focused == false)
			{
				e.Cancel = true;
			}
			else
			{
				int		width = 0;
				
				for (int i = 0; i < cbox.ListColumns.Count; i++)
				{
					if (cbox.ListColumns[i].Visible == false)
					{
						continue;
					}
					
					width += cbox.ListColumns[i].Width;
				}
				
				cbox.DropDown.Size = new Size(sizeDropDown.Width + 4, sizeDropDown.Height);
			}
		}
		
		/// <summary>
		/// �h���b�v�_�E�����J���܂��B
		/// </summary>
		void cmb_DropDownOpened(object sender, EventArgs e)
		{
//Debug.WriteLine("--- DropDownOpened");
			grid_move_permission = false;
		}
		
		/// <summary>
		/// �h���b�v�_�E������钼�O�ł��B
		/// </summary>
		void cmb_DropDownClosing(object sender, DropDownClosingEventArgs e)
		{
//Debug.WriteLine("--- DropDownClosing");
			GcComboBoxEx	cbox = (GcComboBoxEx)sender;

			if (cbox.SelectedIndex == -1 && cbox.Text.Length > 0)
			{
				if (((DataView)cbox.ExDataSource).Count > 0)
				{
					cbox.SelectedIndex = 0;
				}
			}
			
			// ���݂̕ύX���ꂽ������ۑ��B
			sizeDropDown = new Size(sizeDropDown.Width + 4, cbox.DropDown.Size.Height);
			//RegControl.Push(cmb, "Height", cbox.DropDown.Size.Height);
//Debug.WriteLine("size: " + cbox.DropDown.Size.Width + ", " + cbox.DropDown.Size.Height);
		}
		
		/// <summary>
		/// �h���b�v�_�E������܂��B
		/// </summary>
		void cmb_DropDownClosed(object sender, EventArgs e)
		{
//Debug.WriteLine("--- DropDownClosed");
			GcComboBoxEx	cbox = (GcComboBoxEx)sender;
			
			grid_move_permission = true;
			

			object selected_val = null;

			// �I�����Ă���e�L�X�g�ɕύX�B
			wordInput = false;
			if (cbox.SelectedItem != null)
			{
				cbox.Text = cbox.SelectedItem.SubItems[cbox.TextSubItemIndex].Value.ToString();
				selected_val = cbox.ExGetValue();
			}
			
			// �C���N�������^���T�[�`����������B�t�B���^�����Ă������ڂ͑S�Č��ɖ߂��B
			cbox.TextChanging += new TextChangingEventHandler(cancelTextChanging);
			dv.RowFilterQuery(allfilter);

			if (selected_val != null)
			{
				cbox.ExSetSelectedIndexByValue(selected_val);
			}
			else
			{
				cbox.SelectedIndex = dv.Search(cbox.ListColumns[cbox.TextSubItemIndex].DataPropertyName, cbox.Text);
			}
			cbox.TextChanging -= new TextChangingEventHandler(cancelTextChanging);
			
			// �N���[�Y�i�������͂��̒��O�̓�C�x���g�E�E�E�H�j�őS�I���������������ۂ��̂ŁA�����ł�����x�S�I�����Ă����B
			cbox.SelectAll();

			if (ValidateComboBox != null)
			{
				ValidateComboBox(cmb, e);
			}
		}
		#endregion
		#endregion
		
		#region *** Private method ***
		/// <summary>
		/// ��ԍ����擾�B
		/// </summary>
		/// <param name="field">��t�B�[���h���B</param>
		/// <returns>��ԍ��B</returns>
		int		getColumn(string field)
		{
			int		colno;
			
			for (colno = 0; colno < cmb.ListColumns.Count; colno++)
			{
				if (cmb.ListColumns[colno].DataPropertyName == field)
				{
					break;
				}
			}
			if (colno == cmb.ListColumns.Count)
			{
				colno = -1;
			}
			
			return colno;
		}
		
		/// <summary>
		/// ���[�U�[�w���rowfilter�ƃV�X�e���w��̃t�B���^�����킹����������쐬����B
		/// </summary>
		/// <returns>���������킹���t�B���^������B</returns>
		string makeAllFilter()
		{
			string[]	fils = {rowfilter, exceptblank_rowfilter};
			string		allfil;
			
			allfil = "(";
			
			for (int i = 0; i < fils.Length; i++)
			{
				if (fils[i] != null && fils[i] != "")
				{
					// ��ł��t�B���^�����񂪍쐬����Ă����� AND �Ō��ԁB
					if (i > 0 && allfil != "(")
					{
						allfil += " AND ";
					}
					allfil += "(" + fils[i] + ")";
				}
			}
			
			allfil += ")";
			
			// ������ׂ��t�B���^���Ȃ������B
			if (allfil == "()")
			{
				allfil = "";
			}
			
			return allfil;
		}
		
		/// <summary>
		/// �������t�B���^��������擾���܂��B
		/// </summary>
		/// <param name="text">����L�����܂ރe�L�X�g�B</param>
		/// <returns>����L�������������e�L�X�g�B</returns>
		string getFilter(string text)
		{
			text = Regex.Replace(text, "%", "");
			
			return text;
		}
		
		/// <summary>
		/// �\���T�C�Y�����t���b�V�����܂��B
		/// </summary>
		void sizeRefresh()
		{
			if (iconVisible == true)
			{
				pic.SetBounds( 0, (this.Height-20)/2, 20, 20);
				cmb.SetBounds(20, 0, this.Width-20, this.Height);
			}
			else
			{
				cmb.SetBounds( 0, 0, this.Width, this.Height);
			}
		}
		#endregion
		
		#region *** For Debug ***
		/// <summary>
		/// �G���[�\���BDEBUG���ł̂ݗL��
		/// </summary>
		[Conditional("DEBUG")]
		private static void _write_err(Exception ex)
		{
			Debug.WriteLine("������ Exception");
			Debug.WriteLine("Source     = {0}", ex.Source);
			Debug.WriteLine("Type       = {0}", ex.GetType().ToString());
			Debug.WriteLine("Message    = {0}", ex.Message);
			Debug.WriteLine("StackTrace = {0}", ex.StackTrace);
			Debug.WriteLine("");
		}
		#endregion
	}
}
