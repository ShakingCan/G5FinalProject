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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            Categorydescriptionbox = new TextBox();
            Categorynamebox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            add_btn = new Button();
            category_data = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)category_data).BeginInit();
            SuspendLayout();
            // 
            // Categorydescriptionbox
            // 
            Categorydescriptionbox.Location = new Point(185, 99);
            Categorydescriptionbox.Name = "Categorydescriptionbox";
            Categorydescriptionbox.Size = new Size(132, 23);
            Categorydescriptionbox.TabIndex = 32;
            // 
            // Categorynamebox
            // 
            Categorynamebox.Location = new Point(185, 66);
            Categorynamebox.Name = "Categorynamebox";
            Categorynamebox.Size = new Size(132, 23);
            Categorynamebox.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(39, 99);
            label3.Name = "label3";
            label3.Size = new Size(136, 19);
            label3.TabIndex = 29;
            label3.Text = "Category description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(39, 66);
            label2.Name = "label2";
            label2.Size = new Size(103, 19);
            label2.TabIndex = 28;
            label2.Text = "Category name";
            // 
            // add_btn
            // 
            add_btn.Location = new Point(143, 150);
            add_btn.Name = "add_btn";
            add_btn.Size = new Size(75, 23);
            add_btn.TabIndex = 33;
            add_btn.Text = "Add";
            add_btn.UseVisualStyleBackColor = true;
            add_btn.Click += add_btn_Click;
            // 
            // category_data
            // 
            category_data.AllowUserToAddRows = false;
            category_data.AllowUserToDeleteRows = false;
            category_data.AllowUserToResizeColumns = false;
            category_data.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 255, 128);
            category_data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            category_data.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            category_data.BackgroundColor = Color.Cornsilk;
            category_data.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            category_data.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Peru;
            dataGridViewCellStyle2.Font = new Font("Palatino Linotype", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.Khaki;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Honeydew;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            category_data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            category_data.ColumnHeadersHeight = 25;
            category_data.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.WindowFrame;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            category_data.DefaultCellStyle = dataGridViewCellStyle3;
            category_data.GridColor = SystemColors.WindowText;
            category_data.Location = new Point(364, 64);
            category_data.MultiSelect = false;
            category_data.Name = "category_data";
            category_data.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.ControlDark;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            category_data.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            category_data.RowHeadersVisible = false;
            category_data.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.BackColor = Color.Green;
            category_data.RowsDefaultCellStyle = dataGridViewCellStyle5;
            category_data.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            category_data.ShowCellErrors = false;
            category_data.ShowCellToolTips = false;
            category_data.ShowEditingIcon = false;
            category_data.ShowRowErrors = false;
            category_data.Size = new Size(572, 422);
            category_data.TabIndex = 50;
            // 
            // ucCategories
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(category_data);
            Controls.Add(add_btn);
            Controls.Add(Categorydescriptionbox);
            Controls.Add(Categorynamebox);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "ucCategories";
            Size = new Size(1025, 611);
            ((System.ComponentModel.ISupportInitialize)category_data).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Categorydescriptionbox;
        private TextBox Categorynamebox;
        private Label label3;
        private Label label2;
        private Button add_btn;
        private DataGridView category_data;
    }
}
