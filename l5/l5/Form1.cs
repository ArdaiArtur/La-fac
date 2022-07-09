using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace l5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad");
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); //sterge textul afisat in caseta
            textBox1.Visible = false; //caseta redevine invizibila
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();//se va șterge textul introdus în TextBox
        }

        private void boldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem.Checked = !boldToolStripMenuItem.Checked;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 14,
           textBox1.Font.Style ^ FontStyle.Bold);
        }

        private void italicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem.Checked =
!italicToolStripMenuItem.Checked;
            textBox1.Font = new Font(textBox1.Font.FontFamily, 14,
           textBox1.Font.Style ^ FontStyle.Italic);
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Yellow;
        }
        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }
        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Blue;
        }
        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }
        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }
        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }

        private void boldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            boldToolStripMenuItem1.Checked = !boldToolStripMenuItem1.Checked;
            label1.Font = new Font(label1.Font.FontFamily, 14,
           label1.Font.Style ^ FontStyle.Bold);
        }
        private void italicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            italicToolStripMenuItem1.Checked =
           !italicToolStripMenuItem1.Checked;
            label1.Font = new Font(label1.Font.FontFamily, 14,
           label1.Font.Style ^ FontStyle.Italic);
        }
        private void regularToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void reguralToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reguralToolStripMenuItem.Checked =
           !reguralToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font.FontFamily, 14,
           label1.Font.Style ^ FontStyle.Regular);
        }
        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Exemplu de utilizare a meniurilor",
           "Informatii", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
