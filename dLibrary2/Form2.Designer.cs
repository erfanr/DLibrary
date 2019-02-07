namespace dLibrary2
{
    partial class Form2
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.minimizeBtn = new MetroFramework.Controls.MetroButton();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.searchBox2 = new MetroFramework.Controls.MetroTextBox();
            this.searchBtn = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.searchBox = new MetroFramework.Controls.MetroTextBox();
            this.searchCombo = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.resNum = new MetroFramework.Controls.MetroTextBox();
            this.resCode = new MetroFramework.Controls.MetroTextBox();
            this.resType = new MetroFramework.Controls.MetroTextBox();
            this.resTrans = new MetroFramework.Controls.MetroTextBox();
            this.resAuthor = new MetroFramework.Controls.MetroTextBox();
            this.resName = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.resList = new System.Windows.Forms.ListBox();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroPanel1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.metroPanel1.Controls.Add(this.minimizeBtn);
            this.metroPanel1.Controls.Add(this.closeBtn);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(512, 24);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroPanel1_MouseDown_1);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Location = new System.Drawing.Point(462, 0);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(25, 24);
            this.minimizeBtn.TabIndex = 2;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.minimizeBtn.UseCustomBackColor = true;
            this.minimizeBtn.UseSelectable = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.Location = new System.Drawing.Point(487, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(25, 24);
            this.closeBtn.TabIndex = 1;
            this.closeBtn.Text = "X";
            this.closeBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.closeBtn.UseCustomBackColor = true;
            this.closeBtn.UseSelectable = true;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroPanel2.Controls.Add(this.searchBox2);
            this.metroPanel2.Controls.Add(this.searchBtn);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.searchBox);
            this.metroPanel2.Controls.Add(this.searchCombo);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(12, 27);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(488, 38);
            this.metroPanel2.TabIndex = 2;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.UseCustomBackColor = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // searchBox2
            // 
            // 
            // 
            // 
            this.searchBox2.CustomButton.Image = null;
            this.searchBox2.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.searchBox2.CustomButton.Name = "";
            this.searchBox2.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBox2.CustomButton.TabIndex = 1;
            this.searchBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox2.CustomButton.UseSelectable = true;
            this.searchBox2.CustomButton.Visible = false;
            this.searchBox2.Lines = new string[0];
            this.searchBox2.Location = new System.Drawing.Point(350, 3);
            this.searchBox2.MaxLength = 32767;
            this.searchBox2.Name = "searchBox2";
            this.searchBox2.PasswordChar = '\0';
            this.searchBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox2.SelectedText = "";
            this.searchBox2.SelectionLength = 0;
            this.searchBox2.SelectionStart = 0;
            this.searchBox2.ShortcutsEnabled = true;
            this.searchBox2.Size = new System.Drawing.Size(75, 29);
            this.searchBox2.TabIndex = 4;
            this.searchBox2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchBox2.UseCustomBackColor = true;
            this.searchBox2.UseSelectable = true;
            this.searchBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(3, 3);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 29);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "جستجو";
            this.searchBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchBtn.UseCustomBackColor = true;
            this.searchBtn.UseSelectable = true;
            this.searchBtn.Click += new System.EventHandler(this.metroButton1_Click);
            this.searchBtn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(208, 8);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(55, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "بر اساس";
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // searchBox
            // 
            // 
            // 
            // 
            this.searchBox.CustomButton.Image = null;
            this.searchBox.CustomButton.Location = new System.Drawing.Point(47, 1);
            this.searchBox.CustomButton.Name = "";
            this.searchBox.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.searchBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.searchBox.CustomButton.TabIndex = 1;
            this.searchBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.searchBox.CustomButton.UseSelectable = true;
            this.searchBox.CustomButton.Visible = false;
            this.searchBox.Lines = new string[0];
            this.searchBox.Location = new System.Drawing.Point(269, 3);
            this.searchBox.MaxLength = 32767;
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.searchBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.searchBox.SelectedText = "";
            this.searchBox.SelectionLength = 0;
            this.searchBox.SelectionStart = 0;
            this.searchBox.ShortcutsEnabled = true;
            this.searchBox.Size = new System.Drawing.Size(75, 29);
            this.searchBox.TabIndex = 3;
            this.searchBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchBox.UseCustomBackColor = true;
            this.searchBox.UseSelectable = true;
            this.searchBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.searchBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // searchCombo
            // 
            this.searchCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.searchCombo.DisplayMember = "1";
            this.searchCombo.FormattingEnabled = true;
            this.searchCombo.ItemHeight = 23;
            this.searchCombo.Items.AddRange(new object[] {
            "نام کتاب",
            "نام نویسنده",
            "نام مترجم",
            "کد",
            "شماره مستقل"});
            this.searchCombo.Location = new System.Drawing.Point(84, 3);
            this.searchCombo.Name = "searchCombo";
            this.searchCombo.Size = new System.Drawing.Size(121, 29);
            this.searchCombo.TabIndex = 3;
            this.searchCombo.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.searchCombo.UseCustomBackColor = true;
            this.searchCombo.UseSelectable = true;
            this.searchCombo.ValueMember = "1";
            this.searchCombo.SelectedIndexChanged += new System.EventHandler(this.searchCombo_SelectedIndexChanged);
            this.searchCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(428, 8);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(57, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "جستجوی";
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // metroPanel3
            // 
            this.metroPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroPanel3.Controls.Add(this.metroLabel8);
            this.metroPanel3.Controls.Add(this.metroLabel7);
            this.metroPanel3.Controls.Add(this.metroLabel6);
            this.metroPanel3.Controls.Add(this.metroLabel5);
            this.metroPanel3.Controls.Add(this.metroLabel4);
            this.metroPanel3.Controls.Add(this.metroLabel3);
            this.metroPanel3.Controls.Add(this.resNum);
            this.metroPanel3.Controls.Add(this.resCode);
            this.metroPanel3.Controls.Add(this.resType);
            this.metroPanel3.Controls.Add(this.resTrans);
            this.metroPanel3.Controls.Add(this.resAuthor);
            this.metroPanel3.Controls.Add(this.resName);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(12, 71);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(241, 212);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel3.UseCustomBackColor = true;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(148, 183);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(90, 19);
            this.metroLabel8.TabIndex = 13;
            this.metroLabel8.Text = ": شماره مستقل";
            this.metroLabel8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel8.UseCustomBackColor = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(208, 148);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(29, 19);
            this.metroLabel7.TabIndex = 12;
            this.metroLabel7.Text = ": کد";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(167, 113);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = ": دسته بندی";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(191, 78);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 10;
            this.metroLabel5.Text = ": مترجم";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(177, 43);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 9;
            this.metroLabel4.Text = ": نویسنده";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            this.metroLabel4.Click += new System.EventHandler(this.metroLabel4_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(179, 8);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = ": نام کتاب";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // resNum
            // 
            // 
            // 
            // 
            this.resNum.CustomButton.Image = null;
            this.resNum.CustomButton.Location = new System.Drawing.Point(114, 1);
            this.resNum.CustomButton.Name = "";
            this.resNum.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resNum.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resNum.CustomButton.TabIndex = 1;
            this.resNum.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resNum.CustomButton.UseSelectable = true;
            this.resNum.CustomButton.Visible = false;
            this.resNum.Lines = new string[0];
            this.resNum.Location = new System.Drawing.Point(3, 178);
            this.resNum.MaxLength = 32767;
            this.resNum.Name = "resNum";
            this.resNum.PasswordChar = '\0';
            this.resNum.ReadOnly = true;
            this.resNum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resNum.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resNum.SelectedText = "";
            this.resNum.SelectionLength = 0;
            this.resNum.SelectionStart = 0;
            this.resNum.ShortcutsEnabled = true;
            this.resNum.Size = new System.Drawing.Size(142, 29);
            this.resNum.TabIndex = 8;
            this.resNum.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resNum.UseCustomBackColor = true;
            this.resNum.UseSelectable = true;
            this.resNum.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resNum.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resNum.Click += new System.EventHandler(this.metroTextBox7_Click);
            this.resNum.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // resCode
            // 
            // 
            // 
            // 
            this.resCode.CustomButton.Image = null;
            this.resCode.CustomButton.Location = new System.Drawing.Point(174, 1);
            this.resCode.CustomButton.Name = "";
            this.resCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resCode.CustomButton.TabIndex = 1;
            this.resCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resCode.CustomButton.UseSelectable = true;
            this.resCode.CustomButton.Visible = false;
            this.resCode.Lines = new string[0];
            this.resCode.Location = new System.Drawing.Point(3, 143);
            this.resCode.MaxLength = 32767;
            this.resCode.Name = "resCode";
            this.resCode.PasswordChar = '\0';
            this.resCode.ReadOnly = true;
            this.resCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resCode.SelectedText = "";
            this.resCode.SelectionLength = 0;
            this.resCode.SelectionStart = 0;
            this.resCode.ShortcutsEnabled = true;
            this.resCode.Size = new System.Drawing.Size(202, 29);
            this.resCode.TabIndex = 8;
            this.resCode.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resCode.UseCustomBackColor = true;
            this.resCode.UseSelectable = true;
            this.resCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resCode.Click += new System.EventHandler(this.metroTextBox6_Click);
            this.resCode.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // resType
            // 
            // 
            // 
            // 
            this.resType.CustomButton.Image = null;
            this.resType.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.resType.CustomButton.Name = "";
            this.resType.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resType.CustomButton.TabIndex = 1;
            this.resType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resType.CustomButton.UseSelectable = true;
            this.resType.CustomButton.Visible = false;
            this.resType.Lines = new string[0];
            this.resType.Location = new System.Drawing.Point(3, 108);
            this.resType.MaxLength = 32767;
            this.resType.Name = "resType";
            this.resType.PasswordChar = '\0';
            this.resType.ReadOnly = true;
            this.resType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resType.SelectedText = "";
            this.resType.SelectionLength = 0;
            this.resType.SelectionStart = 0;
            this.resType.ShortcutsEnabled = true;
            this.resType.Size = new System.Drawing.Size(161, 29);
            this.resType.TabIndex = 8;
            this.resType.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resType.UseCustomBackColor = true;
            this.resType.UseSelectable = true;
            this.resType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resType.Click += new System.EventHandler(this.metroTextBox5_Click);
            this.resType.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // resTrans
            // 
            // 
            // 
            // 
            this.resTrans.CustomButton.Image = null;
            this.resTrans.CustomButton.Location = new System.Drawing.Point(157, 1);
            this.resTrans.CustomButton.Name = "";
            this.resTrans.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resTrans.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resTrans.CustomButton.TabIndex = 1;
            this.resTrans.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resTrans.CustomButton.UseSelectable = true;
            this.resTrans.CustomButton.Visible = false;
            this.resTrans.Lines = new string[0];
            this.resTrans.Location = new System.Drawing.Point(3, 73);
            this.resTrans.MaxLength = 32767;
            this.resTrans.Name = "resTrans";
            this.resTrans.PasswordChar = '\0';
            this.resTrans.ReadOnly = true;
            this.resTrans.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resTrans.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resTrans.SelectedText = "";
            this.resTrans.SelectionLength = 0;
            this.resTrans.SelectionStart = 0;
            this.resTrans.ShortcutsEnabled = true;
            this.resTrans.Size = new System.Drawing.Size(185, 29);
            this.resTrans.TabIndex = 7;
            this.resTrans.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resTrans.UseCustomBackColor = true;
            this.resTrans.UseSelectable = true;
            this.resTrans.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resTrans.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resTrans.Click += new System.EventHandler(this.metroTextBox4_Click);
            this.resTrans.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // resAuthor
            // 
            // 
            // 
            // 
            this.resAuthor.CustomButton.Image = null;
            this.resAuthor.CustomButton.Location = new System.Drawing.Point(143, 1);
            this.resAuthor.CustomButton.Name = "";
            this.resAuthor.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resAuthor.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resAuthor.CustomButton.TabIndex = 1;
            this.resAuthor.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resAuthor.CustomButton.UseSelectable = true;
            this.resAuthor.CustomButton.Visible = false;
            this.resAuthor.Lines = new string[0];
            this.resAuthor.Location = new System.Drawing.Point(3, 38);
            this.resAuthor.MaxLength = 32767;
            this.resAuthor.Name = "resAuthor";
            this.resAuthor.PasswordChar = '\0';
            this.resAuthor.ReadOnly = true;
            this.resAuthor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resAuthor.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resAuthor.SelectedText = "";
            this.resAuthor.SelectionLength = 0;
            this.resAuthor.SelectionStart = 0;
            this.resAuthor.ShortcutsEnabled = true;
            this.resAuthor.Size = new System.Drawing.Size(171, 29);
            this.resAuthor.TabIndex = 6;
            this.resAuthor.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resAuthor.UseCustomBackColor = true;
            this.resAuthor.UseSelectable = true;
            this.resAuthor.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resAuthor.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resAuthor.Click += new System.EventHandler(this.metroTextBox3_Click);
            this.resAuthor.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // resName
            // 
            // 
            // 
            // 
            this.resName.CustomButton.Image = null;
            this.resName.CustomButton.Location = new System.Drawing.Point(145, 1);
            this.resName.CustomButton.Name = "";
            this.resName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.resName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.resName.CustomButton.TabIndex = 1;
            this.resName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.resName.CustomButton.UseSelectable = true;
            this.resName.CustomButton.Visible = false;
            this.resName.Lines = new string[0];
            this.resName.Location = new System.Drawing.Point(3, 3);
            this.resName.MaxLength = 32767;
            this.resName.Name = "resName";
            this.resName.PasswordChar = '\0';
            this.resName.ReadOnly = true;
            this.resName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.resName.SelectedText = "";
            this.resName.SelectionLength = 0;
            this.resName.SelectionStart = 0;
            this.resName.ShortcutsEnabled = true;
            this.resName.Size = new System.Drawing.Size(173, 29);
            this.resName.TabIndex = 5;
            this.resName.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.resName.UseCustomBackColor = true;
            this.resName.UseSelectable = true;
            this.resName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.resName.Click += new System.EventHandler(this.metroTextBox2_Click);
            this.resName.DoubleClick += new System.EventHandler(this.dblC1);
            // 
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroPanel4.Controls.Add(this.resList);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(259, 71);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(241, 326);
            this.metroPanel4.TabIndex = 4;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // resList
            // 
            this.resList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.resList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.resList.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.resList.FormattingEnabled = true;
            this.resList.HorizontalScrollbar = true;
            this.resList.Location = new System.Drawing.Point(3, 4);
            this.resList.Name = "resList";
            this.resList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.resList.Size = new System.Drawing.Size(235, 314);
            this.resList.TabIndex = 15;
            this.resList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // metroPanel5
            // 
            this.metroPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroPanel5.Controls.Add(this.metroLabel10);
            this.metroPanel5.Controls.Add(this.metroLabel9);
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(12, 289);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Size = new System.Drawing.Size(241, 108);
            this.metroPanel5.TabIndex = 14;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.UseCustomBackColor = true;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(20, 43);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(215, 57);
            this.metroLabel10.TabIndex = 15;
            this.metroLabel10.Text = ".شماره مستقل کتاب کپی شده است\r\n برای کپی کردن هر داده بر روی آن دو بار\r\n.کلیک کنی" +
    "د";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel10.UseCustomBackColor = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(191, 8);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(44, 19);
            this.metroLabel9.TabIndex = 14;
            this.metroLabel9.Text = ": توجه";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel9.UseCustomBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(512, 404);
            this.Controls.Add(this.metroPanel5);
            this.Controls.Add(this.metroPanel4);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.metroPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form2";
            this.Text = "جستجو";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC2);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton minimizeBtn;
        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroButton searchBtn;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox searchBox;
        private MetroFramework.Controls.MetroComboBox searchCombo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox resNum;
        private MetroFramework.Controls.MetroTextBox resCode;
        private MetroFramework.Controls.MetroTextBox resType;
        private MetroFramework.Controls.MetroTextBox resTrans;
        private MetroFramework.Controls.MetroTextBox resAuthor;
        private MetroFramework.Controls.MetroTextBox resName;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTextBox searchBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ListBox resList;
    }
}