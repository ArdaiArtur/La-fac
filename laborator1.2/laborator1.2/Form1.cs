using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laborator1._2
{
    public partial class Simpelcalculator : Form
    { double num1, num2, reslut;
        public Simpelcalculator()
        {
            InitializeComponent();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            reslut = num1 / num2;
            textBox3.Text = reslut.ToString();
        }

        private void Simpelcalculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            reslut = num1 + num2;
            textBox3.Text = reslut.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            reslut = num1 - num2;
            textBox3.Text = reslut.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            num1 = Convert.ToDouble(textBox1.Text);
            num2 = Convert.ToDouble(textBox2.Text);
            reslut = num1 * num2;
            textBox3.Text = reslut.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = " 0";
            textBox3.Text = "0";

        }
    }
}
