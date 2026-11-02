namespace G5FinalProject
{
    partial class ucAuthors
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
            Authoridnobox = new TextBox();
            Lastnamebox = new TextBox();
            Middlenamebox = new TextBox();
            Firstnamebox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            Authoridno = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Addauthorbtn = new Button();
            Dateofbirthpicker = new DateTimePicker();
            Genderbox = new ComboBox();
            SuspendLayout();
            // 
            // Authoridnobox
            // 
            Authoridnobox.Location = new Point(203, 61);
            Authoridnobox.Name = "Authoridnobox";
            Authoridnobox.Size = new Size(132, 23);
            Authoridnobox.TabIndex = 41;
            // 
            // Lastnamebox
            // 
            Lastnamebox.Location = new Point(203, 166);
            Lastnamebox.Name = "Lastnamebox";
            Lastnamebox.Size = new Size(132, 23);
            Lastnamebox.TabIndex = 40;
            // 
            // Middlenamebox
            // 
            Middlenamebox.Location = new Point(203, 133);
            Middlenamebox.Name = "Middlenamebox";
            Middlenamebox.Size = new Size(132, 23);
            Middlenamebox.TabIndex = 39;
            // 
            // Firstnamebox
            // 
            Firstnamebox.Location = new Point(203, 99);
            Firstnamebox.Name = "Firstnamebox";
            Firstnamebox.Size = new Size(132, 23);
            Firstnamebox.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(104, 238);
            label6.Name = "label6";
            label6.Size = new Size(54, 19);
            label6.TabIndex = 36;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(104, 200);
            label5.Name = "label5";
            label5.Size = new Size(87, 19);
            label5.TabIndex = 35;
            label5.Text = "Date of birth";
            // 
            // Authoridno
            // 
            Authoridno.AutoSize = true;
            Authoridno.Font = new Font("Segoe UI", 10F);
            Authoridno.Location = new Point(104, 61);
            Authoridno.Name = "Authoridno";
            Authoridno.Size = new Size(93, 19);
            Authoridno.TabIndex = 34;
            Authoridno.Text = "Author ID no.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(104, 166);
            label3.Name = "label3";
            label3.Size = new Size(72, 19);
            label3.TabIndex = 33;
            label3.Text = "Last name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(104, 133);
            label2.Name = "label2";
            label2.Size = new Size(89, 19);
            label2.TabIndex = 32;
            label2.Text = "Middle name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(104, 99);
            label1.Name = "label1";
            label1.Size = new Size(76, 19);
            label1.TabIndex = 31;
            label1.Text = "First name:";
            // 
            // Addauthorbtn
            // 
            Addauthorbtn.Location = new Point(168, 291);
            Addauthorbtn.Name = "Addauthorbtn";
            Addauthorbtn.Size = new Size(75, 23);
            Addauthorbtn.TabIndex = 44;
            Addauthorbtn.Text = "Add";
            Addauthorbtn.UseVisualStyleBackColor = true;
            Addauthorbtn.Click += Addauthorbtn_Click;
            // 
            // Dateofbirthpicker
            // 
            Dateofbirthpicker.Location = new Point(203, 200);
            Dateofbirthpicker.Name = "Dateofbirthpicker";
            Dateofbirthpicker.Size = new Size(200, 23);
            Dateofbirthpicker.TabIndex = 45;
            // 
            // Genderbox
            // 
            Genderbox.FormattingEnabled = true;
            Genderbox.Items.AddRange(new object[] { "Male", "Female" });
            Genderbox.Location = new Point(203, 234);
            Genderbox.Name = "Genderbox";
            Genderbox.Size = new Size(121, 23);
            Genderbox.TabIndex = 46;
            // 
            // ucAuthors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(Genderbox);
            Controls.Add(Dateofbirthpicker);
            Controls.Add(Addauthorbtn);
            Controls.Add(Authoridnobox);
            Controls.Add(Lastnamebox);
            Controls.Add(Middlenamebox);
            Controls.Add(Firstnamebox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(Authoridno);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucAuthors";
            Size = new Size(1025, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Authoridnobox;
        private TextBox Lastnamebox;
        private TextBox Middlenamebox;
        private TextBox Firstnamebox;
        private Label label6;
        private Label label5;
        private Label Authoridno;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button Addauthorbtn;
        private DateTimePicker Dateofbirthpicker;
        private ComboBox Genderbox;
    }
}
