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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CatalogUnitBv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Autentificare.FlatAppearance.BorderSize = 0;
            Autentificare.FlatStyle = FlatStyle.Flat;

            int radius = 15; // Mărimea razei pentru colțurile curbate
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(Autentificare.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(Autentificare.Width - radius * 2, Autentificare.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, Autentificare.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            Autentificare.Region = new Region(path);

            


            Save.FlatAppearance.BorderColor = Color.White;// Culoare transparentă pentru bordură
            Save.FlatAppearance.CheckedBackColor = Color.FromArgb(238, 149, 76);
            Email.BorderStyle = BorderStyle.None; // Elimină stilul implicit al bordurii
            Email.BackColor = Color.FromArgb(37, 36, 40); // Setează culoarea fundalului
            Email.ForeColor = Color.White; // Setează culoarea textului
          
           

            Parola.BorderStyle = BorderStyle.None;
            Parola.BackColor = Color.FromArgb(37, 36, 40); // Setează culoarea fundalului
            Parola.ForeColor = Color.White; // Setează culoarea textului
        }

       

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Autentificare_Click(object sender, EventArgs e)
        {

        }
    }
}
