using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        string str = "";
        public Form1()
        {
            InitializeComponent();
            string path = "person.txt";
            FileInfo fileInfo = new FileInfo(path);
            if (!fileInfo.Exists)
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("text_text_text");
                }
            }
            else
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    str = sw.ReadLine();
                    str = str.Split('_')[1] + "_" + str.Split('_')[2];
                    Program.role = sw.ReadLine();
                }
            }
        }

        private void avtoriz_Click(object sender, EventArgs e)
        {
            string path_directory = "person";
            if (Directory.Exists(path_directory))
            {
                bool flag = false;
                foreach(string path in Directory.GetFiles(path_directory))
                {
                    using (StreamReader sw = new StreamReader(path))
                    {
                        str = sw.ReadLine();
                        str = str.Split('_')[1] + "_" + str.Split('_')[2];
                        Program.role = sw.ReadLine();
                    }
                    if (login.Text + "_" + password.Text == str)
                    {
                        Program.person = Program.path_to_str(path);
                        Form2 form = new Form2();
                        login.Text = "";
                        password.Text = "";
                        Program.form = this;
                        form.Show();
                        this.Hide();
                        flag = true;
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Доступ закрыт");
                }
            }
            else
            {
                if (login.Text + "_" + password.Text == str)
                {
                    Form2 form = new Form2();
                    login.Text = "";
                    password.Text = "";
                    Program.form = this;
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Доступ закрыт");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            login.Select();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                password.Select();
            }
        }

        private void password_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                avtoriz_Click(sender, e);
            }
        }
    }
}
