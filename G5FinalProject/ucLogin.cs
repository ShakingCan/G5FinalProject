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
    public partial class ucLogin : UserControl
    {

        static string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
        public ucLogin()
        {
            InitializeComponent();
        }


        public void authorize()
        {

            string query = "SELECT COUNT(1) FROM UsersTable WHERE Username = @username AND Password = @password";

            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@username", System.Data.SqlDbType.VarChar, 50).Value = Usernamebox.Text;
                    cmd.Parameters.Add("@password", System.Data.SqlDbType.VarChar, 50).Value = Passwordbox.Text;

                    int matchCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (matchCount > 0)
                    {
                        MessageBox.Show("Login successful");
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                        return;
                    }
                }
            }





        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            authorize();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ucRegister c = new ucRegister();
            c.Visible = true;
        }
    }
}
