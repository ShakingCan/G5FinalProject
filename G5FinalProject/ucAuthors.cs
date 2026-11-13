using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace G5FinalProject
{

    public partial class ucAuthors : UserControl
    {
        static string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
        private List<Author> authorList = new List<Author>();
        private List<Author> proxySearch = new List<Author>();


        public void AdjustView()
        {
            Authorlistview.Columns["firstname"].Visible = false;
            Authorlistview.Columns["middlename"].Visible = false;
            Authorlistview.Columns["lastname"].Visible = false;
            Authorlistview.Columns["AUTHORIDNO"].HeaderText = "Author ID";
            Authorlistview.Columns["FULLNAME"].HeaderText = "Full Name";
            Authorlistview.Columns["DATEOFBIRTH"].HeaderText = "Date of Birth";
            Authorlistview.Columns["GENDER"].HeaderText = "Gender";
        }
        public void LoadData()
        {
            string loadQuery = @"SELECT * FROM Author;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    proxySearch = dt.AsEnumerable()
                     .Select(row => new Author
                       {
                     AUTHORIDNO = row.Field<int>("AuthorID"),
                      FULLNAME = row.Field<string>("AuthorName"),
                      DATEOFBIRTH = row.Field<DateTime?>("DOB")?.ToString("yyyy-MM-dd") ?? string.Empty,
                    GENDER = row.Field<string>("Gender")
                      })
                    .ToList();
                    Authorlistview.DataSource = proxySearch;

                }
                conn.Close();
            }

        }

        public ucAuthors()
        {
            InitializeComponent();
        }

        private void Addauthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //fixed goodshi
                bool goodFormat = Regex.IsMatch(Firstnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Middlenamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Lastnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$");
                //bool goodFormat = Regex.IsMatch("^\\d+$",Authoridnobox.Text)&& Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Firstnamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Middlenamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Lastnamebox.Text);
                bool fullyFilled =!string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) && !string.IsNullOrWhiteSpace(Genderbox.Text) && Dateofbirthpicker.Value < DateTime.Today;
                if (fullyFilled && goodFormat)
                {
                    authorList.Add(new Author( Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text, Dateofbirthpicker.Value.ToString("yyyy-MM-dd"), Genderbox.Text));


                    //Console.WriteLine("Author successfully added to the list");\
                    string AddQuery = @"INSERT INTO Author (AuthorName, DOB, Gender)
                    VALUES (@Name, @DOB, @Gender);   ";
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                        {
                           
                            string fullName = Firstnamebox.Text.Trim() + " "+Middlenamebox.Text.Trim() + " "+Lastnamebox.Text.Trim();

                            cmd.Parameters.AddWithValue("@Name", fullName);
                            cmd.Parameters.AddWithValue("@DOB", Dateofbirthpicker.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Gender", Genderbox.Text);

                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }




                    MessageBox.Show("Author successfully added to the list");
                }
                else
                {
                    //Console.WriteLine("Please fill up all the fields");
                    MessageBox.Show("Please fill up all the fields correctly");
                    if (!goodFormat)
                        MessageBox.Show("Some inputs were invalid");
                    else if (!fullyFilled)
                        MessageBox.Show("Some fields were left empty or the date wasn't properly set");


                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;

            }



        }

        private void ucAuthors_Load(object sender, EventArgs e)
        {
            LoadData();
            Authorlistview.DataSource = proxySearch;
            AdjustView();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorlistview.DataSource = null;
            Authorlistview.DataSource = proxySearch;
            AdjustView();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //Shall be modified and use database
             Authorlistview.DataSource = null;
            List<Author> filtered = new List<Author>();
            
            for (int i = proxySearch.Count() - 1; i >= 0; i--)
            {
                if (proxySearch[i].FULLNAME.Contains(textBox1.Text))
                {
                    filtered.Add(proxySearch[i]);
                }

            }

            Authorlistview.DataSource = filtered;
            AdjustView();


        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            
        }
    }
}
