namespace G5FinalProject
{
    partial class ucBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Statusbox = new TextBox();
            Availablecopiesbox = new TextBox();
            Authorbox = new TextBox();
            Categorybox = new TextBox();
            ISBNbox = new TextBox();
            Descriptionbox = new TextBox();
            Titlebox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Addbtn = new Button();
            SuspendLayout();
            // 
            // Statusbox
            // 
            Statusbox.Location = new Point(159, 259);
            Statusbox.Name = "Statusbox";
            Statusbox.Size = new Size(132, 23);
            Statusbox.TabIndex = 44;
            // 
            // Availablecopiesbox
            // 
            Availablecopiesbox.Location = new Point(159, 223);
            Availablecopiesbox.Name = "Availablecopiesbox";
            Availablecopiesbox.Size = new Size(132, 23);
            Availablecopiesbox.TabIndex = 43;
            // 
            // Authorbox
            // 
            Authorbox.Location = new Point(159, 185);
            Authorbox.Name = "Authorbox";
            Authorbox.Size = new Size(132, 23);
            Authorbox.TabIndex = 42;
            // 
            // Categorybox
            // 
            Categorybox.Location = new Point(159, 150);
            Categorybox.Name = "Categorybox";
            Categorybox.Size = new Size(132, 23);
            Categorybox.TabIndex = 41;
            // 
            // ISBNbox
            // 
            ISBNbox.Location = new Point(159, 113);
            ISBNbox.Name = "ISBNbox";
            ISBNbox.Size = new Size(132, 23);
            ISBNbox.TabIndex = 40;
            // 
            // Descriptionbox
            // 
            Descriptionbox.Location = new Point(159, 80);
            Descriptionbox.Name = "Descriptionbox";
            Descriptionbox.Size = new Size(132, 23);
            Descriptionbox.TabIndex = 39;
            // 
            // Titlebox
            // 
            Titlebox.Location = new Point(159, 46);
            Titlebox.Name = "Titlebox";
            Titlebox.Size = new Size(132, 23);
            Titlebox.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(50, 259);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 37;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(50, 223);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 36;
            label6.Text = "Available copies";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(50, 185);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 35;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(50, 150);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 34;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(50, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 33;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(50, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 32;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(50, 46);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 31;
            label1.Text = "Title:";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(181, 300);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 45;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            // 
            // ucBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(Addbtn);
            Controls.Add(Statusbox);
            Controls.Add(Availablecopiesbox);
            Controls.Add(Authorbox);
            Controls.Add(Categorybox);
            Controls.Add(ISBNbox);
            Controls.Add(Descriptionbox);
            Controls.Add(Titlebox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucBooks";
            Size = new Size(1025, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Statusbox;
        private TextBox Availablecopiesbox;
        private TextBox Authorbox;
        private TextBox Categorybox;
        private TextBox ISBNbox;
        private TextBox Descriptionbox;
        private TextBox Titlebox;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Addbtn;
    }
}
