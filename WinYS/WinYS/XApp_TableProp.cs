
//
// �����̃v���O������DBAutoProperties2Access2000�ɂ�莩���I�ɐ�������܂����B(fj)
//
// MDB File :
//		D:\client\DotNet4.6_YMGLib5\YoshidaSeiho\WinYS\WinYS\bin\Debug\system\Data.mdb
//

using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace App
{
	/// <summary>
	/// [�쐬�� fj]
	/// Table���`����N���X�ł��B
	/// </summary>
	public partial class TableProp
	{
		#region *** Property ***
		/// <summary>
		/// enumKbn
		/// </summary>
		public const string enumKbn = "enumKbn";
		
		/// <summary>
		/// k_Anken
		/// </summary>
		public const string k_Anken = "k_Anken";
		
		/// <summary>
		/// k_AnkenLease
		/// </summary>
		public const string k_AnkenLease = "k_AnkenLease";
		
		/// <summary>
		/// k_KokyakuKanri
		/// </summary>
		public const string k_KokyakuKanri = "k_KokyakuKanri";
		
		/// <summary>
		/// k_Sharyo
		/// </summary>
		public const string k_Sharyo = "k_Sharyo";
		
		/// <summary>
		/// k_Suitocho
		/// </summary>
		public const string k_Suitocho = "k_Suitocho";
		
		/// <summary>
		/// k_SuitochoKeihi
		/// </summary>
		public const string k_SuitochoKeihi = "k_SuitochoKeihi";
		
		/// <summary>
		/// k_SuitochoSeisan
		/// </summary>
		public const string k_SuitochoSeisan = "k_SuitochoSeisan";
		
		/// <summary>
		/// t_basic
		/// </summary>
		public const string t_basic = "t_basic";
		
		/// <summary>
		/// t_kamoku
		/// </summary>
		public const string t_kamoku = "t_kamoku";
		#endregion
		
		#region *** Public Method ***
		/// <summary>
		/// �S�Ẵe�[�u���̗񋓎��������������܂��B
		/// </summary>
		public static void InitAllEnumDictionary()
		{
			App.enumKbn.InitEnumDictionary();

		}
		#endregion
	}
}
