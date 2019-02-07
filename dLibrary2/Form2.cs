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
    public partial class Form2 : Form
    {
        //title drag codes
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();
        //end- title drag codes


        List<int> codeNum = new List<int>();
        sqlite.SQLiteConnection s_con = Form1.s_con;
        public Form2()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //title drag codes
        private void metroPanel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //end- title drag codes

        private void Form2_Load(object sender, EventArgs e)
        {
            searchCombo.SelectedIndex = 0;
        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (searchCombo.SelectedIndex == 0)
            {
                resList.Items.Clear();
                codeNum.Clear();
                string search = searchBox.Text;
                string sql = "SELECT id FROM kotob ORDER BY ID DESC LIMIT 1";
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
                reader.Read();
                int rC = Convert.ToInt32(reader["id"]);
                for (int i = 1; i <= rC; i++)
                {
                    start:
                    sql = "select name from kotob where id = " + i.ToString();
                    s_com = new sqlite.SQLiteCommand(sql, s_con);
                    reader = s_com.ExecuteReader();
                    reader.Read();
                    string name = "";
                    try
                    {
                        name = reader["name"].ToString();
                    }
                    catch
                    {
                        i++;
                        if (i <= rC)
                        {
                            goto start;
                        }
                    }
                    if (name.Contains(search))
                    {
                        resList.Items.Add(name);
                        codeNum.Add(i);
                    }
                }
            }
            else if (searchCombo.SelectedIndex == 1)
            {
                resList.Items.Clear();
                codeNum.Clear();
                string search = searchBox.Text;
                string sql = "SELECT id FROM kotob ORDER BY ID DESC LIMIT 1";
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
                reader.Read();
                int rC = Convert.ToInt32(reader["id"]);
                for (int i = 1; i <= rC; i++)
                {
                    start3:
                    sql = "select author from kotob where id = " + i.ToString();
                    s_com = new sqlite.SQLiteCommand(sql, s_con);
                    reader = s_com.ExecuteReader();
                    reader.Read();
                    string name = "";
                    try
                    {
                        name = reader["author"].ToString();
                    }
                    catch
                    {
                        i++;
                        if (i <= rC)
                        {
                            goto start3;
                        }
                    }
                    if (name.Contains(search))
                    {
                        resList.Items.Add(name);
                        codeNum.Add(i);
                    }
                }
            }
            else if (searchCombo.SelectedIndex == 2)
            {
                resList.Items.Clear();
                codeNum.Clear();
                string search = searchBox.Text;
                string sql = "SELECT id FROM kotob ORDER BY ID DESC LIMIT 1";
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
                reader.Read();
                int rC = Convert.ToInt32(reader["id"]);
                for (int i = 1; i <= rC; i++)
                {
                    start4:
                    sql = "select translator from kotob where id = " + i.ToString();
                    s_com = new sqlite.SQLiteCommand(sql, s_con);
                    reader = s_com.ExecuteReader();
                    reader.Read();
                    string name = "";
                    try
                    {
                        name = reader["translator"].ToString();
                    }
                    catch
                    {
                        i++;
                        if (i <= rC)
                        {
                            goto start4;
                        }
                    }
                    if (name.Contains(search))
                    {
                        resList.Items.Add(name);
                        codeNum.Add(i);
                    }
                }
            }
            else if (searchCombo.SelectedIndex == 3)
            {
                resList.Items.Clear();
                codeNum.Clear();
                string search = searchBox.Text;
                string search2 = searchBox2.Text;
                string sql = "SELECT id FROM kotob ORDER BY ID DESC LIMIT 1";
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
                reader.Read();
                int rC = Convert.ToInt32(reader["id"]);
                for (int i = 1; i <= rC; i++)
                {
                    start2:
                    sql = "select code from kotob where id = " + i.ToString();
                    s_com = new sqlite.SQLiteCommand(sql, s_con);
                    reader = s_com.ExecuteReader();
                    reader.Read();
                    string name = "";
                    try
                    {
                        name = reader["code"].ToString();
                    }
                    catch
                    {
                        i++;
                        if (i <= rC)
                        {
                            goto start2;
                        }
                    }
                    if (name.Contains(search) && name.Contains(search2))
                    {
                        resList.Items.Add(name);
                        codeNum.Add(i);
                    }
                }
            }
            else if (searchCombo.SelectedIndex == 4)
            {
                resList.Items.Clear();
                codeNum.Clear();
                string search = searchBox.Text;
                string sql = "SELECT id FROM kotob ORDER BY ID DESC LIMIT 1";
                sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
                sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
                reader.Read();
                int rC = Convert.ToInt32(reader["id"]);
                for (int i = 1; i <= rC; i++)
                {
                    start5:
                    sql = "select id from kotob where id = " + i.ToString();
                    s_com = new sqlite.SQLiteCommand(sql, s_con);
                    reader = s_com.ExecuteReader();
                    reader.Read();
                    string name = "";
                    try
                    {
                        name = reader["id"].ToString();
                    }
                    catch
                    {
                        i++;
                        if (i <= rC)
                        {
                            goto start5;
                        }
                    }
                    if (name == search)
                    {
                        resList.Items.Add(name);
                        codeNum.Add(i);
                    }
                }
            }
            System.Media.SystemSounds.Hand.Play();
        }

        private void searchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (searchCombo.SelectedIndex == 3)
            {
                searchBox2.Visible = true;
                searchBox.Width = 75;
                searchBox2.Refresh();
                searchBox.Refresh();
            }
            else
            {
                searchBox2.Visible = false;
                searchBox.Width = 156;
                searchBox2.Refresh();
                searchBox.Refresh();
            }
        }

        private void resList_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void resList_DoubleClick(object sender, EventArgs e)
        {
            int choosed = codeNum[resList.SelectedIndex];

            string sql = "select * from kotob where id = " + choosed.ToString();
            sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
            sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
            reader.Read();

            resName.Text = reader["name"].ToString();
            resType.Text = reader["type"].ToString();
            resTrans.Text = reader["translator"].ToString();
            resAuthor.Text = reader["author"].ToString();
            resCode.Text = reader["code"].ToString();
            resNum.Text = choosed.ToString();

            Clipboard.SetText(resNum.Text);
        }

        private void keyC1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pressSim(searchBtn);
            }
        }

        private void keyC2(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.L)
            {
                resList.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                searchBox.Focus();
            }
            else if (e.Control && e.KeyCode == Keys.D1)
            {
                searchCombo.SelectedIndex = 0;
            }
            else if (e.Control && e.KeyCode == Keys.D2)
            {
                searchCombo.SelectedIndex = 1;
            }
            else if (e.Control && e.KeyCode == Keys.D3)
            {
                searchCombo.SelectedIndex = 2;
            }
            else if (e.Control && e.KeyCode == Keys.D4)
            {
                searchCombo.SelectedIndex = 3;
            }
            else if (e.Control && e.KeyCode == Keys.D5)
            {
                searchCombo.SelectedIndex = 4;
            }
        }

        private void pressSim(MetroFramework.Controls.MetroButton sender)
        {
            sender.UseStyleColors = true;
            sender.Refresh();
            timer1.Enabled = true;
            sender.PerformClick();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            searchBtn.UseStyleColors = false;
            searchBtn.Refresh();
            timer1.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int choosed = codeNum[resList.SelectedIndex];

            string sql = "select * from kotob where id = " + choosed.ToString();
            sqlite.SQLiteCommand s_com = new sqlite.SQLiteCommand(sql, s_con);
            sqlite.SQLiteDataReader reader = s_com.ExecuteReader();
            reader.Read();

            resName.Text = reader["name"].ToString();
            resType.Text = reader["type"].ToString();
            resTrans.Text = reader["translator"].ToString();
            resAuthor.Text = reader["author"].ToString();
            resCode.Text = reader["code"].ToString();
            resNum.Text = choosed.ToString();

            if(resNum.Text != "")
            {
                Clipboard.SetText(resNum.Text);
            }
        }

        private void dblC1(object sender, EventArgs e)
        {
            MetroFramework.Controls.MetroTextBox TB = (MetroFramework.Controls.MetroTextBox)sender;
            string text = TB.Text;
            if(text != "")
            {
                Clipboard.SetText(text);
            }
            System.Media.SystemSounds.Hand.Play();
        }
    }
}
