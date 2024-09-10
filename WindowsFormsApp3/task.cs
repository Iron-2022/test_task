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
    public partial class task : Form
    {
        public task()
        {
            InitializeComponent();
        }

        private void task_Load(object sender, EventArgs e)
        {
            string path_directory = "project";
            project_cb.Items.AddRange(new object[] { Directory.GetFiles(path_directory) });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "task";
            if (Directory.Exists(path_directory))
            {
                int i = Directory.GetFiles(path_directory).Count();
                string path = project_cb.Text + i.ToString();
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
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void task_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }
    }
}
