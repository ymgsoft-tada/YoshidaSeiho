
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
	/// [�쐬�� fj]
	/// �e�[�u���ҏW�̍ۂɎg���N���X�ł��B
	/// </summary>
	public partial class k_Sharyo : FieldProp
	{
		/// <summary>
		/// �t�B�[���h[Access ���������p]�B
		/// </summary>
		public const string FID_Auto = "ID_Auto";
		/// <summary>
		/// Access ���������p
		/// </summary>
		public int ID_Auto
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Auto]);	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// Access ���������p�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Auto_Null
		{
			get	{	if (row == null || row[FID_Auto] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Auto]); }	}
			set	{	_set(FID_Auto, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ԗ�ID]�B
		/// </summary>
		public const string FID_Sharyo = "ID_Sharyo";
		/// <summary>
		/// �ԗ�ID
		/// </summary>
		public int ID_Sharyo
		{
			get	{	return Cast.Int(row == null ? null : row[FID_Sharyo]);	}
			set	{	_set(FID_Sharyo, value);	}
		}
		
		/// <summary>
		/// �ԗ�ID�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? ID_Sharyo_Null
		{
			get	{	if (row == null || row[FID_Sharyo] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FID_Sharyo]); }	}
			set	{	_set(FID_Sharyo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ԗ�]�B
		/// </summary>
		public const string FSharyo_Name = "Sharyo_Name";
		/// <summary>
		/// �Ԗ�
		/// </summary>
		public string Sharyo_Name
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Name]);	}
			set	{	_set(FSharyo_Name, value);	}
		}
		
		/// <summary>
		/// �Ԗ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Name_Null
		{
			get	{	if (row == null || row[FSharyo_Name] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Name]); }	}
			set	{	_set(FSharyo_Name, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ǘ��ԍ�]�B
		/// </summary>
		public const string FSharyo_KanriNumber = "Sharyo_KanriNumber";
		/// <summary>
		/// �Ǘ��ԍ�
		/// </summary>
		public int Sharyo_KanriNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_KanriNumber]);	}
			set	{	_set(FSharyo_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �Ǘ��ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_KanriNumber_Null
		{
			get	{	if (row == null || row[FSharyo_KanriNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_KanriNumber]); }	}
			set	{	_set(FSharyo_KanriNumber, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�^��]�B
		/// </summary>
		public const string FSharyo_Katashiki = "Sharyo_Katashiki";
		/// <summary>
		/// �^��
		/// </summary>
		public string Sharyo_Katashiki
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Katashiki]);	}
			set	{	_set(FSharyo_Katashiki, value);	}
		}
		
		/// <summary>
		/// �^���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Katashiki_Null
		{
			get	{	if (row == null || row[FSharyo_Katashiki] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Katashiki]); }	}
			set	{	_set(FSharyo_Katashiki, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���]�B
		/// </summary>
		public const string FSharyo_Shubetsu = "Sharyo_Shubetsu";
		/// <summary>
		/// ���
		/// </summary>
		public string Sharyo_Shubetsu
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Shubetsu]);	}
			set	{	_set(FSharyo_Shubetsu, value);	}
		}
		
		/// <summary>
		/// ��ʁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Shubetsu_Null
		{
			get	{	if (row == null || row[FSharyo_Shubetsu] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Shubetsu]); }	}
			set	{	_set(FSharyo_Shubetsu, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ԑ̌`��]�B
		/// </summary>
		public const string FSharyo_ShataiKejo = "Sharyo_ShataiKejo";
		/// <summary>
		/// �ԑ̌`��
		/// </summary>
		public string Sharyo_ShataiKejo
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_ShataiKejo]);	}
			set	{	_set(FSharyo_ShataiKejo, value);	}
		}
		
		/// <summary>
		/// �ԑ̌`��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_ShataiKejo_Null
		{
			get	{	if (row == null || row[FSharyo_ShataiKejo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_ShataiKejo]); }	}
			set	{	_set(FSharyo_ShataiKejo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�o�^�ԍ�]�B
		/// </summary>
		public const string FSharyo_TorokuNumber = "Sharyo_TorokuNumber";
		/// <summary>
		/// �o�^�ԍ�
		/// </summary>
		public int Sharyo_TorokuNumber
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_TorokuNumber]);	}
			set	{	_set(FSharyo_TorokuNumber, value);	}
		}
		
		/// <summary>
		/// �o�^�ԍ��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_TorokuNumber_Null
		{
			get	{	if (row == null || row[FSharyo_TorokuNumber] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_TorokuNumber]); }	}
			set	{	_set(FSharyo_TorokuNumber, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���[�X���i�i�ō��j]�B
		/// </summary>
		public const string FSharyo_Cost = "Sharyo_Cost";
		/// <summary>
		/// ���[�X���i�i�ō��j
		/// </summary>
		public decimal Sharyo_Cost
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSharyo_Cost]);	}
			set	{	_set(FSharyo_Cost, value);	}
		}
		
		/// <summary>
		/// ���[�X���i�i�ō��j�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Sharyo_Cost_Null
		{
			get	{	if (row == null || row[FSharyo_Cost] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSharyo_Cost]); }	}
			set	{	_set(FSharyo_Cost, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�������p��]�B
		/// </summary>
		public const string FSharyo_Genka = "Sharyo_Genka";
		/// <summary>
		/// �������p��
		/// </summary>
		public decimal Sharyo_Genka
		{
			get	{	return Cast.Decimal(row == null ? null : row[FSharyo_Genka]);	}
			set	{	_set(FSharyo_Genka, value);	}
		}
		
		/// <summary>
		/// �������p��BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public decimal? Sharyo_Genka_Null
		{
			get	{	if (row == null || row[FSharyo_Genka] == System.DBNull.Value) { return null; } else { return Cast.Decimal(row[FSharyo_Genka]); }	}
			set	{	_set(FSharyo_Genka, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�o�^��]�B
		/// </summary>
		public const string FSharyo_DateToroku = "Sharyo_DateToroku";
		/// <summary>
		/// �o�^��
		/// </summary>
		public DateTime Sharyo_DateToroku
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateToroku]);	}
			set	{	_set(FSharyo_DateToroku, value);	}
		}
		
		/// <summary>
		/// �o�^���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Sharyo_DateToroku_Null
		{
			get	{	if (row == null || row[FSharyo_DateToroku] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateToroku]); }	}
			set	{	_set(FSharyo_DateToroku, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Ԍ��L������]�B
		/// </summary>
		public const string FSharyo_DateKigen = "Sharyo_DateKigen";
		/// <summary>
		/// �Ԍ��L������
		/// </summary>
		public DateTime Sharyo_DateKigen
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateKigen]);	}
			set	{	_set(FSharyo_DateKigen, value);	}
		}
		
		/// <summary>
		/// �Ԍ��L�������BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Sharyo_DateKigen_Null
		{
			get	{	if (row == null || row[FSharyo_DateKigen] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateKigen]); }	}
			set	{	_set(FSharyo_DateKigen, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�����ӕی� �J�n��]�B
		/// </summary>
		public const string FSharyo_DateFrom = "Sharyo_DateFrom";
		/// <summary>
		/// �����ӕی� �J�n��
		/// </summary>
		public DateTime Sharyo_DateFrom
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateFrom]);	}
			set	{	_set(FSharyo_DateFrom, value);	}
		}
		
		/// <summary>
		/// �����ӕی� �J�n���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Sharyo_DateFrom_Null
		{
			get	{	if (row == null || row[FSharyo_DateFrom] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateFrom]); }	}
			set	{	_set(FSharyo_DateFrom, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�����ӕی� �I����]�B
		/// </summary>
		public const string FSharyo_DateTo = "Sharyo_DateTo";
		/// <summary>
		/// �����ӕی� �I����
		/// </summary>
		public DateTime Sharyo_DateTo
		{
			get	{	return Cast.DateTime(row == null ? null : row[FSharyo_DateTo]);	}
			set	{	_set(FSharyo_DateTo, value);	}
		}
		
		/// <summary>
		/// �����ӕی� �I�����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public DateTime? Sharyo_DateTo_Null
		{
			get	{	if (row == null || row[FSharyo_DateTo] == System.DBNull.Value) { return null; } else { return Cast.DateTime(row[FSharyo_DateTo]); }	}
			set	{	_set(FSharyo_DateTo, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�Y�t�t�@�C��]�B
		/// </summary>
		public const string FSharyo_File = "Sharyo_File";
		/// <summary>
		/// �Y�t�t�@�C��
		/// </summary>
		public string Sharyo_File
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_File]);	}
			set	{	_set(FSharyo_File, value);	}
		}
		
		/// <summary>
		/// �Y�t�t�@�C���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_File_Null
		{
			get	{	if (row == null || row[FSharyo_File] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_File]); }	}
			set	{	_set(FSharyo_File, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ԗ����ڍ�]�B
		/// </summary>
		public const string FSharyo_Joho = "Sharyo_Joho";
		/// <summary>
		/// �ԗ����ڍ�
		/// </summary>
		public string Sharyo_Joho
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Joho]);	}
			set	{	_set(FSharyo_Joho, value);	}
		}
		
		/// <summary>
		/// �ԗ����ڍׁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Joho_Null
		{
			get	{	if (row == null || row[FSharyo_Joho] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Joho]); }	}
			set	{	_set(FSharyo_Joho, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�p�r]�B
		/// </summary>
		public const string FSharyo_Yoto = "Sharyo_Yoto";
		/// <summary>
		/// �p�r
		/// </summary>
		public string Sharyo_Yoto
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Yoto]);	}
			set	{	_set(FSharyo_Yoto, value);	}
		}
		
		/// <summary>
		/// �p�r�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Yoto_Null
		{
			get	{	if (row == null || row[FSharyo_Yoto] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Yoto]); }	}
			set	{	_set(FSharyo_Yoto, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��Ԓ��]�B
		/// </summary>
		public const string FSharyo_Teiin = "Sharyo_Teiin";
		/// <summary>
		/// ��Ԓ��
		/// </summary>
		public int Sharyo_Teiin
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Teiin]);	}
			set	{	_set(FSharyo_Teiin, value);	}
		}
		
		/// <summary>
		/// ��Ԓ���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Teiin_Null
		{
			get	{	if (row == null || row[FSharyo_Teiin] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Teiin]); }	}
			set	{	_set(FSharyo_Teiin, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ő�ύڗ�]�B
		/// </summary>
		public const string FSharyo_Sekisai = "Sharyo_Sekisai";
		/// <summary>
		/// �ő�ύڗ�
		/// </summary>
		public int Sharyo_Sekisai
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Sekisai]);	}
			set	{	_set(FSharyo_Sekisai, value);	}
		}
		
		/// <summary>
		/// �ő�ύڗʁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Sekisai_Null
		{
			get	{	if (row == null || row[FSharyo_Sekisai] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Sekisai]); }	}
			set	{	_set(FSharyo_Sekisai, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ԗ��d��]�B
		/// </summary>
		public const string FSharyo_Weight = "Sharyo_Weight";
		/// <summary>
		/// �ԗ��d��
		/// </summary>
		public int Sharyo_Weight
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Weight]);	}
			set	{	_set(FSharyo_Weight, value);	}
		}
		
		/// <summary>
		/// �ԗ��d�ʁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Weight_Null
		{
			get	{	if (row == null || row[FSharyo_Weight] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Weight]); }	}
			set	{	_set(FSharyo_Weight, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�ԗ����d��]�B
		/// </summary>
		public const string FSharyo_TotalWeight = "Sharyo_TotalWeight";
		/// <summary>
		/// �ԗ����d��
		/// </summary>
		public int Sharyo_TotalWeight
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_TotalWeight]);	}
			set	{	_set(FSharyo_TotalWeight, value);	}
		}
		
		/// <summary>
		/// �ԗ����d�ʁBSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_TotalWeight_Null
		{
			get	{	if (row == null || row[FSharyo_TotalWeight] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_TotalWeight]); }	}
			set	{	_set(FSharyo_TotalWeight, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[����]�B
		/// </summary>
		public const string FSharyo_Length = "Sharyo_Length";
		/// <summary>
		/// ����
		/// </summary>
		public int Sharyo_Length
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Length]);	}
			set	{	_set(FSharyo_Length, value);	}
		}
		
		/// <summary>
		/// �����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Length_Null
		{
			get	{	if (row == null || row[FSharyo_Length] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Length]); }	}
			set	{	_set(FSharyo_Length, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��]�B
		/// </summary>
		public const string FSharyo_Width = "Sharyo_Width";
		/// <summary>
		/// ��
		/// </summary>
		public int Sharyo_Width
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Width]);	}
			set	{	_set(FSharyo_Width, value);	}
		}
		
		/// <summary>
		/// ���BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Width_Null
		{
			get	{	if (row == null || row[FSharyo_Width] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Width]); }	}
			set	{	_set(FSharyo_Width, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[����]�B
		/// </summary>
		public const string FSharyo_Height = "Sharyo_Height";
		/// <summary>
		/// ����
		/// </summary>
		public int Sharyo_Height
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Height]);	}
			set	{	_set(FSharyo_Height, value);	}
		}
		
		/// <summary>
		/// �����BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Height_Null
		{
			get	{	if (row == null || row[FSharyo_Height] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Height]); }	}
			set	{	_set(FSharyo_Height, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�O�㎲�d]�B
		/// </summary>
		public const string FSharyo_Zenko = "Sharyo_Zenko";
		/// <summary>
		/// �O�㎲�d
		/// </summary>
		public int Sharyo_Zenko
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Zenko]);	}
			set	{	_set(FSharyo_Zenko, value);	}
		}
		
		/// <summary>
		/// �O�㎲�d�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Zenko_Null
		{
			get	{	if (row == null || row[FSharyo_Zenko] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Zenko]); }	}
			set	{	_set(FSharyo_Zenko, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[�O�O���d]�B
		/// </summary>
		public const string FSharyo_Zenzen = "Sharyo_Zenzen";
		/// <summary>
		/// �O�O���d
		/// </summary>
		public int Sharyo_Zenzen
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Zenzen]);	}
			set	{	_set(FSharyo_Zenzen, value);	}
		}
		
		/// <summary>
		/// �O�O���d�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Zenzen_Null
		{
			get	{	if (row == null || row[FSharyo_Zenzen] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Zenzen]); }	}
			set	{	_set(FSharyo_Zenzen, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��㎲�d]�B
		/// </summary>
		public const string FSharyo_Koko = "Sharyo_Koko";
		/// <summary>
		/// ��㎲�d
		/// </summary>
		public int Sharyo_Koko
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Koko]);	}
			set	{	_set(FSharyo_Koko, value);	}
		}
		
		/// <summary>
		/// ��㎲�d�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Koko_Null
		{
			get	{	if (row == null || row[FSharyo_Koko] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Koko]); }	}
			set	{	_set(FSharyo_Koko, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[��O���d]�B
		/// </summary>
		public const string FSharyo_Kozen = "Sharyo_Kozen";
		/// <summary>
		/// ��O���d
		/// </summary>
		public int Sharyo_Kozen
		{
			get	{	return Cast.Int(row == null ? null : row[FSharyo_Kozen]);	}
			set	{	_set(FSharyo_Kozen, value);	}
		}
		
		/// <summary>
		/// ��O���d�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public int? Sharyo_Kozen_Null
		{
			get	{	if (row == null || row[FSharyo_Kozen] == System.DBNull.Value) { return null; } else { return Cast.Int(row[FSharyo_Kozen]); }	}
			set	{	_set(FSharyo_Kozen, value);	}
		}
		
		/// <summary>
		/// �t�B�[���h[���l]�B
		/// </summary>
		public const string FSharyo_Memo = "Sharyo_Memo";
		/// <summary>
		/// ���l
		/// </summary>
		public string Sharyo_Memo
		{
			get	{	return Cast.String(row == null ? null : row[FSharyo_Memo]);	}
			set	{	_set(FSharyo_Memo, value);	}
		}
		
		/// <summary>
		/// ���l�BSystem.DBNull.Value �̏ꍇ null �������܂��B
		/// </summary>
		public string Sharyo_Memo_Null
		{
			get	{	if (row == null || row[FSharyo_Memo] == System.DBNull.Value) { return null; } else { return Cast.String(row[FSharyo_Memo]); }	}
			set	{	_set(FSharyo_Memo, value);	}
		}
		
		#region *** Constructor ***
		/// <summary>
		/// �R���X�g���N�^
		/// </summary>
		/// <param name="o">�ҏW����s��DataRow�ADataRowView�ADBView�̂ǂꂩ�BDBView�̏ꍇ�A���ݎw���Ă���s�̃f�[�^�ɂȂ�܂��B</param>
		public k_Sharyo(object o) : base(o) {}
		#endregion
		/// <summary>
		/// k_Sharyo �^�̋�e�[�u�����쐬���A�Ԃ��܂��B
		/// </summary>
		/// <returns>k_Sharyo �^�̋�e�[�u��</returns>
		public static DataTable GetTable()
		{
			DataTable	dt = new DataTable("k_Sharyo");
			
			DataColumn	col;
			
			col = new DataColumn(FID_Auto, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FID_Sharyo, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Name, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_KanriNumber, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Katashiki, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Shubetsu, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_ShataiKejo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_TorokuNumber, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Cost, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Genka, typeof(decimal));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateToroku, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateKigen, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateFrom, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_DateTo, typeof(DateTime));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_File, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Joho, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Yoto, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Teiin, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Sekisai, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Weight, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_TotalWeight, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Length, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Width, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Height, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Zenko, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Zenzen, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Koko, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Kozen, typeof(int));
			dt.Columns.Add(col);
			
			col = new DataColumn(FSharyo_Memo, typeof(string));
			col.AllowDBNull = true;
			col.MaxLength = 255;
			dt.Columns.Add(col);
			
			return dt;
		}
	}
}
