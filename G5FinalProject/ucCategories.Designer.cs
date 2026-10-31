namespace G5FinalProject
{
    partial class ucCategories
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
            Categorydescriptionbox = new TextBox();
            Categorynamebox = new TextBox();
            Categoryidnobox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // Categorydescriptionbox
            // 
            Categorydescriptionbox.Location = new Point(174, 102);
            Categorydescriptionbox.Name = "Categorydescriptionbox";
            Categorydescriptionbox.Size = new Size(132, 23);
            Categorydescriptionbox.TabIndex = 32;
            // 
            // Categorynamebox
            // 
            Categorynamebox.Location = new Point(174, 69);
            Categorynamebox.Name = "Categorynamebox";
            Categorynamebox.Size = new Size(132, 23);
            Categorynamebox.TabIndex = 31;
            // 
            // Categoryidnobox
            // 
            Categoryidnobox.Location = new Point(174, 35);
            Categoryidnobox.Name = "Categoryidnobox";
            Categoryidnobox.Size = new Size(132, 23);
            Categoryidnobox.TabIndex = 30;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(28, 102);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 29;
            label3.Text = "Category description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 69);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 28;
            label2.Text = "Category name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 35);
            label1.Name = "label1";
            label1.Size = new Size(106, 19);
            label1.TabIndex = 27;
            label1.Text = "Category ID no.";
            // 
            // ucCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(Categorydescriptionbox);
            Controls.Add(Categorynamebox);
            Controls.Add(Categoryidnobox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucCategories";
            Size = new Size(1025, 611);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Categorydescriptionbox;
        private TextBox Categorynamebox;
        private TextBox Categoryidnobox;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
