
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

using ComponentIO;

namespace App
{
	/// <summary>
	/// [��] �[������
	/// </summary>
	public enum eHasu
	{
		/// <summary>
		/// 
		/// </summary>
		None = 0,
		/// <summary>
		/// �؎�
		/// </summary>
		Kirisute = 1,
		/// <summary>
		/// �؏�
		/// </summary>
		Kiriage = 2,
		/// <summary>
		/// �l�̌ܓ�
		/// </summary>
		Shishagonyu = 3,
	}
	
	/// <summary>
	/// [�쐬�� fj]
	/// �e�[�u���ҏW�̍ۂɎg���N���X�ł��B
	/// </summary>
	public static class enumKbn
	{
		/// <summary>
		/// eHasu �ɑΉ����������ł��B
		/// </summary>
		public static Dictionary<int, string> DHasu;
		
		/// <summary>
		/// �񋓎��������������܂��B
		/// </summary>
		public static void InitEnumDictionary()
		{
			DHasu = new Dictionary<int, string>();
			DHasu.Add((int)eHasu.None, "");
			DHasu.Add((int)eHasu.Kirisute, "�؎�");
			DHasu.Add((int)eHasu.Kiriage, "�؏�");
			DHasu.Add((int)eHasu.Shishagonyu, "�l�̌ܓ�");
		}
	}
}
