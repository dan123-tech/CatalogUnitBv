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

            GraphicsPath formaCurbata = new GraphicsPath();
            formaCurbata.AddArc(0, 0, 20, 20, 180, 90); // Colțul din stânga sus
            formaCurbata.AddArc(ImgFundal.Width - 30, 0, 20, 20, 270, 90); // Colțul din dreapta sus
            formaCurbata.AddArc(ImgFundal.Width - 30, ImgFundal.Height - 30, 20, 20, 0, 90); // Colțul din dreapta jos
            formaCurbata.AddArc(0, ImgFundal.Height - 20, 20, 20, 90, 90); // Colțul din stânga jos
            formaCurbata.CloseFigure(); // Închiderea figurii pentru a forma o formă închisă
            ImgFundal.Region = new Region(formaCurbata); // Setarea formei curbate ca regiune a panoului


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
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
