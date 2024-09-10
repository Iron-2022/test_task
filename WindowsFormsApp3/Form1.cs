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
        string person = "";
        
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
                    person = str.Split('_')[0];
                }
            }
        }

        private void avtoriz_Click(object sender, EventArgs e)
        {
            if(login.Text+"_"+password.Text == str)
            {
                Form2 form = new Form2(person);
                this.Hide();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Доступ закрыт");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
