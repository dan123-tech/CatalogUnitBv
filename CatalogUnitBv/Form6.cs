using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CatalogUnitBv
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
            Register.FlatAppearance.BorderSize = 0;
            Register.FlatStyle = FlatStyle.Flat;
            int radius = 15; // Mărimea razei pentru colțurile curbate
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(Register.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(Register.Width - radius * 2, Register.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, Register.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            Register.Region = new Region(path);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        private bool IsEmailValid(string email)
        {
            // Expresie regulată pentru validarea adreselor de email conform cerințelor specificate
            string pattern = @"^[a-zA-Z0-9_.+-]+@(?:student\.unitbv\.ro|unitbv\.ro)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(email);
        }
        private string ComputeHash(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }
        private bool IsStrongPassword(string password)
        {
            // Verifică dacă parola respectă cerințele
            if (password.Length < 8)
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            if (!password.Any(c => !char.IsLetterOrDigit(c) && !char.IsWhiteSpace(c)))
                return false;

            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = Email.Text;
            string parola = Parola.Text;

            if (!IsStrongPassword(parola))
            {
                MessageBox.Show("Parola trebuie să conțină cel puțin 8 caractere, cel puțin o literă mare, o literă mică, o cifră și un caracter special.");
                return;
            }
            if (!IsEmailValid(email))
            {
                MessageBox.Show("Adresa de email trebuie să fie în formatul @student.unitbv.ro sau @unitbv.ro.");
                return;
            }
            string hashedParola = ComputeHash(parola);
            try
            {
                string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";

                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();
                    string sql = "INSERT INTO Student (Email, Parola) VALUES (@Email, @Parola)";
                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Parola", hashedParola);
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Înregistrare reușită!");
                    }
                    else
                    {
                        MessageBox.Show("Înregistrare eșuată! Vă rugăm să încercați din nou.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Eroare: " + ex.Message);
            }
        }

    }
}
