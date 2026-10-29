namespace G5FinalProject
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel2 = new Panel();
            btn_students = new Button();
            btn_authors = new Button();
            btn_categories = new Button();
            btn_brrwsretrns = new Button();
            btn_books = new Button();
            btn_dashboard = new Button();
            UCPanel = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkSeaGreen;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1264, 70);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(5, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(62, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightYellow;
            label1.Location = new Point(62, 18);
            label1.Name = "label1";
            label1.Size = new Size(380, 37);
            label1.TabIndex = 0;
            label1.Text = "Library Management System";
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkOliveGreen;
            panel2.Controls.Add(btn_students);
            panel2.Controls.Add(btn_authors);
            panel2.Controls.Add(btn_categories);
            panel2.Controls.Add(btn_brrwsretrns);
            panel2.Controls.Add(btn_books);
            panel2.Controls.Add(btn_dashboard);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 70);
            panel2.Name = "panel2";
            panel2.Size = new Size(239, 611);
            panel2.TabIndex = 1;
            // 
            // btn_students
            // 
            btn_students.Dock = DockStyle.Top;
            btn_students.FlatAppearance.BorderSize = 0;
            btn_students.FlatStyle = FlatStyle.Flat;
            btn_students.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_students.ForeColor = Color.Honeydew;
            btn_students.Image = (Image)resources.GetObject("btn_students.Image");
            btn_students.ImageAlign = ContentAlignment.MiddleLeft;
            btn_students.Location = new Point(0, 300);
            btn_students.Name = "btn_students";
            btn_students.Padding = new Padding(25, 0, 38, 0);
            btn_students.Size = new Size(239, 60);
            btn_students.TabIndex = 7;
            btn_students.Text = "Students";
            btn_students.UseVisualStyleBackColor = true;
            btn_students.Click += btn_students_Click;
            // 
            // btn_authors
            // 
            btn_authors.Dock = DockStyle.Top;
            btn_authors.FlatAppearance.BorderSize = 0;
            btn_authors.FlatStyle = FlatStyle.Flat;
            btn_authors.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_authors.ForeColor = Color.Honeydew;
            btn_authors.Image = (Image)resources.GetObject("btn_authors.Image");
            btn_authors.ImageAlign = ContentAlignment.MiddleLeft;
            btn_authors.Location = new Point(0, 240);
            btn_authors.Name = "btn_authors";
            btn_authors.Padding = new Padding(25, 0, 45, 0);
            btn_authors.Size = new Size(239, 60);
            btn_authors.TabIndex = 6;
            btn_authors.Text = "Authors";
            btn_authors.UseVisualStyleBackColor = true;
            btn_authors.Click += btn_authors_Click;
            // 
            // btn_categories
            // 
            btn_categories.Dock = DockStyle.Top;
            btn_categories.FlatAppearance.BorderSize = 0;
            btn_categories.FlatStyle = FlatStyle.Flat;
            btn_categories.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_categories.ForeColor = Color.Honeydew;
            btn_categories.Image = (Image)resources.GetObject("btn_categories.Image");
            btn_categories.ImageAlign = ContentAlignment.MiddleLeft;
            btn_categories.Location = new Point(0, 180);
            btn_categories.Name = "btn_categories";
            btn_categories.Padding = new Padding(30, 0, 30, 0);
            btn_categories.Size = new Size(239, 60);
            btn_categories.TabIndex = 5;
            btn_categories.Text = "Categories";
            btn_categories.UseVisualStyleBackColor = true;
            btn_categories.Click += btn_categories_Click;
            // 
            // btn_brrwsretrns
            // 
            btn_brrwsretrns.Dock = DockStyle.Top;
            btn_brrwsretrns.FlatAppearance.BorderSize = 0;
            btn_brrwsretrns.FlatStyle = FlatStyle.Flat;
            btn_brrwsretrns.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_brrwsretrns.ForeColor = Color.Honeydew;
            btn_brrwsretrns.Image = (Image)resources.GetObject("btn_brrwsretrns.Image");
            btn_brrwsretrns.ImageAlign = ContentAlignment.MiddleLeft;
            btn_brrwsretrns.Location = new Point(0, 120);
            btn_brrwsretrns.Name = "btn_brrwsretrns";
            btn_brrwsretrns.Padding = new Padding(25, 0, 15, 0);
            btn_brrwsretrns.Size = new Size(239, 60);
            btn_brrwsretrns.TabIndex = 4;
            btn_brrwsretrns.Text = "Borrows / Returns";
            btn_brrwsretrns.TextAlign = ContentAlignment.MiddleRight;
            btn_brrwsretrns.UseVisualStyleBackColor = true;
            btn_brrwsretrns.Click += btn_brrwsretrns_Click;
            // 
            // btn_books
            // 
            btn_books.Dock = DockStyle.Top;
            btn_books.FlatAppearance.BorderSize = 0;
            btn_books.FlatStyle = FlatStyle.Flat;
            btn_books.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_books.ForeColor = Color.Honeydew;
            btn_books.Image = (Image)resources.GetObject("btn_books.Image");
            btn_books.ImageAlign = ContentAlignment.MiddleLeft;
            btn_books.Location = new Point(0, 60);
            btn_books.Name = "btn_books";
            btn_books.Padding = new Padding(25, 0, 60, 0);
            btn_books.Size = new Size(239, 60);
            btn_books.TabIndex = 3;
            btn_books.Text = "Books";
            btn_books.UseVisualStyleBackColor = true;
            btn_books.Click += btn_books_Click;
            // 
            // btn_dashboard
            // 
            btn_dashboard.Dock = DockStyle.Top;
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Palatino Linotype", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.Honeydew;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(0, 0);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Padding = new Padding(25, 0, 25, 0);
            btn_dashboard.Size = new Size(239, 60);
            btn_dashboard.TabIndex = 2;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // UCPanel
            // 
            UCPanel.Dock = DockStyle.Fill;
            UCPanel.Location = new Point(239, 70);
            UCPanel.Name = "UCPanel";
            UCPanel.Size = new Size(1025, 611);
            UCPanel.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            ClientSize = new Size(1264, 681);
            Controls.Add(UCPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LMS";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private Button btn_dashboard;
        private Button btn_students;
        private Button btn_authors;
        private Button btn_categories;
        private Button btn_brrwsretrns;
        private Button btn_books;
        private Panel UCPanel;
    }
}