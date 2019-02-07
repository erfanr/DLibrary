namespace dLibrary2
{
    partial class Form3
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.minimizeBtn = new MetroFramework.Controls.MetroButton();
            this.closeBtn = new MetroFramework.Controls.MetroButton();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.bar = new MetroFramework.Controls.MetroProgressBar();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.typeTB = new MetroFramework.Controls.MetroComboBox();
            this.codeTB = new MetroFramework.Controls.MetroTextBox();
            this.transTB = new MetroFramework.Controls.MetroTextBox();
            this.authTB = new MetroFramework.Controls.MetroTextBox();
            this.bookTB = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
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
            this.metroPanel1.Size = new System.Drawing.Size(345, 24);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.UseCustomBackColor = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            this.metroPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.metroPanel1_MouseDown);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Location = new System.Drawing.Point(295, 0);
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
            this.closeBtn.Location = new System.Drawing.Point(320, 0);
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
            // metroPanel4
            // 
            this.metroPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.metroPanel4.Controls.Add(this.bar);
            this.metroPanel4.Controls.Add(this.metroButton1);
            this.metroPanel4.Controls.Add(this.typeTB);
            this.metroPanel4.Controls.Add(this.codeTB);
            this.metroPanel4.Controls.Add(this.transTB);
            this.metroPanel4.Controls.Add(this.authTB);
            this.metroPanel4.Controls.Add(this.bookTB);
            this.metroPanel4.Controls.Add(this.metroLabel7);
            this.metroPanel4.Controls.Add(this.metroLabel6);
            this.metroPanel4.Controls.Add(this.metroLabel5);
            this.metroPanel4.Controls.Add(this.metroLabel4);
            this.metroPanel4.Controls.Add(this.metroLabel3);
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(12, 27);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(321, 242);
            this.metroPanel4.TabIndex = 5;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.UseCustomBackColor = true;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // bar
            // 
            this.bar.Location = new System.Drawing.Point(3, 213);
            this.bar.MarqueeAnimationSpeed = 1;
            this.bar.Name = "bar";
            this.bar.Size = new System.Drawing.Size(312, 23);
            this.bar.Style = MetroFramework.MetroColorStyle.Silver;
            this.bar.TabIndex = 20;
            this.bar.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bar.Value = 100;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(3, 178);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(312, 29);
            this.metroButton1.TabIndex = 19;
            this.metroButton1.Text = "ثبت";
            this.metroButton1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroButton1.UseCustomBackColor = true;
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            this.metroButton1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // typeTB
            // 
            this.typeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.typeTB.DisplayMember = "1";
            this.typeTB.FormattingEnabled = true;
            this.typeTB.ImeMode = System.Windows.Forms.ImeMode.On;
            this.typeTB.ItemHeight = 23;
            this.typeTB.Location = new System.Drawing.Point(3, 108);
            this.typeTB.Name = "typeTB";
            this.typeTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeTB.Size = new System.Drawing.Size(241, 29);
            this.typeTB.TabIndex = 17;
            this.typeTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.typeTB.UseCustomBackColor = true;
            this.typeTB.UseSelectable = true;
            this.typeTB.ValueMember = "1";
            this.typeTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // codeTB
            // 
            // 
            // 
            // 
            this.codeTB.CustomButton.Image = null;
            this.codeTB.CustomButton.Location = new System.Drawing.Point(255, 1);
            this.codeTB.CustomButton.Name = "";
            this.codeTB.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.codeTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.codeTB.CustomButton.TabIndex = 1;
            this.codeTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.codeTB.CustomButton.UseSelectable = true;
            this.codeTB.CustomButton.Visible = false;
            this.codeTB.Lines = new string[0];
            this.codeTB.Location = new System.Drawing.Point(3, 143);
            this.codeTB.MaxLength = 32767;
            this.codeTB.Name = "codeTB";
            this.codeTB.PasswordChar = '\0';
            this.codeTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.codeTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.codeTB.SelectedText = "";
            this.codeTB.SelectionLength = 0;
            this.codeTB.SelectionStart = 0;
            this.codeTB.ShortcutsEnabled = true;
            this.codeTB.Size = new System.Drawing.Size(283, 29);
            this.codeTB.TabIndex = 18;
            this.codeTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.codeTB.UseCustomBackColor = true;
            this.codeTB.UseSelectable = true;
            this.codeTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.codeTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.codeTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // transTB
            // 
            // 
            // 
            // 
            this.transTB.CustomButton.Image = null;
            this.transTB.CustomButton.Location = new System.Drawing.Point(237, 1);
            this.transTB.CustomButton.Name = "";
            this.transTB.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.transTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.transTB.CustomButton.TabIndex = 1;
            this.transTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.transTB.CustomButton.UseSelectable = true;
            this.transTB.CustomButton.Visible = false;
            this.transTB.Lines = new string[0];
            this.transTB.Location = new System.Drawing.Point(3, 73);
            this.transTB.MaxLength = 32767;
            this.transTB.Name = "transTB";
            this.transTB.PasswordChar = '\0';
            this.transTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.transTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.transTB.SelectedText = "";
            this.transTB.SelectionLength = 0;
            this.transTB.SelectionStart = 0;
            this.transTB.ShortcutsEnabled = true;
            this.transTB.Size = new System.Drawing.Size(265, 29);
            this.transTB.TabIndex = 16;
            this.transTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.transTB.UseCustomBackColor = true;
            this.transTB.UseSelectable = true;
            this.transTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.transTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.transTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // authTB
            // 
            // 
            // 
            // 
            this.authTB.CustomButton.Image = null;
            this.authTB.CustomButton.Location = new System.Drawing.Point(223, 1);
            this.authTB.CustomButton.Name = "";
            this.authTB.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.authTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.authTB.CustomButton.TabIndex = 1;
            this.authTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.authTB.CustomButton.UseSelectable = true;
            this.authTB.CustomButton.Visible = false;
            this.authTB.Lines = new string[0];
            this.authTB.Location = new System.Drawing.Point(3, 38);
            this.authTB.MaxLength = 32767;
            this.authTB.Name = "authTB";
            this.authTB.PasswordChar = '\0';
            this.authTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.authTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.authTB.SelectedText = "";
            this.authTB.SelectionLength = 0;
            this.authTB.SelectionStart = 0;
            this.authTB.ShortcutsEnabled = true;
            this.authTB.Size = new System.Drawing.Size(251, 29);
            this.authTB.TabIndex = 15;
            this.authTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.authTB.UseCustomBackColor = true;
            this.authTB.UseSelectable = true;
            this.authTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.authTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.authTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // bookTB
            // 
            // 
            // 
            // 
            this.bookTB.CustomButton.Image = null;
            this.bookTB.CustomButton.Location = new System.Drawing.Point(225, 1);
            this.bookTB.CustomButton.Name = "";
            this.bookTB.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.bookTB.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.bookTB.CustomButton.TabIndex = 1;
            this.bookTB.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bookTB.CustomButton.UseSelectable = true;
            this.bookTB.CustomButton.Visible = false;
            this.bookTB.Lines = new string[0];
            this.bookTB.Location = new System.Drawing.Point(3, 3);
            this.bookTB.MaxLength = 32767;
            this.bookTB.Name = "bookTB";
            this.bookTB.PasswordChar = '\0';
            this.bookTB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bookTB.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.bookTB.SelectedText = "";
            this.bookTB.SelectionLength = 0;
            this.bookTB.SelectionStart = 0;
            this.bookTB.ShortcutsEnabled = true;
            this.bookTB.Size = new System.Drawing.Size(253, 29);
            this.bookTB.TabIndex = 14;
            this.bookTB.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.bookTB.UseCustomBackColor = true;
            this.bookTB.UseSelectable = true;
            this.bookTB.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.bookTB.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.bookTB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyC1);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(289, 148);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(29, 19);
            this.metroLabel7.TabIndex = 13;
            this.metroLabel7.Text = ": کد";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel7.UseCustomBackColor = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(247, 113);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(71, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = ": دسته بندی";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel6.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(271, 78);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(47, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = ": مترجم";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(257, 43);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(61, 19);
            this.metroLabel4.TabIndex = 10;
            this.metroLabel4.Text = ": نویسنده";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(259, 8);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(0, 8, 3, 8);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(59, 19);
            this.metroLabel3.TabIndex = 8;
            this.metroLabel3.Text = ": نام کتاب";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(345, 277);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form3";
            this.Text = "ثبت";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form3_KeyDown);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton minimizeBtn;
        private MetroFramework.Controls.MetroButton closeBtn;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox bookTB;
        private MetroFramework.Controls.MetroTextBox authTB;
        private MetroFramework.Controls.MetroTextBox transTB;
        private MetroFramework.Controls.MetroTextBox codeTB;
        private MetroFramework.Controls.MetroComboBox typeTB;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroProgressBar bar;
    }
}