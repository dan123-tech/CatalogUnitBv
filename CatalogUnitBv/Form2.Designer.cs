namespace CatalogUnitBv
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            IESC = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // IESC
            // 
            IESC.BackColor = Color.Transparent;
            IESC.BackgroundImage = (Image)resources.GetObject("IESC.BackgroundImage");
            IESC.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            IESC.ForeColor = Color.White;
            IESC.Location = new Point(21, 216);
            IESC.Name = "IESC";
            IESC.Size = new Size(75, 75);
            IESC.TabIndex = 2;
            IESC.Text = "IESC";
            IESC.UseVisualStyleBackColor = false;
            IESC.Click += button2_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Location = new Point(22, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(75, 71);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Controls.Add(label3);
            panel2.Controls.Add(panel1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(-1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(617, 180);
            panel2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(103, 65);
            label3.Name = "label3";
            label3.Size = new Size(83, 21);
            label3.TabIndex = 7;
            label3.Text = "din Brasov";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(103, 44);
            label2.Name = "label2";
            label2.Size = new Size(92, 21);
            label2.TabIndex = 6;
            label2.Text = "Transilvania";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(103, 23);
            label1.Name = "label1";
            label1.Size = new Size(101, 21);
            label1.TabIndex = 5;
            label1.Text = "Universitatea";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(33, 183);
            label4.Name = "label4";
            label4.Size = new Size(102, 30);
            label4.TabIndex = 5;
            label4.Text = "Facultăți ";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(616, 478);
            Controls.Add(label4);
            Controls.Add(panel2);
            Controls.Add(IESC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Home";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button IESC;
        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}