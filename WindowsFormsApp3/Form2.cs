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
        static string person = "";
        public Form2(string person_str)
        {
            person = person_str;
            InitializeComponent();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person form = new person();
            this.Hide();
            form.ShowDialog();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string str;
            string path_directory = "task_";
            List<string> arr = new List<string>();
            if (Directory.Exists(path_directory))
            {
                foreach (string path in new object[] { Directory.GetFiles(path_directory) })
                {
                    if (path.IndexOf(person) != -1)
                    {
                        arr.Add(path);
                    }
                }
                task_.Lines = arr.ToArray();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
