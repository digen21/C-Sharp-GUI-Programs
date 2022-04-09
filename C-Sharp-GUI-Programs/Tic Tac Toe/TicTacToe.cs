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
    public partial class tic : Form
    {
        String a ="O";
        int m = 0;
        public tic()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void b_Click(object sender, EventArgs e)
        {
            Button bt = sender as Button;
           // bt.Enabled = false;
            bt.BackColor = Color.Orange;

            //create if condtion
            if (a == "O")
            {
                bt.BackColor = Color.Orange;
                bt.Text = "O";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b3.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b6.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b9.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b7.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b9.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b9.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b7.Text != ""))
                {
                    MessageBox.Show("O is a Winner" + a.ToString());
                }
                else if (m == 8)
                {
                    MessageBox.Show("Draw");
                }
                a = "X";
            }
            else if (a == "X")
            {
                bt.BackColor = Color.Green;
                bt.Text = "X";
                if ((b1.Text == b2.Text && b2.Text == b3.Text && b3.Text != "") ||
                    (b4.Text == b5.Text && b5.Text == b6.Text && b6.Text != "") ||
                    (b7.Text == b8.Text && b8.Text == b9.Text && b9.Text != "") ||
                    (b1.Text == b4.Text && b4.Text == b7.Text && b7.Text != "") ||
                    (b2.Text == b5.Text && b5.Text == b8.Text && b8.Text != "") ||
                    (b3.Text == b6.Text && b6.Text == b9.Text && b9.Text != "") ||
                    (b1.Text == b5.Text && b5.Text == b9.Text && b9.Text != "") ||
                    (b3.Text == b5.Text && b5.Text == b7.Text && b7.Text != ""))
                {
                    MessageBox.Show("X is winner" + a.ToString());
                }
                else if (m == 8)
                {
                    MessageBox.Show("Draw!!!");
                }
                  a = "O";
            }
            m++;


        }

        private void b2_Click(object sender, EventArgs e)
        {

        }

        private void b3_Click(object sender, EventArgs e)
        {

        }

        private void b4_Click(object sender, EventArgs e)
        {

        }

        private void b5_Click(object sender, EventArgs e)
        {

        }

        private void b6_Click(object sender, EventArgs e)
        {

        }

        private void b7_Click(object sender, EventArgs e)
        {

        }

        private void b8_Click(object sender, EventArgs e)
        {

        }

        private void b9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = "O";
            m = 0;
             b1.Text = ""; b1.BackColor = Color.White;
             b2.Text = ""; b2.BackColor = Color.White;
             b3.Text = ""; b3.BackColor = Color.White;
             b4.Text = ""; b4.BackColor = Color.White;
             b5.Text = ""; b5.BackColor = Color.White;
             b6.Text = ""; b6.BackColor = Color.White;
             b7.Text = ""; b7.BackColor = Color.White;
             b8.Text = ""; b8.BackColor = Color.White;
             b9.Text = ""; b9.BackColor = Color.White;
            //tableLayoutPanel1.Enabled = true;
        }
    }
}
