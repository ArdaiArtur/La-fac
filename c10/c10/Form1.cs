using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engen.init_graph(pictureBox1);
            Engen.load(@"../../dat.txt");
            /* for(int i=0;i<Engen.n;i++)
             {
                 string buffer = "";
                 for (int j = 0; j < Engen.n; j++)
                     buffer = buffer + Engen.ma[i, j] + " ";
                 listBox1.Items.Add(buffer);

             }*/
            Engen.draw();
        }
    }
}
