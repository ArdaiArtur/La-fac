using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace lectia6

{
    public static class Engine
    {
        public static Bitmap bmp;
        public static Graphics grp;
        public static PictureBox display;
        public static Color backColor = Color.Yellow;
        public static void init_graph(PictureBox _display)
        {
            display = _display;
            bmp = new Bitmap(display.Width, display.Height);
            grp = Graphics.FromImage(bmp);
            grp.Clear(backColor);
            display.Image = bmp;
        }
        public static List<Vertice> vertices = new List<Vertice>();
        public static void load(string filename)
        {
            TextReader data_load = new StreamReader(@"..\..\" + filename);
            int n = int.Parse(data_load.ReadLine());
            for(int i=0;i<n;i++)
                vertices.Add(new Vertice(data_load.ReadLine()));
        }

        public static void draw()
        {
            foreach (Vertice v in vertices)
                v.draw(grp);
            display.Image = bmp;
        }

    }
}
