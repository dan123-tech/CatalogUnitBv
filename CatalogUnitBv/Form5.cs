/*using MySql.Data.MySqlClient;
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
    public partial class NoteStudenti : Form
    {
        private int studentId;

        

      

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Nota.Text, out int id))
            {
                LoadDataFromDatabase(id);
            }
            else
            {
                MessageBox.Show("Please enter a valid student ID.");
            }
        }

        private void LoadDataFromDatabase(int id)
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
                                   WHERE s.Id = @studentId";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@studentId", id);

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
}*/