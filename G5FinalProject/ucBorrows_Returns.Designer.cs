namespace G5FinalProject
{
    partial class ucBorrows_Returns
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
            ISBNbox = new TextBox();
            Remarksbox = new TextBox();
            Studentidnobox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Borrowdatepicker = new DateTimePicker();
            Returndatepicker = new DateTimePicker();
            SuspendLayout();
            // 
            // ISBNbox
            // 
            ISBNbox.Location = new Point(185, 205);
            ISBNbox.Name = "ISBNbox";
            ISBNbox.Size = new Size(132, 23);
            ISBNbox.TabIndex = 44;
            // 
            // Remarksbox
            // 
            Remarksbox.Location = new Point(185, 170);
            Remarksbox.Name = "Remarksbox";
            Remarksbox.Size = new Size(132, 23);
            Remarksbox.TabIndex = 43;
            // 
            // Studentidnobox
            // 
            Studentidnobox.Location = new Point(185, 66);
            Studentidnobox.Name = "Studentidnobox";
            Studentidnobox.Size = new Size(132, 23);
            Studentidnobox.TabIndex = 40;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(86, 205);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 36;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(86, 170);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 35;
            label4.Text = "Remarks";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(86, 133);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 34;
            label3.Text = "Return date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(86, 100);
            label2.Name = "label2";
            label2.Size = new Size(84, 19);
            label2.TabIndex = 33;
            label2.Text = "Borrow date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(86, 66);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 32;
            label1.Text = "Student ID no.";
            // 
            // Borrowdatepicker
            // 
            Borrowdatepicker.Location = new Point(185, 100);
            Borrowdatepicker.Name = "Borrowdatepicker";
            Borrowdatepicker.Size = new Size(200, 23);
            Borrowdatepicker.TabIndex = 45;
            // 
            // Returndatepicker
            // 
            Returndatepicker.Location = new Point(185, 133);
            Returndatepicker.Name = "Returndatepicker";
            Returndatepicker.Size = new Size(200, 23);
            Returndatepicker.TabIndex = 46;
            // 
            // ucBorrows_Returns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(Returndatepicker);
            Controls.Add(Borrowdatepicker);
            Controls.Add(ISBNbox);
            Controls.Add(Remarksbox);
            Controls.Add(Studentidnobox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucBorrows_Returns";
            Size = new Size(1025, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox ISBNbox;
        private TextBox Remarksbox;
        private TextBox Studentidnobox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DateTimePicker Borrowdatepicker;
        private DateTimePicker Returndatepicker;
    }
}
