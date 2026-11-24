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
    public partial class ucDashboard : UserControl
    {
        static string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
        private int count;
        private int recentCount;
        private List<Books> proxySearch = new List<Books>();
        public int GetCount()
        {
            return count;
        }

        public void SetCount(int value)
        {
            count = value;
        }
        public int GetRecentCount()
        {
            return count;
        }

        public void SetRecentCount(int value)
        {
            count = value;
        }

        public ucDashboard()
        {
            InitializeComponent();
        }

        private void ucDashboard_Load(object sender, EventArgs e)
        {
            LoadTotalBooks();
            LoadRecentBooksCount();
            LoadRecentBooksData();
        }


        public void LoadTotalBooks()
        {
            string loadQuery = @"SELECT COUNT(*) FROM Books;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(loadQuery, conn))
                {


                    var result = cmd.ExecuteScalar();
                    SetCount(Convert.ToInt32(result));
                    Totalbookscountlbl.Text = GetCount().ToString();



                }
                conn.Close();
            }

        }

        public void LoadRecentBooksData()
        {
            //string loadQuery = @"SELECT * FROM Books WHERE CAST(DateAdded AS DATE) >= CAST(GETDATE() AS DATE) - 7;";
            string loadQuery = @"SELECT * FROM Books WHERE CAST(DateAdded AS DATE) >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE));";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    proxySearch = dt.AsEnumerable()
                     .Select(row => new Books
                     {
                         
                         TITLE = row.Field<string>("Title"),
                         BRIEFDESCRIPTION = row.Field<string>("Description"),
                         CATEGORY = row.Field<string?>("Category"),
                         AUTHOR = row.Field<string>("Author"),
                         AVAILABLECOPIES = row.Field<int>("AvailableCopies"),
                         STATUS = row.Field<string>("Status")
                     })
                    .ToList();
                    Recentbooklist.DataSource = proxySearch;

                }
                conn.Close();
            }

        }


        public void LoadRecentBooksCount()
        {
            //string loadQuery = @"SELECT COUNT(*) FROM Books WHERE CAST(DateAdded AS DATE) >= CAST(GETDATE() AS DATE) - 7;";
            string loadQuery = @"SELECT COUNT(*) FROM Books WHERE CAST(DateAdded AS DATE) >= DATEADD(DAY, -7, CAST(GETDATE() AS DATE));";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(loadQuery, conn))
                {


                    var result = cmd.ExecuteScalar(); 
                    SetRecentCount(Convert.ToInt32(result));
                    recentlyaddedcount.Text = GetRecentCount().ToString();



                }
                conn.Close();
            }

        }

    }
}
