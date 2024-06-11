using CatalogUnitBv.Properties;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CatalogUnitBv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;

            Autentificare.FlatAppearance.BorderSize = 0;
            Autentificare.FlatStyle = FlatStyle.Flat;

            int radius = 15;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(Autentificare.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(Autentificare.Width - radius * 2, Autentificare.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, Autentificare.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            Autentificare.Region = new Region(path);

            GraphicsPath formaCurbata = new GraphicsPath();
            formaCurbata.AddArc(0, 0, 20, 20, 180, 90);
            formaCurbata.AddArc(ImgFundal.Width - 30, 0, 20, 20, 270, 90);
            formaCurbata.AddArc(ImgFundal.Width - 30, ImgFundal.Height - 30, 20, 20, 0, 90);
            formaCurbata.AddArc(0, ImgFundal.Height - 20, 20, 20, 90, 90);
            formaCurbata.CloseFigure();
            ImgFundal.Region = new Region(formaCurbata);

            Save.FlatAppearance.BorderColor = Color.White;
            Save.FlatAppearance.CheckedBackColor = Color.FromArgb(238, 149, 76);
            Email.BorderStyle = BorderStyle.None;
            Email.BackColor = Color.FromArgb(37, 36, 40);
            Email.ForeColor = Color.White;

            Parola.BorderStyle = BorderStyle.None;
            Parola.BackColor = Color.FromArgb(37, 36, 40);
            Parola.ForeColor = Color.White;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            // Your label5 click event code here
        }

        private void Autentificare_Click(object sender, EventArgs e)
        {
            string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";

            try

            {
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    string email = Email.Text;
                    string parola = Parola.Text;
                    string sql;

                    if (email.EndsWith("@student.unitbv.ro"))
                    {
                        sql = "SELECT * FROM Student2 WHERE Email = @Email AND Parola = @Parola";
                    }
                    else if (email.EndsWith("@unitbv.ro"))
                    {
                        sql = "SELECT * FROM Profesor2 WHERE Email = @Email AND Parola = @Parola";
                    }
                    else
                    {
                        MessageBox.Show("Email invalid. Vă rugăm să introduceți un email valid.");
                        return;
                    }

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Parola", parola);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                GlobalData.Email = email;
                                Form2 form2 = new Form2();
                                form2.Show();
                            }
                            else
                            {
                                DialogResult result = MessageBox.Show("Autentificare eșuată. Verificați emailul și parola.\nDoriți să vă înregistrați?", "Eroare", MessageBoxButtons.YesNo, MessageBoxIcon.Error);

                                if (result == DialogResult.Yes)
                                {
                                    Create form6 = new Create();
                                    form6.Show();
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Eroare de conexiune la baza de date: " + ex.Message);
            }
        }
 private void Recovery_Click(object sender, EventArgs e)
        {
            Change_Pass form8 = new Change_Pass();
            form8.Show();
        }
        public static class GlobalData
        {
            public static string Email { get; set; }
        }
    }
}


           

