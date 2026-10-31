using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G5FinalProject
{
    public partial class MainForm : Form
    {
        //list for search features and updating in database

        private List<Student> studentList = new List<Student>();
        private List<Author> authorList = new List<Author>();
        private List<Books> BooksList = new List<Books>();
        private List<BorrowAndReturn> BorrowAndReturnList = new List<BorrowAndReturn>();
        private List<Category> CategoryList = new List<Category>();


        private bool isClicked;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ChangeBtnColor(Button btn)
        {
            isClicked = true;
            if (isClicked)
                btn.BackColor = Color.OliveDrab;
            //basta ganito

        }
        private void ResetBtnColor(Button btn1, Button btn2, Button btn3, Button btn4, Button btn5)
        {
            btn1.BackColor = Color.DarkOliveGreen;
            btn2.BackColor = Color.DarkOliveGreen;
            btn3.BackColor = Color.DarkOliveGreen;
            btn4.BackColor = Color.DarkOliveGreen;
            btn5.BackColor = Color.DarkOliveGreen;
            //My own logic so i brute forced it wallahi
        }

        private void LoadControl(UserControl control)
        {
            UCPanel.Controls.Clear();

            control.Dock = DockStyle.Fill;
            UCPanel.Controls.Add(control);
            control.BringToFront();
        }

        private void btn_books_Click(object sender, EventArgs e)
        {
            LoadControl(new ucBooks());
            ChangeBtnColor(btn_books);
            ResetBtnColor(btn_dashboard, btn_authors, btn_brrwsretrns, btn_students, btn_categories);

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            LoadControl(new ucDashboard());
            ChangeBtnColor(btn_dashboard);
            ResetBtnColor(btn_authors, btn_brrwsretrns, btn_students, btn_categories, btn_books);

        }

        private void btn_brrwsretrns_Click(object sender, EventArgs e)
        {
            LoadControl(new ucBorrows_Returns());
            ChangeBtnColor(btn_brrwsretrns);
            ResetBtnColor(btn_dashboard, btn_authors, btn_students, btn_categories, btn_books);

        }

        private void btn_categories_Click(object sender, EventArgs e)
        {
            LoadControl(new ucCategories());
            ChangeBtnColor(btn_categories);
            ResetBtnColor(btn_dashboard, btn_authors, btn_brrwsretrns, btn_students, btn_books);

        }

        private void btn_authors_Click(object sender, EventArgs e)
        {
            LoadControl(new ucAuthors());
            ChangeBtnColor(btn_authors);
            ResetBtnColor(btn_dashboard, btn_brrwsretrns, btn_students, btn_categories, btn_books);

        }

        private void btn_students_Click(object sender, EventArgs e)
        {
            LoadControl(new ucStudents());
            ChangeBtnColor(btn_students);
            ResetBtnColor(btn_dashboard, btn_authors, btn_brrwsretrns,btn_categories, btn_books);

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadControl(new ucDashboard());
            ChangeBtnColor(btn_dashboard);

        }
    }
}


