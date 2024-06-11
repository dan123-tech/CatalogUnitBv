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
using MySql.Data.MySqlClient;

namespace CatalogUnitBv
{
    public partial class TI : Form
    {
        public TI()
        {
            InitializeComponent();

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;

            int radius = 15;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(button1.Width - radius * 2, 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(button1.Width - radius * 2, button1.Height - radius * 2, radius * 2, radius * 2, 0, 90);
            path.AddArc(0, button1.Height - radius * 2, radius * 2, radius * 2, 90, 90);
            path.CloseAllFigures();
            button1.Region = new Region(path);

            LoadDataFromDatabase();


        }
        private void LoadDataFromDatabase()
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                string sql = "SELECT * FROM Catalog2";

                MySqlCommand cmd = new MySqlCommand(sql, con);
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);

                dataGridView1.DataSource = table;

                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error connecting to the database: " + ex.Message);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string connstring = "server=localhost;uid=root;pwd=danidani123;database=CatalogUnitbv";
                MySqlConnection con = new MySqlConnection(connstring);
                con.Open();

                // Iterate through the DataGridView rows
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (!row.IsNewRow) // Check if the row is not the new row for data entry
                    {
                        // Extract the values from the DataGridView row
                        int id = Convert.ToInt32(row.Cells["Id"].Value);
                        string disciplina = row.Cells["Disciplina"].Value.ToString();
                        int profesorId = Convert.ToInt32(row.Cells["ProfesorId"].Value);
                        int studentId = Convert.ToInt32(row.Cells["StudentId"].Value);
                        int nota = Convert.ToInt32(row.Cells["Nota"].Value);

                        // Prepare the SQL UPDATE statement
                        string sql = "UPDATE Catalog SET Disciplina = @disciplina, ProfesorId = @profesorId, StudentId = @studentId, Nota = @nota WHERE Id = @id";

                        // Create MySqlCommand object and assign the SQL statement and connection
                        MySqlCommand cmd = new MySqlCommand(sql, con);

                        // Add parameters to the SQL command
                        cmd.Parameters.AddWithValue("@disciplina", disciplina);
                        cmd.Parameters.AddWithValue("@profesorId", profesorId);
                        cmd.Parameters.AddWithValue("@studentId", studentId);
                        cmd.Parameters.AddWithValue("@nota", nota);
                        cmd.Parameters.AddWithValue("@id", id);

                        // Execute the SQL command
                        cmd.ExecuteNonQuery();
                    }
                }
                
                // Display a success message
                MessageBox.Show("Database updated successfully.");

                // Close the database connection
                con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error updating database: " + ex.Message);
            }
        }

    }
}
