namespace G5FinalProject
{
    partial class LoginForm
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
            Usernamebox = new TextBox();
            label1 = new Label();
            Passwordbox = new TextBox();
            label2 = new Label();
            Loginbtn = new Button();
            label3 = new Label();
            button1 = new Button();
            ucRegister1 = new ucRegister();
            SuspendLayout();
            // 
            // Usernamebox
            // 
            Usernamebox.Location = new Point(392, 267);
            Usernamebox.Name = "Usernamebox";
            Usernamebox.Size = new Size(197, 23);
            Usernamebox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(392, 249);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // Passwordbox
            // 
            Passwordbox.Location = new Point(392, 315);
            Passwordbox.Name = "Passwordbox";
            Passwordbox.Size = new Size(197, 23);
            Passwordbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(392, 297);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Loginbtn
            // 
            Loginbtn.Location = new Point(392, 356);
            Loginbtn.Name = "Loginbtn";
            Loginbtn.Size = new Size(75, 23);
            Loginbtn.TabIndex = 4;
            Loginbtn.Text = "Login";
            Loginbtn.UseVisualStyleBackColor = true;
            Loginbtn.Click += Loginbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F);
            label3.Location = new Point(462, 203);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 5;
            label3.Text = "Login";
            // 
            // button1
            // 
            button1.Location = new Point(514, 356);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ucRegister1
            // 
            ucRegister1.BackColor = Color.Honeydew;
            ucRegister1.Dock = DockStyle.Fill;
            ucRegister1.Location = new Point(0, 0);
            ucRegister1.Name = "ucRegister1";
            ucRegister1.Size = new Size(1009, 572);
            ucRegister1.TabIndex = 7;
            ucRegister1.Visible = false;
            // 
            // ucLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1009, 572);
            Controls.Add(ucRegister1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(Loginbtn);
            Controls.Add(label2);
            Controls.Add(Passwordbox);
            Controls.Add(label1);
            Controls.Add(Usernamebox);
            Name = "ucLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Usernamebox;
        private Label label1;
        private TextBox Passwordbox;
        private Label label2;
        private Button Loginbtn;
        private Label label3;
        private Button button1;
        private ucRegister ucRegister1;
    }
}
