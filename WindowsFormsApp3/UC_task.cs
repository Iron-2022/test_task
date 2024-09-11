using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UC_task : UserControl
    {
        public UC_task()
        {
            InitializeComponent();
        }

        private void UC_task_Load(object sender, EventArgs e)
        {

        }
        public void setLabel(string label)
        {
            label1.Text = label;
        }
        public string getLabel()
        {
            return label1.Text;
        }
    }
}
