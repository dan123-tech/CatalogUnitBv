using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogUnitBv
{
    public partial class IESC : Form
    {
        public IESC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Setează stilul borderului la FixedSingle
            this.MaximizeBox = false; // Dezactivează butonul de maximizare
            this.MinimizeBox = false; // Dezactivează butonul de minimizare
            this.StartPosition = FormStartPosition.CenterScreen; // Centrează formularul la deschidere
            this.Size = new System.Drawing.Size(516, 65);
        }

        private void tehnologiaInformațieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TI form4 = new TI();
            form4.Show();
        }
    }
}
