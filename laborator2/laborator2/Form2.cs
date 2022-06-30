using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace laborator2
{
    public partial class upform : Form
    {
        public upform()
        {
            InitializeComponent();
        }

        private void upbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            DateTime DataCurenta = DateTime.Now;
            //Data curenta va fi reținuta in variabila DataCurenta de //tip 
            
 label1.Text = DataCurenta.ToLongTimeString();
        }
    }
}
