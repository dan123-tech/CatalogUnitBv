namespace CatalogUnitBv
{
    partial class TI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TI));
            Note = new TableLayoutPanel();
            button1 = new Button();
            SuspendLayout();
            // 
            // Note
            // 
            Note.ColumnCount = 3;
            Note.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.9955139F));
            Note.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.0044861F));
            Note.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 117F));
            Note.Location = new Point(12, 93);
            Note.Name = "Note";
            Note.RowCount = 5;
            Note.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Note.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            Note.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Note.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Note.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            Note.Size = new Size(747, 95);
            Note.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(360, 304);
            button1.Name = "button1";
            button1.Size = new Size(75, 33);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TI
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(28, 27, 31);
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(Note);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TI";
            Text = "Tehnologia informației";
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel Note;
        private Button button1;
    }
}