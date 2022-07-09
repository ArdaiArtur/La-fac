using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
namespace lectia6
{
   public class Vertice
    {
        public static int size = 7;
        public Point map_location;
        public Color fill_color;
        public string name;
        public Vertice(string data)
        {
            string[] local = data.Split(' ',StringSplitOptions.RemoveEmptyEntries);
            name = local[0];
            string[] point_data = local[1].Split(new char[] { '(', ',', ')' },StringSplitOptions.RemoveEmptyEntries);
            map_location = new Point(int.Parse(point_data[0]), int.Parse(point_data[1]));
           
            string[] color_data = local[1].Split(new char[] { '[', ',', ']' }, StringSplitOptions.RemoveEmptyEntries);
            int r = int.Parse(color_data[0]);
            int g = int.Parse(color_data[1]);
            int b = int.Parse(color_data[2]);
            fill_color = Color.FromArgb(r, g, b);

        }

        public void draw(Graphics handler)
        {
            handler.FillEllipse(new SolidBrush(fill_color), map_location.X - size, map_location.Y - size, 2 * size + 1, 2 * size + 1);
            handler.DrawEllipse(new Pen(Color.Black), map_location.X - size, map_location.Y - size, 2 * size + 1, 2 * size + 1);
            handler.DrawString(name,new Font("Comic Sans Ms",10,FontStyle.Italic),new SolidBrush(Color.Black),map_location);

        }



    }
}
