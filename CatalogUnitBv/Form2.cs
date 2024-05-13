using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogUnitBv
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Setează stilul borderului la FixedSingle
            this.MaximizeBox = false; // Dezactivează butonul de maximizare
            this.MinimizeBox = false; // Dezactivează butonul de minimizare
            this.StartPosition = FormStartPosition.CenterScreen; // Centrează formularul la deschidere
            this.Size = new System.Drawing.Size(632, 517);
            IESC.FlatAppearance.BorderSize = 0;
            IESC.FlatStyle = FlatStyle.Flat;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            IESC form3 = new CatalogUnitBv.IESC();
            form3.Show();
        }
    }
}
