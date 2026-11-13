using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace G5FinalProject
{
    public partial class ucBooks : UserControl
    {
        static string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
        public ucBooks()
        {
            InitializeComponent();
        }

        private void ucBooks_Load(object sender, EventArgs e)
        {
            LoadData();
            books_data.EnableHeadersVisualStyles = false;

            books_data.ColumnHeadersDefaultCellStyle.BackColor =
                Color.FromArgb(80, 107, 50);

            books_data.ColumnHeadersDefaultCellStyle.ForeColor =
                Color.White;

            books_data.ColumnHeadersDefaultCellStyle.SelectionBackColor =
                Color.FromArgb(80, 107, 50);

            books_data.ColumnHeadersDefaultCellStyle.SelectionForeColor =
                Color.MintCream;
        }

        public void LoadData()
        {
            string loadQuery = @"SELECT ISBN, Title, Description, Category, Author, AvailCopies AS 'Avl Copies', Status FROM Books;";
            string loadCategories = @"SELECT * FROM Category";
            string loadAuthors = @"SELECT * FROM Author";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    books_data.DataSource = dt;

                }
                using (SqlDataAdapter cda = new SqlDataAdapter(loadCategories, conn))
                {
                    DataTable cdt = new DataTable();
                    cda.Fill(cdt);
                    category_cbox.DataSource = cdt;
                    category_cbox.DisplayMember = "CategoryName";
                    category_cbox.ValueMember = "CategoryID";
                    category_cbox.SelectedIndex = -1;

                    if (category_cbox.SelectedIndex == -1)
                    {
                        category_cbox.Text = "Select category...";
                    }
                }
                using (SqlDataAdapter ada = new SqlDataAdapter(loadAuthors, conn))
                {
                    DataTable adt = new DataTable();
                    ada.Fill(adt);
                    author_cbox.DataSource = adt;
                    author_cbox.DisplayMember = "AuthorName";
                    author_cbox.ValueMember = "AuthorID";
                    author_cbox.SelectedIndex = -1;

                    if (author_cbox.SelectedIndex == -1)
                    {
                        author_cbox.Text = "Select author...";
                    }
                }
                conn.Close();
            }
            status_cbox.Items.Add("Good Condition");
            status_cbox.Items.Add("Damaged");



        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string insertQuery = @"INSERT INTO Books (Title, Description, ISBN, Category, Author, AvailCopies, Status) 
                                      VALUES (@Title, @Description, @ISBN, @Category, @Author, @AvailCopies, @Status);";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    try
                    {
                        // Required field validation
                        if (string.IsNullOrWhiteSpace(Titlebox.Text) ||
                            string.IsNullOrWhiteSpace(Descriptionbox.Text) ||
                            string.IsNullOrWhiteSpace(ISBNbox.Text) ||
                            string.IsNullOrWhiteSpace(category_cbox.Text) ||
                            string.IsNullOrWhiteSpace(author_cbox.Text) ||
                            string.IsNullOrWhiteSpace(Availablecopiesbox.Text) ||
                            string.IsNullOrWhiteSpace(status_cbox.Text))
                        {
                            MessageBox.Show("Please fill in all fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // ISBN validation (10 or 13 digits, allowing hyphens)
                        if (!Regex.IsMatch(ISBNbox.Text.Trim(),
                            @"^(?:\d{9}[\dXx]|\d{13}|\d{1,5}(?:-\d{1,7}){1,4})$"))
                        {
                            MessageBox.Show("Invalid ISBN format.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Available copies validation (whole numbers only)
                        if (!Regex.IsMatch(Availablecopiesbox.Text.Trim(), @"^\d+$"))
                        {
                            MessageBox.Show("Available copies must be a valid whole number.",
                                "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // SQL Execution
                        cmd.Parameters.AddWithValue("@Title", Titlebox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Description", Descriptionbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@ISBN", ISBNbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Category", category_cbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@Author", author_cbox.Text.Trim());
                        cmd.Parameters.AddWithValue("@AvailCopies", int.Parse(Availablecopiesbox.Text.Trim()));
                        cmd.Parameters.AddWithValue("@Status", status_cbox.Text.Trim());

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Book Created!", "Successful",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        conn.Close();
                        LoadData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message,
                            "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        if (conn.State == System.Data.ConnectionState.Open)
                            conn.Close();
                    }
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
