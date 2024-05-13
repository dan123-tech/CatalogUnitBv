namespace CatalogUnitBv
{
    partial class Create
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
            Email = new TextBox();
            Parola = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Register = new Button();
            SuspendLayout();
            // 
            // Email
            // 
            Email.Location = new Point(208, 65);
            Email.Name = "Email";
            Email.Size = new Size(100, 23);
            Email.TabIndex = 5;
            // 
            // Parola
            // 
            Parola.Location = new Point(208, 106);
            Parola.Name = "Parola";
            Parola.Size = new Size(100, 23);
            Parola.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(130, 73);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(130, 114);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 13;
            label7.Text = "label7";
            // 
            // Register
            // 
            Register.Location = new Point(208, 190);
            Register.Name = "Register";
            Register.Size = new Size(75, 23);
            Register.TabIndex = 14;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = true;
            Register.Click += button1_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(572, 385);
            Controls.Add(Register);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Parola);
            Controls.Add(Email);
            Name = "Create";
            Text = "Form6";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Email;
        private TextBox Parola;
        private Label label6;
        private Label label7;
        private Button Register;
    }
}