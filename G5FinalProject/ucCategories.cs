using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace G5FinalProject
{
    public partial class ucCategories : UserControl
    {
        static string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=LmsDB;Integrated Security=True;TrustServerCertificate=True";
        public ucCategories()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            string loadQuery = @"SELECT CONCAT('CAT-1', CategoryID) AS CategoryID, CategoryName, CategoryDesc FROM Category;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    category_data.DataSource = dt;

                }
                conn.Close();
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();

                string insertQuery = @"INSERT INTO Category (CategoryName, CategoryDesc)
                                       VALUES (@CategoryName, @CategoryDesc);";
                using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                {
                    try
                    {
                        // Required field validation
                        if (
                            string.IsNullOrWhiteSpace(Categorynamebox.Text) ||
                            string.IsNullOrWhiteSpace(Categorydescriptionbox.Text))
                    
                        {
                            MessageBox.Show("Please fill in all fields.", "Validation Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // SQL Execution
                        cmd.Parameters.AddWithValue("@CategoryName", Categorynamebox.Text.Trim());
                        cmd.Parameters.AddWithValue("@CategoryDesc", Categorydescriptionbox.Text.Trim());
                   

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Category Created!", "Successful",
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
    }
}
