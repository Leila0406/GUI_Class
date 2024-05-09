using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N11310019_GUI_Class
{
    public partial class Formtimer : Form
    {
        int second;
        public Formtimer()
        {
            InitializeComponent();
            this.second = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = String.Format("{0}秒", this.second);
            this.second++;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "0秒";
            second = 0;
        }
    }
}
