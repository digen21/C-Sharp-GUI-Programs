using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace notepad
{
    public partial class cal : Form
    {
        double no1;
        string op;
        public cal()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button grp = sender as Button;
            textBox1.Text += grp.Text;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "*";

        }

        private void button13_Click(object sender, EventArgs e)
        {
             no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
             no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "%";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "-";
        }

        private void button18_Click(object sender, EventArgs e)
        {
             no1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "";
            op = "+";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double no2;
            double result = 0;
            no2 = Convert.ToDouble(textBox1.Text);
            switch(op)
            {
                case "+":
                   result= no1 + no2; break;
                case "-":
                   result = no1 - no2; break;
                case "*":
                    result = no1 * no2; break;
                case "%":
                    result = no1 % no2; break;
                case "/":
                    result = no1 /  no2; break;
            }
            textBox1.Text = result.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
