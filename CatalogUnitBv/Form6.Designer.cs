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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Create));
            Email = new TextBox();
            Parola = new TextBox();
            label6 = new Label();
            label7 = new Label();
            Register = new Button();
            SuspendLayout();
            // 
            // Email
            // 
            Email.Location = new Point(297, 108);
            Email.Margin = new Padding(4, 5, 4, 5);
            Email.Name = "Email";
            Email.Size = new Size(274, 31);
            Email.TabIndex = 5;
            // 
            // Parola
            // 
            Parola.Location = new Point(297, 177);
            Parola.Margin = new Padding(4, 5, 4, 5);
            Parola.Name = "Parola";
            Parola.PasswordChar = '*';
            Parola.Size = new Size(274, 31);
            Parola.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.White;
            label6.Location = new Point(186, 122);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(54, 25);
            label6.TabIndex = 12;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.White;
            label7.Location = new Point(186, 182);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(60, 25);
            label7.TabIndex = 13;
            label7.Text = "Parola";
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(238, 149, 76);
            Register.Location = new Point(297, 317);
            Register.Margin = new Padding(4, 5, 4, 5);
            Register.Name = "Register";
            Register.Size = new Size(107, 38);
            Register.TabIndex = 14;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += button1_Click;
            // 
            // Create
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(817, 642);
            Controls.Add(Register);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(Parola);
            Controls.Add(Email);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Create";
            Text = "Înregistrare";
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