namespace G5FinalProject
{
    partial class ucDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucDashboard));
            label1 = new Label();
            panel1 = new Panel();
            Totalbookscountlbl = new Label();
            panel2 = new Panel();
            Recentbooklist = new DataGridView();
            recentlyaddedcount = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Recentbooklist).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(127, 15);
            label1.TabIndex = 0;
            label1.Text = "Total number of books";
            // 
            // panel1
            // 
            panel1.Controls.Add(Totalbookscountlbl);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(451, 283);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 100);
            panel1.TabIndex = 1;
            // 
            // Totalbookscountlbl
            // 
            Totalbookscountlbl.AutoSize = true;
            Totalbookscountlbl.Location = new Point(21, 44);
            Totalbookscountlbl.Name = "Totalbookscountlbl";
            Totalbookscountlbl.Size = new Size(40, 15);
            Totalbookscountlbl.TabIndex = 1;
            Totalbookscountlbl.Text = "Count";
            // 
            // panel2
            // 
            panel2.Controls.Add(Recentbooklist);
            panel2.Controls.Add(recentlyaddedcount);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(29, 242);
            panel2.Name = "panel2";
            panel2.Size = new Size(378, 270);
            panel2.TabIndex = 2;
            // 
            // Recentbooklist
            // 
            Recentbooklist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Recentbooklist.Location = new Point(36, 67);
            Recentbooklist.Name = "Recentbooklist";
            Recentbooklist.Size = new Size(240, 150);
            Recentbooklist.TabIndex = 2;
            // 
            // recentlyaddedcount
            // 
            recentlyaddedcount.AutoSize = true;
            recentlyaddedcount.Location = new Point(12, 15);
            recentlyaddedcount.Name = "recentlyaddedcount";
            recentlyaddedcount.Size = new Size(40, 15);
            recentlyaddedcount.TabIndex = 1;
            recentlyaddedcount.Text = "Count";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 0);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 0;
            label3.Text = "Recently added books";
            // 
            // ucDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "ucDashboard";
            Size = new Size(1025, 611);
            Load += ucDashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)Recentbooklist).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private Label Totalbookscountlbl;
        private Panel panel2;
        private Label recentlyaddedcount;
        private Label label3;
        private DataGridView Recentbooklist;
    }
}
