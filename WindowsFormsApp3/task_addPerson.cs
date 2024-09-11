using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Shapes;

namespace WindowsFormsApp3
{
    public partial class task_addPerson : Form
    {
        bool flag_create = true;
        public task_addPerson()
        {
            InitializeComponent();
        }

        private void task_addPerson_Load(object sender, EventArgs e)
        {
            string path_directory = "task_";
            if (!Directory.Exists(path_directory))
            {
                Directory.CreateDirectory(path_directory);
            }
            path_directory = "person";
            if (Directory.Exists(path_directory))
            {
                foreach (string str in Directory.GetFiles(path_directory))
                {
                    int startIndex = str.IndexOf('\\');
                    int endIndex = str.LastIndexOf('.');
                    string str_clon = str.Substring(startIndex + 1, endIndex - startIndex - 1);
                    person_cb.Items.Add(str_clon);
                }
            }
            else
            {
                flag_create = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "task_";
            if (Directory.Exists(path_directory))
            {
                int i = Directory.GetFiles(path_directory).Count();
                string path = path_directory + "/" + project_cb.Text + i.ToString() + ".txt";
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    MessageBox.Show("Задача уже назначена");
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine(person_cb.Text + "_" + project_cb.Text + "_" + task_cb.Text);
                    }
                }
            }
            else
            {
                Directory.CreateDirectory(path_directory);
            }
        }

        private void task_addPerson_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }

        private void task_addPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void project_cb_Click(object sender, EventArgs e)
        {
            string person = person_cb.Text.ToString();
            string str;
            string path_directory = "project";
            foreach (string path in Directory.GetFiles(path_directory))
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    str = sw.ReadLine().Split('_')[3];
                    if (str == person)
                    {
                        int startIndex = path.IndexOf('\\');
                        int endIndex = path.LastIndexOf('.');
                        string str_clon = path.Substring(startIndex + 1, endIndex - startIndex - 1);
                        project_cb.Items.Add(str_clon);
                    }
                }
            }
        }

        private void task_cb_Click(object sender, EventArgs e)
        {
            string project = project_cb.Text.ToString();
            string path_directory = "task";
            foreach (string path in Directory.GetFiles(path_directory))
            {
                if (path.Contains(project))
                {
                    int startIndex = path.IndexOf('\\');
                    int endIndex = path.LastIndexOf('.');
                    string str_clon = path.Substring(startIndex + 1, endIndex - startIndex - 1);
                    task_cb.Items.Add(str_clon);
                }
                
            }
        }

        private void task_addPerson_Shown(object sender, EventArgs e)
        {
            if (!flag_create) { this.Hide(); }
        }
    }
}
