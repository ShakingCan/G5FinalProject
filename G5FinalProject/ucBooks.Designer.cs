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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Availablecopiesbox = new TextBox();
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
            status_cbox = new ComboBox();
            category_cbox = new ComboBox();
            author_cbox = new ComboBox();
            books_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)books_data).BeginInit();
            SuspendLayout();
            // 
            // Availablecopiesbox
            // 
            Availablecopiesbox.Location = new Point(137, 223);
            Availablecopiesbox.Name = "Availablecopiesbox";
            Availablecopiesbox.Size = new Size(132, 23);
            Availablecopiesbox.TabIndex = 43;
            // 
            // ISBNbox
            // 
            ISBNbox.Location = new Point(137, 113);
            ISBNbox.Name = "ISBNbox";
            ISBNbox.Size = new Size(132, 23);
            ISBNbox.TabIndex = 40;
            // 
            // Descriptionbox
            // 
            Descriptionbox.Location = new Point(137, 80);
            Descriptionbox.Name = "Descriptionbox";
            Descriptionbox.Size = new Size(132, 23);
            Descriptionbox.TabIndex = 39;
            // 
            // Titlebox
            // 
            Titlebox.Location = new Point(137, 46);
            Titlebox.Name = "Titlebox";
            Titlebox.Size = new Size(132, 23);
            Titlebox.TabIndex = 38;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(28, 259);
            label7.Name = "label7";
            label7.Size = new Size(47, 19);
            label7.TabIndex = 37;
            label7.Text = "Status";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(28, 223);
            label6.Name = "label6";
            label6.Size = new Size(105, 19);
            label6.TabIndex = 36;
            label6.Text = "Available copies";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(28, 185);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 35;
            label5.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(28, 150);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 34;
            label4.Text = "Category";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(28, 113);
            label3.Name = "label3";
            label3.Size = new Size(38, 19);
            label3.TabIndex = 33;
            label3.Text = "ISBN";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(28, 80);
            label2.Name = "label2";
            label2.Size = new Size(78, 19);
            label2.TabIndex = 32;
            label2.Text = "Description";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(28, 46);
            label1.Name = "label1";
            label1.Size = new Size(37, 19);
            label1.TabIndex = 31;
            label1.Text = "Title:";
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(159, 300);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(75, 23);
            Addbtn.TabIndex = 45;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // status_cbox
            // 
            status_cbox.FormattingEnabled = true;
            status_cbox.Location = new Point(137, 259);
            status_cbox.Name = "status_cbox";
            status_cbox.Size = new Size(132, 23);
            status_cbox.TabIndex = 46;
            // 
            // category_cbox
            // 
            category_cbox.FormattingEnabled = true;
            category_cbox.Location = new Point(137, 149);
            category_cbox.Name = "category_cbox";
            category_cbox.Size = new Size(132, 23);
            category_cbox.TabIndex = 47;
            // 
            // author_cbox
            // 
            author_cbox.FormattingEnabled = true;
            author_cbox.Location = new Point(137, 184);
            author_cbox.Name = "author_cbox";
            author_cbox.Size = new Size(132, 23);
            author_cbox.TabIndex = 48;
            // 
            // books_data
            // 
            books_data.AllowUserToAddRows = false;
            books_data.AllowUserToDeleteRows = false;
            books_data.AllowUserToResizeColumns = false;
            books_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            books_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            books_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            books_data.BackgroundColor = Color.Cornsilk;
            books_data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            books_data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Peru;
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Khaki;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            books_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            books_data.ColumnHeadersHeight = 25;
            books_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            books_data.DefaultCellStyle = dataGridViewCellStyle3;
            books_data.GridColor = SystemColors.WindowText;
            books_data.Location = new Point(297, 46);
            books_data.MultiSelect = false;
            books_data.Name = "books_data";
            books_data.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            books_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            books_data.RowHeadersVisible = false;
            books_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.Green;
            books_data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            books_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            books_data.ShowCellErrors = false;
            books_data.ShowCellToolTips = false;
            books_data.ShowEditingIcon = false;
            books_data.ShowRowErrors = false;
            books_data.Size = new Size(697, 422);
            books_data.TabIndex = 49;
            // 
            // ucBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(books_data);
            Controls.Add(author_cbox);
            Controls.Add(category_cbox);
            Controls.Add(status_cbox);
            Controls.Add(Addbtn);
            Controls.Add(Availablecopiesbox);
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
            Load += ucBooks_Load;
            ((System.ComponentModel.ISupportInitialize)books_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Availablecopiesbox;
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
        private ComboBox status_cbox;
        private ComboBox category_cbox;
        private ComboBox author_cbox;
        private DataGridView books_data;
    }
}
