using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CatalogUnitBv.Form1;

namespace CatalogUnitBv
{
    public partial class IESC : Form
    {
        public IESC()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle; 
            this.MaximizeBox = false; 
            this.MinimizeBox = false; 
            this.StartPosition = FormStartPosition.CenterScreen; 
            this.Size = new System.Drawing.Size(516, 65);
        }
        string email = GlobalData.Email;
        private void tehnologiaInformațieiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string email = GlobalData.Email;
            CheckEmailAndOpenForm(email);
        }
        private void CheckEmailAndOpenForm(string email)
        {
            if (email.EndsWith("@student.unitbv.ro"))
            {
                Form7 form7 = new Form7();
                form7.Show();
            }
            else if (email.EndsWith("@unitbv.ro"))
            {
                TI form4 = new TI();
                form4.Show();
            }
            else
            {
                MessageBox.Show("Email invalid sau necorespunzător.", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void IESC_Load(object sender, EventArgs e)
        {

        }
    }
}