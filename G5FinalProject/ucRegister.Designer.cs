namespace G5FinalProject
{
    partial class ucRegister
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
            Registerbtn = new Button();
            label2 = new Label();
            Passwordbox = new TextBox();
            label1 = new Label();
            Usernamebox = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // Registerbtn
            // 
            Registerbtn.Location = new Point(465, 346);
            Registerbtn.Name = "Registerbtn";
            Registerbtn.Size = new Size(75, 23);
            Registerbtn.TabIndex = 9;
            Registerbtn.Text = "Register";
            Registerbtn.UseVisualStyleBackColor = true;
            Registerbtn.Click += Registerbtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(414, 289);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 8;
            label2.Text = "Password";
            // 
            // Passwordbox
            // 
            Passwordbox.Location = new Point(414, 307);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.Size = new Size(197, 23);
            Passwordbox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(414, 241);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 6;
            label1.Text = "Username";
            // 
            // Usernamebox
            // 
            Usernamebox.Location = new Point(414, 259);
            Usernamebox.Name = "Usernamebox";
            Usernamebox.Size = new Size(197, 23);
            Usernamebox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(465, 198);
            label3.Name = "label3";
            label3.Size = new Size(75, 25);
            label3.TabIndex = 10;
            label3.Text = "Register";
            // 
            // ucRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(label3);
            Controls.Add(Registerbtn);
            Controls.Add(label2);
            Controls.Add(Passwordbox);
            Controls.Add(label1);
            Controls.Add(Usernamebox);
            Name = "ucRegister";
            Size = new Size(1025, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Registerbtn;
        private Label label2;
        private TextBox Passwordbox;
        private Label label1;
        private TextBox Usernamebox;
        private Label label3;
    }
}
