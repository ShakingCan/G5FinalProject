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

        private List<int> ISBN = new List<int>();
        private List<int> ID = new List<int>();

        private List<Books> bISBN = new List<Books>();
        private List<Student> sID = new List<Student>();

        private List<BorrowAndReturn> br = new List<BorrowAndReturn>();

        
        DateTime bd;

        public void loadMainData()
        {

            string loadQuery = @"SELECT * FROM BorrowsReturns;";
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    br = dt.AsEnumerable()
                     .Select(row => new BorrowAndReturn
                     {
                         ISBN = row.Field<int>("ISBN"),
                         STUDENTIDNO = row.Field<int>("StudentID"),
                         BORROWDATE = row.Field<DateTime?>("BorrowDate")?.ToString("yyyy-MM-dd") ?? string.Empty,
                         RETURNDATE = row.Field<DateTime?>("ReturnDate")?.ToString("yyyy-MM-dd") ?? string.Empty,
                        
                         REMARKSORCOMMENTS = row.Field<String>("Remarks")

                     })
                    .ToList();
                    BorrowRecordView.DataSource = br;

                }
                conn.Close();
            }

        }


        public void LoadStudentsID()
         {
             string loadID = @"SELECT StudentID FROM Students;";
             using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
             {
                 conn.Open();
                 using (SqlDataAdapter idapt = new SqlDataAdapter(loadID, conn))
                 {

                     DataTable dt = new DataTable();
                    idapt.Fill(dt);
                     sID = dt.AsEnumerable()
                          .Select(row => new Student
                          {
                              STUDENTID = row.Field<int>("StudentID"),
                              
                          })
                    .ToList();
                    ID = sID.Select(s => s.STUDENTID).ToList();
                  
                }
                 conn.Close();
             }

         } 
        public void LoadBooksISBN()
        {
            string loadISBN = @"SELECT ISBN FROM Books;";
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadISBN, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    bISBN = dt.AsEnumerable()
                       .Select(row => new Books
                       {
                           ISBN1 = row.Field<int>("ISBN")

                       })
                    .ToList();
                    ISBN = bISBN.Select(s => s.ISBN1).ToList();
                    
                }
                conn.Close();
            }

        }

       
        public void refreshList()
        {
            

            foreach (int id in ID)
            {
                Studentidnobox.Items.Add(id.ToString());

            }
            foreach (int isbn in ISBN)
            {
                ISBNbox.Items.Add(isbn.ToString());

            }
        }


        public ucBorrows_Returns()
        {
            InitializeComponent();


        }

        private void ucBorrows_Returns_Load(object sender, EventArgs e)
        {
            
            LoadBooksISBN();
            LoadStudentsID();
            refreshList();
            loadMainData();
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
            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                conn.Open();
              
                using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                {



                    cmd.Parameters.AddWithValue("@ISBN", int.Parse(ISBNbox.Text));
                    cmd.Parameters.AddWithValue("@StudentID", int.Parse(Studentidnobox.Text));
                    cmd.Parameters.AddWithValue("@BorrowDate", Borrowdatepicker.Value.ToString("yyyy-MM-dd"));

                    cmd.ExecuteNonQuery();
                }
                MessageBox.Show("Successfully  recorded");
                loadMainData();
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
            if (BorrowRecordView.CurrentRow == null)
            {
                MessageBox.Show("Please select a record first.");
                return;
            }

            if (BorrowRecordView.CurrentRow.Cells["BorrowDate"].Value != DBNull.Value)
            {
                bd = Convert.ToDateTime(BorrowRecordView.CurrentRow.Cells["BorrowDate"].Value).Date;
            }

            bool valid = Returndatepicker.Value.Date >= bd;

            if (!valid)
            {
                MessageBox.Show("Select an appropriate date");
                return;
            }

           
            int isbn = Convert.ToInt32(BorrowRecordView.CurrentRow.Cells["ISBN"].Value);
            int studentId = Convert.ToInt32(BorrowRecordView.CurrentRow.Cells["STUDENTIDNO"].Value);
            DateTime Borrowday = Convert.ToDateTime(BorrowRecordView.CurrentRow.Cells["BORROWDATE"].Value);


            string updateQuery = @"UPDATE BorrowsReturns 
                           SET ReturnDate = @ReturnDate, Remarks = @Remarks 
                           WHERE ISBN = @ISBN AND StudentID = @StudentID;";

            using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                   
                    cmd.Parameters.AddWithValue("@ReturnDate", Returndatepicker.Value.ToString("yyyy-MM-dd"));

                    cmd.Parameters.AddWithValue("@Remarks", string.IsNullOrWhiteSpace(Remarksbox.Text) ? "n/a" : Remarksbox.Text);

                    cmd.Parameters.AddWithValue("@BD", Borrowday);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@StudentID", studentId);

                    cmd.ExecuteNonQuery();
                }
                conn.Close();
            }

            MessageBox.Show("Successfully updated record");
            loadMainData();
            EditPanel.Visible = false;
        }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            EditPanel.Visible = false;
        }
    }
}

