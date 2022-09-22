using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace temaeu
{
    public partial class Form1 : Form
    {
        public Bitmap s, d;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            d = new Bitmap(s.Width * 2 - 1, s.Height * 2 - 1);
            for (int i = 0; i < s.Width; i++)
                for (int j = 0; j < s.Height; j++)
                {
                    d.SetPixel(i * 2, j * 2, s.GetPixel(i, j));
                   // Color t = s.GetPixel(i, j);
                   // d.SetPixel(i, j, t);

                }
           for (int i = 0; i < s.Width * 2 - 1; i=i+1)
                for (int j = 1; j < s.Height * 2 - 1; j=j+2)
                {
                    Color t1 = d.GetPixel(i, j - 1);
                    Color t2 = d.GetPixel(i, j + 1);
                    Color n = Color.FromArgb((t1.R + t2.R) / 2, (t1.G + t2.G) / 2, (t1.B + t2.B) / 2);
                    d.SetPixel(i, j, n);
                }

            for (int i = 1; i < s.Width * 2 - 1; i = i + 2)
                for (int j = 0; j < s.Height * 2 - 1; j = j + 1)
                {
                    Color t1 = d.GetPixel(i-1, j);
                    Color t2 = d.GetPixel(i+1, j);
                    Color n = Color.FromArgb((t1.R + t2.R) / 2, (t1.G + t2.G) / 2, (t1.B + t2.B) / 2);
                    d.SetPixel(i, j, n);
                }
            pictureBox2.Size = d.Size;
            pictureBox2.Image = d;
        }

                    

        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            s = new Bitmap(Image.FromFile(@"..\..\download.jpg"));
            pictureBox1.Image = s;
            
        }
    }
}
