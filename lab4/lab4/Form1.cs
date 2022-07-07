using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void SeteazaLista()
        {
            elevi.Columns.Add("Nume", 200, HorizontalAlignment.Left);
            elevi.Columns.Add("Prenume", 200, HorizontalAlignment.Left);
            elevi.Columns.Add("Nota", 200, HorizontalAlignment.Left);
            //modul de vizualizare este Detalii
            elevi.View = View.Details;
            //informatiile din lista sunt sortate alfabetic
            elevi.Sorting = SortOrder.Ascending;
            elevi.AllowColumnReorder = true;
        }


        private void elevi_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.elevi.BeginUpdate();
            ListViewItem a;
            ListViewItem.ListViewSubItem b;
            //c este un obiect din multimea de elevi returnata de metoda
            //CitesteElevi() din clasa Elev
            foreach (Elev c in Elev.CitesteElevi())
            {
                //se creeaza un nou item pentru controlul ListView
                a = new ListViewItem();
                //numele elevului din obiectul c este memorat in proprietatea Text
                a.Text = c.Nume;
                //se creeaza un subitem pentru controlul ListView
                b = new ListViewItem.ListViewSubItem();
                //prenumele elev. este memorat in obiectul a proprietatea Text
                b.Text = c.Prenume;
                //se adauga prenumele la itemul a
                a.SubItems.Add(b);
                //se creeaza un nou subitem b in care se memoreaza nota elevului
                b = new ListViewItem.ListViewSubItem();
                //nota se adauga in itemul a
                b.Text = c.Nota.ToString();
                a.SubItems.Add(b);
                //itemul a este complet si se adauga in controlul ListView
                elevi.Items.Add(a);
            }
            this.elevi.EndUpdate();
            //s-a terminat actualizarea informatiilor din ListView
            SeteazaLista();
            //apeleaza metoda care stabileste optiunile de afisare pentru ListView
        }
    }
}
