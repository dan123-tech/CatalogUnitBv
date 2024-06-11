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


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
