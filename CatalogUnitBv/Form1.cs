using MySql.Data.MySqlClient;
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
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Setează stilul borderului la FixedSingle
            this.MaximizeBox = false; // Dezactivează butonul de maximizare
            this.MinimizeBox = false; // Dezactivează butonul de minimizare
            this.StartPosition = FormStartPosition.CenterScreen; // Centrează formularul la deschidere
            this.Size = new System.Drawing.Size(557, 370);
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
            try
            {
                string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";
                MySqlConnection con = new MySqlConnection();
                con.ConnectionString = connstring;
                con.Open();

                string email = Email.Text; // Obține emailul introdus
                string parola = Parola.Text; // Obține parola introdusă

                // Verifică existența unui student cu emailul și parola introduse
                string sql = $"SELECT * FROM Student WHERE Email = '{email}' AND Parola = '{parola}'";
                GlobalData.Email = email;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataReader reader = cmd.ExecuteReader();

                // Dacă există un student cu emailul și parola introduse
                if (reader.HasRows)
                {
                    Form2 form2 = new Form2();
                    form2.Show();
                }
                else
                {
                    DialogResult result = MessageBox.Show("Autentificare eșuată. Verificați emailul și parola.\nDoriți să vă înregistrați?", "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                    if (result == DialogResult.Yes)
                    {
                        // Deschideți Form6 pentru înregistrare
                        Create form6 = new Create();
                        form6.Show();
                    }
                }


                reader.Close(); // Închide reader-ul
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public static class GlobalData
        {
            public static string Email { get; set; }
        }

    }
} 
    

