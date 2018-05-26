using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class FormCalc : Form
    {
        public FormCalc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "3";
        }

        private void butClear_Click(object sender, EventArgs e)
        {
            labNumber.Text = "0";
        }

        private void butPlus_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            labNumber.Text = (a + 1).ToString();
        }

        private void butDecrease_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            labNumber.Text = (a - 1).ToString();
        }
    }
}
