using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace G5FinalProject
{
    public partial class ucBorrows_Returns : UserControl
    {
        string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";

        private List<int> ISBN = new List<int>();
        private List<int> ID = new List<int>();
        DateTime bd;
        public void LoadStudentsID()
        {
            string loadQuery = @"SELECT StudentID FROM Students;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ID = dt.AsEnumerable()
                    .Select(row => row.Field<int>("StudentID"))
                    .ToList();


                }
                conn.Close();
            }

        }
        public void LoadBooksISBN()
        {
            string loadQuery = @"SELECT ISBN FROM Books;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    ISBN = dt.AsEnumerable()
                     .Select(row => row.Field<int>("ISBN"))
                     .ToList();


                }
                conn.Close();
            }

        }

        public void refreshList()
        {
            foreach (int id in ID)
            {
                Studentidnobox.Items.Add(id);

            }
            foreach (int isbn in ISBN)
            {
                ISBNbox.Items.Add(isbn);

            }
        }


        public ucBorrows_Returns()
        {
            InitializeComponent();


        }

        private void ucBorrows_Returns_Load(object sender, EventArgs e)
        {
            refreshList();
            LoadBooksISBN();
            LoadStudentsID();


        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            bool valid = Borrowdatepicker.Value.Date >= DateTime.Today && !string.IsNullOrEmpty(Studentidnobox.Text) && !string.IsNullOrEmpty(ISBNbox.Text);

            if (!valid)
            {
                MessageBox.Show("Please fill in all fields");
                return;
            }


            string AddQuery = @"INSERT INTO BorrowsReturns (ISBN , StudentID , BorrowDate )
                        VALUES (@ISBN,@StudentID , @BorrowDate);   ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                {



                    cmd.Parameters.AddWithValue("@ISBN", int.Parse(ISBNbox.Text));
                    cmd.Parameters.AddWithValue("@StudentID", int.Parse(Studentidnobox.Text));
                    cmd.Parameters.AddWithValue("@BorrowDate", Borrowdatepicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

        }
        //I will stop here and return tomorrow
        private void editbtn_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = true;

        }

        private void Applybtn_Click(object sender, EventArgs e)
        {
            if (BorrowRecordView.CurrentRow != null && BorrowRecordView.CurrentRow.Cells["BorrowDate"].Value != DBNull.Value)
            {

                bd = Convert.ToDateTime(BorrowRecordView.CurrentRow.Cells["BorrowDate"].Value).Date;
            }
            bool valid = Returndatepicker.Value.Date >= bd;

            if (!valid)
            {
                MessageBox.Show("Select an appropriate date");
                return;
            }


            string AddQuery = @"INSERT INTO BorrowsReturns (ReturnDate ,Remarks )
                        VALUES (@ReturnDate,@Remarks);   ";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                {



                    cmd.Parameters.AddWithValue("@ReturnDate", Returndatepicker.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Remarks", Remarksbox.Text);


                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }




        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
        }
    }
}

