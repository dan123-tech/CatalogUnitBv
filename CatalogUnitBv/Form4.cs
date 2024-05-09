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
    public partial class TI : Form
    {
        public TI()
        {
            InitializeComponent();
            TableLayoutPanel table = Note;
            table.ColumnCount = 4;
            table.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            table.Controls.Add(new Label() { Text = "Numele studentului", TextAlign = ContentAlignment.MiddleCenter }, 0, 0);
            table.Controls.Add(new Label() { Text = "Materia", TextAlign = ContentAlignment.MiddleCenter }, 1, 0);
            table.Controls.Add(new Label() { Text = "Nota", TextAlign = ContentAlignment.MiddleCenter }, 2, 0);

            // Setează dimensiunea celulelor pentru capul de tabel
            table.ColumnStyles[0].SizeType = SizeType.AutoSize;
            table.ColumnStyles[1].SizeType = SizeType.AutoSize;
            table.ColumnStyles[2].SizeType = SizeType.AutoSize;
  

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
