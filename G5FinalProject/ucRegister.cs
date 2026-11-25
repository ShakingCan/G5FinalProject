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
    public partial class ucRegister : UserControl
    {
        public ucRegister()
        {
            InitializeComponent();
        }

        private void Registerbtn_Click(object sender, EventArgs e)
        {
            bool filled = !string.IsNullOrWhiteSpace(Usernamebox.Text) && !string.IsNullOrWhiteSpace(Passwordbox.Text);
            bool valid = Regex.IsMatch(Usernamebox.Text, @"^(?=.*[a-zA-Z])[a-zA-Z0-9_]{12,}$") && Regex.IsMatch(Passwordbox.Text, @"^(?=.*[a-zA-Z])[a-zA-Z0-9_]{12,}$");

            if (filled && valid)
            {
                string AddQuery = @"INSERT INTO UsersTable (Username, Password)
                    VALUES (@Username, @Password);   ";
                using (SqlConnection conn = new SqlConnection(DBConnection.connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", Usernamebox.Text);
                        cmd.Parameters.AddWithValue("@Password", Passwordbox.Text);
                        cmd.ExecuteNonQuery();
                    }
                    conn.Close();
                    MessageBox.Show("Register Successful");
                    this.Visible = false;
                }
            }


        }

       
    }
}
