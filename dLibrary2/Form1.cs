using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Forms;
using MetroFramework;
using System.Runtime.InteropServices;
using sqlite = System.Data.SQLite;

namespace dLibrary2
{
    public partial class Form1 : Form
    {
        //title drag codes
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //end- title drag codes


        public static sqlite.SQLiteConnection s_con;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s_con = new sqlite.SQLiteConnection("Data Source=\ffinal.sqlite;Version=3;");
            s_con.Open();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void initTimer_Tick(object sender, EventArgs e)
        {
            initTimer.Enabled = false;
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

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Form2 fsearch = new Form2();
            fsearch.Show();
        }

        private void metroTile2_Click(object sender, EventArgs e)
        {
            Form3 fnew = new Form3();
            fnew.Show();
        }

        private void metroTile3_Click(object sender, EventArgs e)
        {
            Form4 fdelete = new Form4();
            fdelete.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            Form5 fchange = new Form5();
            fchange.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && (e.KeyCode == Keys.D1 || e.KeyCode == Keys.S))
            {
                metroTile1.PerformClick();
            }
            else if (e.Control && (e.KeyCode == Keys.D2 || e.KeyCode == Keys.N))
            {
                metroTile2.PerformClick();
            }
            else if (e.Control && (e.KeyCode == Keys.D3 || e.KeyCode == Keys.D))
            {
                metroTile3.PerformClick();
            }
            else if (e.Control && (e.KeyCode == Keys.D4 || e.KeyCode == Keys.R))
            {
                metroTile4.PerformClick();
            }
        }

        private void metroLink1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://lozaa.ir");
        }

        private void metroTile5_Click(object sender, EventArgs e)
        {

        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            Form7 flaw = new Form7();
            flaw.Show();
        }
    }
}
