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
    public partial class FormButton : Form
    {
        public FormButton()
        {
            InitializeComponent();
        }

        private void btnBotton_Click(object sender, EventArgs e)
        {
            if (btnBotton.Text == "請按我一下")
                btnBotton.Text = "我已經被按過了";
            else if (btnBotton.Text == "我已經被按過了")
                btnBotton.Text = "請按我一下";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "下方按鈕已被按過";

        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            string tmp = labCount.Text;
            int sum = Int32.Parse(tmp) + 1;
            labCount.Text = sum.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string tmp = labCount.Text;
            int sum = Int32.Parse(tmp) - 1;
            labCount.Text = sum.ToString();
        }
    }
}
