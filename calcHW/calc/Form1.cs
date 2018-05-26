using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
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
            int b = Convert.ToInt32(textNumber.Text);
            labSign.Text = "+";
            labAnswer.Text = (a + b).ToString();
        }

        private void butDecrease_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            int b = Convert.ToInt32(textNumber.Text);
            labSign.Text = "-";
            labAnswer.Text = (a - b).ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "6";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            int b = Convert.ToInt32(textNumber.Text);
            labSign.Text = "*";
            labAnswer.Text = (a * b).ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            int b = Convert.ToInt32(textNumber.Text);
            labSign.Text = "/";
            labAnswer.Text = (a / b).ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(labNumber.Text);
            int b = Convert.ToInt32(textNumber.Text);
            labSign.Text = "%";
            labAnswer.Text = (a % b).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "5";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            labNumber.Text = labNumber.Text + "9";
        }
    }
}
