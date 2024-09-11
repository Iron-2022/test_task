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
    public partial class Form2 : Form
    {
        string person = "";
        string role = "";
        public Form2()
        {
            person = Program.person;
            role = Program.role;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person form = new person();
            form.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            Program.form.Show();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Program.form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            project form = new project();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            task form = new task();
            form.ShowDialog();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string path_directory = "task_";
            List<string> arr = new List<string>();
            if (Directory.Exists(path_directory))
            {
                foreach (string path in Directory.GetFiles(path_directory))
                {
                    using (StreamReader sw = new StreamReader(path))
                    {
                        string str;
                        str = sw.ReadLine();
                        string str_clon = str.Split('_')[0];
                        if(str_clon == person)
                        {
                            int startIndex = path.IndexOf('\\');
                            int endIndex = path.LastIndexOf('.');
                            str_clon = path.Substring(startIndex + 1, endIndex - startIndex - 1);

                            arr.Add(str_clon);
                        }
                    }
                }
                int i = 0;
                foreach(string line in arr)
                {
                    UC_task uC_Task = new UC_task();
                    uC_Task.setLabel(line);
                    given_p.Controls.Add(uC_Task);
                    uC_Task.Location = new System.Drawing.Point(0, i * uC_Task.Height + (i * 5));
                    i++;
                }
                path_directory = "role";
                foreach(string path in Directory.GetFiles(path_directory))
                {
                    if (Program.path_to_str(path) == role)
                    {
                        using (StreamReader sw = new StreamReader(path))
                        {
                            string str;
                            str = sw.ReadLine();
                            create_person_bt.Visible = Convert.ToBoolean(str.Split('_')[0]);
                            create_project_bt.Visible = Convert.ToBoolean(str.Split('_')[1]);
                            create_task_bt.Visible = Convert.ToBoolean(str.Split('_')[2]);
                            assign_task_bt.Visible = Convert.ToBoolean(str.Split('_')[3]);
                            budget1.Visible = Convert.ToBoolean(str.Split('_')[4]);
                            budget2.Visible = Convert.ToBoolean(str.Split('_')[4]);
                        }
                    }
                }
            }
        }

        private void Given_p_ControlAdded(object sender, ControlEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            task_addPerson form = new task_addPerson();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            role form = new role();
            form.ShowDialog();
        }
    }
}
