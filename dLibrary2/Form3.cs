using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sqlite = System.Data.SQLite;

namespace dLibrary2
{
    public partial class Form3 : Form
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

        public Form3()
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
            string sql = "insert into kotob (name, author, translator, type, code) \n values('" + bookTB.Text + "', '" + authTB.Text + "', '" + transTB.Text + "', '" + typeTB.Text + "', '" + codeTB.Text + "')";
            sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
            s_com.ExecuteNonQuery();
            if (bar.Value == 100)
            {
                bar.Value = 0;
            }
            else
            {
                bar.Value = 100;
            }
            System.Media.SystemSounds.Hand.Play();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string[] types = System.IO.File.ReadAllLines(@"settings.dls");
            types = types.Skip(2).Take(types.Length - 2).ToArray();
            typeTB.Items.Clear();
            foreach (string type in types)
            {
                typeTB.Items.Add(type);
            }
        }

        private void keyC1(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                metroButton1.PerformClick();
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.N)
            {
                bookTB.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.E)
            {
                bookTB.Clear();
                authTB.Clear();
                codeTB.Clear();
                transTB.Clear();
                typeTB.SelectedIndex = -1;
            }
        }
    }
}
