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
            lblPass = new Label();
            Autentificare = new Button();
            Email = new TextBox();
            Parola = new TextBox();
            Save = new CheckBox();
            Recovery = new Label();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            ImgFundal = new Panel();
            panel2 = new Panel();
            ImgFundal.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = Color.White;
            label1.Location = new Point(127, 169);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 1;
            label1.Text = "Email";
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.BackColor = Color.Transparent;
            lblPass.ForeColor = Color.White;
            lblPass.Location = new Point(127, 201);
            lblPass.Margin = new Padding(2, 0, 2, 0);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(40, 15);
            lblPass.TabIndex = 2;
            lblPass.Text = "Parola";
            // 
            // Autentificare
            // 
            Autentificare.BackColor = Color.FromArgb(238, 149, 76);
            Autentificare.Location = new Point(209, 288);
            Autentificare.Margin = new Padding(2);
            Autentificare.Name = "Autentificare";
            Autentificare.Size = new Size(99, 26);
            Autentificare.TabIndex = 3;
            Autentificare.Text = "Autentificare";
            Autentificare.UseVisualStyleBackColor = false;
            Autentificare.Click += Autentificare_Click;
            // 
            // Email
            // 
            Email.BackColor = Color.FromArgb(28, 27, 31);
            Email.ForeColor = Color.White;
            Email.Location = new Point(123, 180);
            Email.Margin = new Padding(2);
            Email.Name = "Email";
            Email.Size = new Size(283, 23);
            Email.TabIndex = 4;
            // 
            // Parola
            // 
            Parola.BackColor = Color.FromArgb(28, 27, 31);
            Parola.ForeColor = Color.White;
            Parola.Location = new Point(123, 211);
            Parola.Margin = new Padding(2);
            Parola.Name = "Parola";
            Parola.PasswordChar = '*';
            Parola.Size = new Size(283, 23);
            Parola.TabIndex = 5;
            // 
            // Save
            // 
            Save.AllowDrop = true;
            Save.AutoSize = true;
            Save.ForeColor = Color.White;
            Save.Location = new Point(123, 242);
            Save.Margin = new Padding(2);
            Save.Name = "Save";
            Save.Size = new Size(104, 19);
            Save.TabIndex = 11;
            Save.Text = "Tine-ma minte";
            Save.UseVisualStyleBackColor = true;
            // 
            // Recovery
            // 
            Recovery.AutoSize = true;
            Recovery.ForeColor = Color.FromArgb(238, 149, 76);
            Recovery.Location = new Point(268, 244);
            Recovery.Margin = new Padding(2, 0, 2, 0);
            Recovery.Name = "Recovery";
            Recovery.Size = new Size(130, 15);
            Recovery.TabIndex = 12;
            Recovery.Text = "Probleme la conectare?";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(117, 80);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(101, 21);
            label5.TabIndex = 8;
            label5.Text = "Universitatea";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(117, 101);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(92, 21);
            label4.TabIndex = 7;
            label4.Text = "Transilvania";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI", 12F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(117, 122);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(83, 21);
            label6.TabIndex = 9;
            label6.Text = "din Brasov";
            // 
            // ImgFundal
            // 
            ImgFundal.BackgroundImage = (Image)resources.GetObject("ImgFundal.BackgroundImage");
            ImgFundal.Controls.Add(label6);
            ImgFundal.Controls.Add(label4);
            ImgFundal.Controls.Add(panel2);
            ImgFundal.Controls.Add(label5);
            ImgFundal.Location = new Point(1, 2);
            ImgFundal.Name = "ImgFundal";
            ImgFundal.Size = new Size(548, 155);
            ImgFundal.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(39, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(73, 72);
            panel2.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(553, 355);
            Controls.Add(ImgFundal);
            Controls.Add(lblPass);
            Controls.Add(label1);
            Controls.Add(Recovery);
            Controls.Add(Save);
            Controls.Add(Parola);
            Controls.Add(Email);
            Controls.Add(Autentificare);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "Form1";
            ShowInTaskbar = false;
            Text = "Catalog UnitBv";
            ImgFundal.ResumeLayout(false);
            ImgFundal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label lblPass;
        private Button Autentificare;
        private TextBox Email;
        private TextBox Parola;
        private CheckBox Save;
        private Label Recovery;
        private Label label5;
        private Label label4;
        private Label label6;
        private Panel ImgFundal;
        private Panel panel2;
    }
}