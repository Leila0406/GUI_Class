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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string tmp = textBox1.Text;
            int num = C = (F)* 9 / 5 + 32;
            textBox1.Text = num.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    }
}
