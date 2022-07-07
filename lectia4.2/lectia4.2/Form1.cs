using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lectia4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //in eticheta se afiseaza intervalul selectat
            this.label1.Text = "Intervalul selectat: Start=" +
            e.Start.ToShortDateString() + " End: " + e.End.ToShortDateString();
            //daca este selectata o singura zi
            if (e.Start.ToShortDateString() == e.End.ToShortDateString())
            {
                string x = e.Start.ToShortDateString();
                //respectiva data este adaugata in ComboBox, daca nu exista deja
                if (!comboBox1.Items.Contains(x))
                    comboBox1.Items.Add(x);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
