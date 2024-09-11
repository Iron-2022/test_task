using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class task : Form
    {
        bool flag_create = true;
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            string path_directory = "project";
            if (Directory.Exists(path_directory))
            {
                foreach (string str in Directory.GetFiles(path_directory))
                {
                    int startIndex = str.IndexOf('\\');
                    int endIndex = str.LastIndexOf('.');
                    string str_clon = str.Substring(startIndex + 1, endIndex - startIndex - 1);
                    project_cb.Items.Add(str_clon);
                }
            }
            else
            {
                MessageBox.Show("Нет проектов в которых можно создать задачу");
                flag_create = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "task";
            if (Directory.Exists(path_directory))
            {
                int i = Directory.GetFiles(path_directory).Count();
                string path = path_directory + "/" + project_cb.Text + i.ToString() + ".txt";
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    MessageBox.Show("Задача уже есть");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(description_tb.Text + "_" + hour_data.Text.ToString());
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(path_directory);
            }
        }

        private void task_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void task_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void task_Shown(object sender, EventArgs e)
        {
            if (!flag_create) { this.Hide(); }
        }
    }
}
