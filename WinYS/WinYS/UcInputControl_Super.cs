using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// ���[�U�[�R���g���[���̐e�I�u�W�F�N�g�ł��B
	/// </summary>
	public partial class UcInputControl_Super : UserControl
	{
		#region *** Private Value ***
		/// <summary>
		/// ���[�U�[�R���g���[������A�O���b�h�Ɉړ������o���Ă������������l�B
		/// </summary>
		protected bool	grid_move_permission = true;
		#endregion
		
		#region *** Property ***
		/// <summary>
		/// ���[�U�[�R���g���[������A�O���b�h�Ɉړ������o���Ă������������l���擾���܂��B
		/// </summary>
		public bool GridMovePermission
		{
			get
			{
				return grid_move_permission;
			}
		}
		#endregion
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^�B
		/// </summary>
		public UcInputControl_Super()
		{
			InitializeComponent();
		}
		#endregion
	}
}
