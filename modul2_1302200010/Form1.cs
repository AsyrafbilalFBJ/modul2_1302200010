using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul2_1302200010
{
    public partial class Form1 : Form
    {
        int firstnum, secnum, thirdnum, hasil;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+1";
                secnum = 1;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "1";
                label1.TabIndex = 1;
                firstnum = 1;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+2";
                secnum = 2;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "2";
                label1.TabIndex = 2;
                firstnum = 2;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+3";
                secnum = 3;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "3";
                label1.TabIndex = 3;
                firstnum = 3;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+4";
                secnum = 4;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "4";
                label1.TabIndex = 4;
                firstnum = 4;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+5";
                secnum = 5;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "5";
                label1.TabIndex = 5;
                firstnum = 5;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+6";
                secnum = 6;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "6";
                label1.TabIndex = 6;
                firstnum = 6;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+7";
                secnum = 7;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "7";
                label1.TabIndex = 7;
                firstnum = 7;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+8";
                secnum = 8;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "8";
                label1.TabIndex = 8;
                firstnum = 8;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+9";
                secnum = 9;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "9";
                label1.TabIndex = 9;
                firstnum = 9;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+0";
                secnum = 0;
                label1.TabIndex = firstnum + secnum;
            }
            else
            {
                label1.Text = "0";
                label1.TabIndex = 0;
                firstnum = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1 = null;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label1.TabIndex != 0)
            {
                label1.Text = firstnum + "+";
            }
            //else if (hasil != 0)
           // {
           //     label1.Text = firstnum + "+" + secnum + "=" + hasil + "+" + thirdnum;
           // }
           // else if (hasil != 0 && secnum != 0)
           // {
           //     label1.Text = firstnum + "+" + secnum + "+" + thirdnum;
          //  }
            else
            {
                label1.Text = firstnum + "+";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            hasil = firstnum + secnum;
            label1.Text = firstnum + "+" + secnum + "=" + hasil;
            label1.TabIndex = 0;
        }
    }
}
