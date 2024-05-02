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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnBotton_Click(object sender, EventArgs e)
        {
            Form form=new FormButton();
            form.Show();
        }

        private void btnTextBox_Click(object sender, EventArgs e)
        {
            Form FormTextBox = new FormTextBox();
            FormTextBox.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
