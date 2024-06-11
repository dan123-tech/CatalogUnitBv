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
using static CatalogUnitBv.Form1;

namespace CatalogUnitBv
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            int radius = 15; // Mărimea razei pentru colțurile curbate
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(button1.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(button1.Width - radius * 2, button1.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, button1.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidEmail(GlobalData.Email))
            {
                LoadDataFromDatabase(GlobalData.Email);
            }
            else
            {
                MessageBox.Show("Please enter a valid email.");
            }
        }
        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void LoadDataFromDatabase(string email)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";
                using (MySqlConnection con = new MySqlConnection(connstring))
                {
                    con.Open();

                    string sql = @"SELECT s.Nume AS Nume_Student, c.Disciplina, c.Nota 
                           FROM Catalog2 c
                           INNER JOIN Student2 s ON c.StudentId = s.Id
                           WHERE s.email = @studentEmail";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@studentEmail", email);

                        MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        // Display data in DataGridView
                        dataGridView1.DataSource = table;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }
    }
}
