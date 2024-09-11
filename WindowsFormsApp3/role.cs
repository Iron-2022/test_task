using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class role : Form
    {
        public role()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "role";
            if (Directory.Exists(path_directory))
            {
                string path = path_directory + "/" + name_tb.Text.ToString() + ".txt";
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    MessageBox.Show("Роль уже есть");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(checkBox1.Checked.ToString() + "_" +
                            checkBox2.Checked.ToString() + "_" + checkBox3.Checked.ToString() + "_" + 
                            checkBox4.Checked.ToString() + "_" + checkBox5.Checked.ToString());
                    }
                }
            }
        }

        private void role_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void role_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void role_Load(object sender, EventArgs e)
        {
            Program.direct("role");
        }
    }
}
