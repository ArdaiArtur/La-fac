using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace laborator2._2
{
   
    public partial class _2 : Form
    { private bug1 b1;
    private bug2 b2;
        public _2()
        {
            InitializeComponent();
        }

        private void _2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           int n = Convert.ToInt32(textBox1.Text);
            int r= n % 10;
            n = n / 10;
            while (n != 0)
            {
            if(n%10>=r)
                {
                    b2 = new bug2();
                    b2.ShowDialog();
                    break;
                }
            else
                {
                    r = n % 10;
                    n = n / 10;
                }
            if(n==0)
                { b1 = new bug1();
                    b1.ShowDialog();
                }
            }


        }
    }
}
