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

namespace WindowsFormsApp3
{
    public partial class task_addPerson : Form
    {

        public task_addPerson()
        {
            InitializeComponent();
        }

        private void task_addPerson_Load(object sender, EventArgs e)
        {
            string path_directory = "person";
            person_cb.Items.AddRange(new object[] { Directory.GetFiles(path_directory) });
        }

        private void project_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string person = person_cb.Text.ToString();
            string str;
            string path_directory = "project";
            List<string> arr = new List<string>();
            foreach(string path in new object[] { Directory.GetFiles(path_directory) })
            {
                using (StreamReader sw = new StreamReader(path))
                {
                    str = sw.ReadLine().Split('_')[3];
                    if (str == person)
                    {
                        arr.Add(str);
                    }
                }
            }
            project_cb.Items.AddRange(arr.ToArray());
        }

        private void task_cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string project = project_cb.Text.ToString();
            string str;
            string path_directory = "task";
            List<string> arr = new List<string>();
            foreach (string path in new object[] { Directory.GetFiles(path_directory) })
            {
                if (path.IndexOf(project) != -1)
                {
                    arr.Add(path);
                }
            }
            task_cb.Items.AddRange(arr.ToArray());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path_directory = "task_";
            if (Directory.Exists(path_directory))
            {
                int i = Directory.GetFiles(path_directory).Count();
                string path = project_cb.Text + i.ToString();
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
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }

        private void task_addPerson_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form2 form = new Form2();
            this.Hide();
            form.ShowDialog();
        }
    }
}
