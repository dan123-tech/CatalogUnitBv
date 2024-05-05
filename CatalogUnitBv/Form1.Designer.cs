namespace CatalogUnitBv
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            Parola = new Label();
            Autentificare = new Button();
            Email = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            panel1 = new Panel();
            Save = new CheckBox();
            Recovery = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(101, 221);
            label1.Name = "label1";
            label1.Size = new Size(54, 25);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // Parola
            // 
            Parola.AutoSize = true;
            Parola.BackColor = Color.Transparent;
            Parola.ForeColor = Color.White;
            Parola.Location = new Point(101, 292);
            Parola.Name = "Parola";
            Parola.Size = new Size(60, 25);
            Parola.TabIndex = 2;
            Parola.Text = "Parola";
            // 
            // Autentificare
            // 
            Autentificare.BackColor = Color.FromArgb(238, 149, 76);
            Autentificare.Location = new Point(233, 401);
            Autentificare.Name = "Autentificare";
            Autentificare.Size = new Size(141, 44);
            Autentificare.TabIndex = 3;
            Autentificare.Text = "Autentificare";
            Autentificare.UseVisualStyleBackColor = false;
            // 
            // Email
            // 
            Email.Location = new Point(101, 249);
            Email.Name = "Email";
            Email.Size = new Size(403, 31);
            Email.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(101, 320);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(403, 31);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 7);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Universitatea";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.ForeColor = Color.White;
            label4.Location = new Point(89, 32);
            label4.Name = "label4";
            label4.Size = new Size(101, 25);
            label4.TabIndex = 7;
            label4.Text = "Transilvania";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.ForeColor = Color.White;
            label6.Location = new Point(89, 57);
            label6.Name = "label6";
            label6.Size = new Size(95, 25);
            label6.TabIndex = 9;
            label6.Text = "din Brasov";
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(598, 206);
            panel1.TabIndex = 10;
            // 
            // Save
            // 
            Save.AutoSize = true;
            Save.ForeColor = Color.White;
            Save.Location = new Point(101, 366);
            Save.Name = "Save";
            Save.Size = new Size(152, 29);
            Save.TabIndex = 11;
            Save.Text = "Tine-ma minte";
            Save.UseVisualStyleBackColor = true;
            // 
            // Recovery
            // 
            Recovery.AutoSize = true;
            Recovery.ForeColor = Color.FromArgb(238, 149, 76);
            Recovery.Location = new Point(309, 366);
            Recovery.Name = "Recovery";
            Recovery.Size = new Size(195, 25);
            Recovery.TabIndex = 12;
            Recovery.Text = "Probleme la conectare?";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(598, 465);
            Controls.Add(Recovery);
            Controls.Add(Save);
            Controls.Add(panel1);
            Controls.Add(textBox2);
            Controls.Add(Email);
            Controls.Add(Autentificare);
            Controls.Add(Parola);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Catalog UnitBv";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label Parola;
        private Button Autentificare;
        private TextBox Email;
        private TextBox textBox2;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel panel1;
        private CheckBox Save;
        private Label Recovery;
    }
}