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
    public partial class project : Form
    {
        public project()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "project";
            if (Directory.Exists(path_directory))
            {
                int i = Directory.GetFiles(path_directory).Count();
                string path = path_directory + "/" + name_tb.Text.ToString() + i.ToString() + ".txt";
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    MessageBox.Show("Проект уже есть");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(name_tb.Text + "_" + budget_tb.Text + "_" + term_data.Text.ToString() + "_" + person_cb.Text);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(path_directory);
            }
        }

        private void project_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void project_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void person_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void project_Load(object sender, EventArgs e)
        {
            Program.direct("project");
            string path_directory = "person";
            foreach (string str in Directory.GetFiles(path_directory))
            {
                int startIndex = str.IndexOf('\\');
                int endIndex = str.LastIndexOf('.');
                string str_clon = str.Substring(startIndex + 1, endIndex - startIndex - 1);
                person_cb.Items.Add(str_clon);
            }
        }
    }
}
