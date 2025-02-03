
namespace App
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			GrapeCity.Win.Editors.Fields.DateYearField dateYearField1 = new GrapeCity.Win.Editors.Fields.DateYearField();
			GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField1 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateMonthField dateMonthField1 = new GrapeCity.Win.Editors.Fields.DateMonthField();
			GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField2 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateDayField dateDayField1 = new GrapeCity.Win.Editors.Fields.DateDayField();
			GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField3 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateHourField dateHourField1 = new GrapeCity.Win.Editors.Fields.DateHourField();
			GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField4 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateMinuteField dateMinuteField1 = new GrapeCity.Win.Editors.Fields.DateMinuteField();
			GrapeCity.Win.Editors.Fields.DateLiteralField dateLiteralField5 = new GrapeCity.Win.Editors.Fields.DateLiteralField();
			GrapeCity.Win.Editors.Fields.DateSecondField dateSecondField1 = new GrapeCity.Win.Editors.Fields.DateSecondField();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.gcDate1 = new GrapeCity.Win.Editors.GcDate(this.components);
			this.dropDownButton1 = new GrapeCity.Win.Editors.DropDownButton();
			this.gcShortcut1 = new GrapeCity.Win.Editors.GcShortcut(this.components);
			this.gcTextBox1 = new GrapeCity.Win.Editors.GcTextBox(this.components);
			this.gcComboBox1 = new GrapeCity.Win.Editors.GcComboBox(this.components);
			this.dropDownButton2 = new GrapeCity.Win.Editors.DropDownButton();
			this.gcNumber1 = new GrapeCity.Win.Editors.GcNumber(this.components);
			this.dropDownButton3 = new GrapeCity.Win.Editors.DropDownButton();
			this.gcFunctionKey1 = new GrapeCity.Win.Bars.GcFunctionKey();
			this.c1TrueDBGrid1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
			((System.ComponentModel.ISupportInitialize)(this.gcDate1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.gcNumber1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// gcDate1
			// 
			dateLiteralField1.Text = "/";
			dateLiteralField2.Text = "/";
			dateLiteralField4.Text = ":";
			dateLiteralField5.Text = ":";
			this.gcDate1.Fields.AddRange(new GrapeCity.Win.Editors.Fields.DateField[] {
            dateYearField1,
            dateLiteralField1,
            dateMonthField1,
            dateLiteralField2,
            dateDayField1,
            dateLiteralField3,
            dateHourField1,
            dateLiteralField4,
            dateMinuteField1,
            dateLiteralField5,
            dateSecondField1});
			this.gcDate1.Location = new System.Drawing.Point(337, 183);
			this.gcDate1.Name = "gcDate1";
			this.gcShortcut1.SetShortcuts(this.gcDate1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                System.Windows.Forms.Keys.F5,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcDate1)),
                ((object)(this.gcDate1)),
                ((object)(this.gcDate1))}, new string[] {
                "ShortcutClear",
                "SetNow",
                "ApplyRecommendedValue"}));
			this.gcDate1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton1});
			this.gcDate1.Size = new System.Drawing.Size(93, 27);
			this.gcDate1.TabIndex = 0;
			this.gcDate1.Value = new System.DateTime(2025, 1, 28, 17, 6, 24, 0);
			// 
			// dropDownButton1
			// 
			this.dropDownButton1.Name = "dropDownButton1";
			// 
			// gcTextBox1
			// 
			this.gcTextBox1.Location = new System.Drawing.Point(557, 181);
			this.gcTextBox1.Name = "gcTextBox1";
			this.gcShortcut1.SetShortcuts(this.gcTextBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2}, new object[] {
                ((object)(this.gcTextBox1))}, new string[] {
                "ShortcutClear"}));
			this.gcTextBox1.Size = new System.Drawing.Size(56, 28);
			this.gcTextBox1.TabIndex = 2;
			// 
			// gcComboBox1
			// 
			this.gcComboBox1.ListHeaderPane.Height = 19;
			this.gcComboBox1.Location = new System.Drawing.Point(451, 104);
			this.gcComboBox1.Name = "gcComboBox1";
			this.gcShortcut1.SetShortcuts(this.gcComboBox1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcComboBox1)),
                ((object)(this.gcComboBox1))}, new string[] {
                "ShortcutClear",
                "ApplyRecommendedValue"}));
			this.gcComboBox1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton2});
			this.gcComboBox1.Size = new System.Drawing.Size(106, 77);
			this.gcComboBox1.TabIndex = 3;
			// 
			// dropDownButton2
			// 
			this.dropDownButton2.Name = "dropDownButton2";
			// 
			// gcNumber1
			// 
			this.gcNumber1.Fields.IntegerPart.MinDigits = 1;
			this.gcNumber1.Location = new System.Drawing.Point(437, 341);
			this.gcNumber1.Name = "gcNumber1";
			this.gcShortcut1.SetShortcuts(this.gcNumber1, new GrapeCity.Win.Editors.ShortcutCollection(new System.Windows.Forms.Keys[] {
                System.Windows.Forms.Keys.F2,
                System.Windows.Forms.Keys.Subtract,
                System.Windows.Forms.Keys.OemMinus,
                ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Return)))}, new object[] {
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1)),
                ((object)(this.gcNumber1))}, new string[] {
                "SetZero",
                "SwitchSign",
                "SwitchSign",
                "ApplyRecommendedValue"}));
			this.gcNumber1.SideButtons.AddRange(new GrapeCity.Win.Editors.SideButtonBase[] {
            this.dropDownButton3});
			this.gcNumber1.Size = new System.Drawing.Size(120, 49);
			this.gcNumber1.TabIndex = 4;
			// 
			// dropDownButton3
			// 
			this.dropDownButton3.Name = "dropDownButton3";
			// 
			// gcFunctionKey1
			// 
			this.gcFunctionKey1.Location = new System.Drawing.Point(0, 425);
			this.gcFunctionKey1.Name = "gcFunctionKey1";
			this.gcFunctionKey1.Size = new System.Drawing.Size(800, 25);
			this.gcFunctionKey1.TabIndex = 1;
			this.gcFunctionKey1.Text = "gcFunctionKey1";
			// 
			// c1TrueDBGrid1
			// 
			this.c1TrueDBGrid1.GroupByCaption = "列でグループ化するには、ここに列ヘッダをドラッグします。";
			this.c1TrueDBGrid1.Location = new System.Drawing.Point(327, 266);
			this.c1TrueDBGrid1.Name = "c1TrueDBGrid1";
			this.c1TrueDBGrid1.PreviewInfo.Caption = "印刷プレビューウィンドウ";
			this.c1TrueDBGrid1.PreviewInfo.Location = new System.Drawing.Point(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.Size = new System.Drawing.Size(0, 0);
			this.c1TrueDBGrid1.PreviewInfo.ZoomFactor = 75D;
			this.c1TrueDBGrid1.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen;
			this.c1TrueDBGrid1.PrintInfo.MeasurementPrinterName = null;
			this.c1TrueDBGrid1.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("c1TrueDBGrid1.PrintInfo.PageSettings")));
			this.c1TrueDBGrid1.PropBag = resources.GetString("c1TrueDBGrid1.PropBag");
			this.c1TrueDBGrid1.Size = new System.Drawing.Size(49, 33);
			this.c1TrueDBGrid1.TabIndex = 5;
			this.c1TrueDBGrid1.UseCompatibleTextRendering = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.c1TrueDBGrid1);
			this.Controls.Add(this.gcNumber1);
			this.Controls.Add(this.gcComboBox1);
			this.Controls.Add(this.gcTextBox1);
			this.Controls.Add(this.gcFunctionKey1);
			this.Controls.Add(this.gcDate1);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.gcDate1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcTextBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcComboBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.gcNumber1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.c1TrueDBGrid1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private GrapeCity.Win.Editors.GcDate gcDate1;
		private GrapeCity.Win.Editors.GcShortcut gcShortcut1;
		private GrapeCity.Win.Editors.DropDownButton dropDownButton1;
		private GrapeCity.Win.Bars.GcFunctionKey gcFunctionKey1;
		private GrapeCity.Win.Editors.GcTextBox gcTextBox1;
		private GrapeCity.Win.Editors.GcComboBox gcComboBox1;
		private GrapeCity.Win.Editors.DropDownButton dropDownButton2;
		private GrapeCity.Win.Editors.GcNumber gcNumber1;
		private GrapeCity.Win.Editors.DropDownButton dropDownButton3;
		private C1.Win.C1TrueDBGrid.C1TrueDBGrid c1TrueDBGrid1;
	}
}