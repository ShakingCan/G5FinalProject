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
            Remarksbox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Borrowdatepicker = new DateTimePicker();
            BorrowRecordView = new DataGridView();
            Studentidnobox = new ComboBox();
            ISBNbox = new ComboBox();
            label3 = new Label();
            Returndatepicker = new DateTimePicker();
            Addbtn = new Button();
            editbtn = new Button();
            EditPanel = new Panel();
            Cancelbtn = new Button();
            Applybtn = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)BorrowRecordView).BeginInit();
            EditPanel.SuspendLayout();
            SuspendLayout();
            // 
            // Remarksbox
            // 
            Remarksbox.Location = new Point(170, 90);
            Remarksbox.Name = "Remarksbox";
            Remarksbox.Size = new Size(132, 23);
            Remarksbox.TabIndex = 43;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(86, 130);
            label5.Name = "label5";
            label5.Size = new Size(38, 19);
            label5.TabIndex = 36;
            label5.Text = "ISBN";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(71, 90);
            label4.Name = "label4";
            label4.Size = new Size(61, 19);
            label4.TabIndex = 35;
            label4.Text = "Remarks";
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
            // BorrowRecordView
            // 
            BorrowRecordView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BorrowRecordView.Location = new Point(507, 57);
            BorrowRecordView.Name = "BorrowRecordView";
            BorrowRecordView.Size = new Size(458, 255);
            BorrowRecordView.TabIndex = 47;
            // 
            // Studentidnobox
            // 
            Studentidnobox.DropDownStyle = ComboBoxStyle.DropDownList;
            Studentidnobox.FormattingEnabled = true;
            Studentidnobox.Location = new Point(185, 66);
            Studentidnobox.Name = "Studentidnobox";
            Studentidnobox.Size = new Size(121, 23);
            Studentidnobox.TabIndex = 48;
            // 
            // ISBNbox
            // 
            ISBNbox.DropDownStyle = ComboBoxStyle.DropDownList;
            ISBNbox.FormattingEnabled = true;
            ISBNbox.Location = new Point(185, 129);
            ISBNbox.Name = "ISBNbox";
            ISBNbox.Size = new Size(121, 23);
            ISBNbox.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(71, 61);
            label3.Name = "label3";
            label3.Size = new Size(81, 19);
            label3.TabIndex = 34;
            label3.Text = "Return date";
            // 
            // Returndatepicker
            // 
            Returndatepicker.Location = new Point(170, 61);
            Returndatepicker.Name = "Returndatepicker";
            Returndatepicker.Size = new Size(200, 23);
            Returndatepicker.TabIndex = 46;
            // 
            // Addbtn
            // 
            Addbtn.Location = new Point(225, 169);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(92, 23);
            Addbtn.TabIndex = 50;
            Addbtn.Text = "Add record";
            Addbtn.UseVisualStyleBackColor = true;
            Addbtn.Click += Addbtn_Click;
            // 
            // editbtn
            // 
            editbtn.Location = new Point(890, 332);
            editbtn.Name = "editbtn";
            editbtn.Size = new Size(75, 23);
            editbtn.TabIndex = 51;
            editbtn.Text = "Edit";
            editbtn.UseVisualStyleBackColor = true;
            editbtn.Click += editbtn_Click;
            // 
            // EditPanel
            // 
            EditPanel.Controls.Add(label6);
            EditPanel.Controls.Add(Cancelbtn);
            EditPanel.Controls.Add(Applybtn);
            EditPanel.Controls.Add(Returndatepicker);
            EditPanel.Controls.Add(label3);
            EditPanel.Controls.Add(label4);
            EditPanel.Controls.Add(Remarksbox);
            EditPanel.Location = new Point(39, 209);
            EditPanel.Name = "EditPanel";
            EditPanel.Size = new Size(431, 162);
            EditPanel.TabIndex = 52;
            EditPanel.Visible = false;
            // 
            // Cancelbtn
            // 
            Cancelbtn.Location = new Point(253, 119);
            Cancelbtn.Name = "Cancelbtn";
            Cancelbtn.Size = new Size(75, 23);
            Cancelbtn.TabIndex = 48;
            Cancelbtn.Text = "Cancel";
            Cancelbtn.UseVisualStyleBackColor = true;
            Cancelbtn.Click += Cancelbtn_Click;
            // 
            // Applybtn
            // 
            Applybtn.Location = new Point(118, 119);
            Applybtn.Name = "Applybtn";
            Applybtn.Size = new Size(75, 23);
            Applybtn.TabIndex = 47;
            Applybtn.Text = "Apply";
            Applybtn.UseVisualStyleBackColor = true;
            Applybtn.Click += Applybtn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(133, 24);
            label6.Name = "label6";
            label6.Size = new Size(195, 19);
            label6.TabIndex = 53;
            label6.Text = "Input return date and remarks";
            // 
            // ucBorrows_Returns
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Honeydew;
            Controls.Add(EditPanel);
            Controls.Add(editbtn);
            Controls.Add(Addbtn);
            Controls.Add(ISBNbox);
            Controls.Add(Studentidnobox);
            Controls.Add(BorrowRecordView);
            Controls.Add(Borrowdatepicker);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ucBorrows_Returns";
            Size = new Size(1025, 611);
            Load += ucBorrows_Returns_Load;
            ((System.ComponentModel.ISupportInitialize)BorrowRecordView).EndInit();
            EditPanel.ResumeLayout(false);
            EditPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Remarksbox;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private DateTimePicker Borrowdatepicker;
        private DataGridView BorrowRecordView;
        private ComboBox Studentidnobox;
        private ComboBox ISBNbox;
        private Label label3;
        private DateTimePicker Returndatepicker;
        private Button Addbtn;
        private Button editbtn;
        private Panel EditPanel;
        private Button Cancelbtn;
        private Button Applybtn;
        private Label label6;
    }
}
