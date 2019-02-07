using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using sqlite = System.Data.SQLite;

namespace dLibrary2
{
    public partial class Form4 : Form
    {
        //title drag codes
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //end- title drag codes


        sqlite.SQLiteConnection s_con = Form1.s_con;

        public Form4()
        {
            InitializeComponent();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //title drag codes
        private void metroPanel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //end- title drag codes
        private void metroButton1_Click(object sender, EventArgs e)
        {
            System.Media.SystemSounds.Hand.Play();
            DialogResult uChoice = MetroMessageBox.Show(this, "آیا مطمئنید که می خواهید کتاب را حذف کنید؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button3, this.Height);

            if(uChoice == DialogResult.Yes)
            {
                string sql = "delete from kotob where id = " + delNum.Text;
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                s_com.ExecuteNonQuery();
                System.Media.SystemSounds.Hand.Play();
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            delNum.Focus();
        }

        private void keyC1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                metroButton1.PerformClick();
            }
        }

        private void Form4_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.D)
            {
                delNum.Focus();
            }
        }
    }
}
