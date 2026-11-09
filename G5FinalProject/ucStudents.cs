using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace G5FinalProject
{
    public partial class ucStudents : UserControl
    {
        static string connString = "Data Source=DESKTOP-3UB02P4;Initial Catalog=LmsDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=\"SQL Server Management Studio\";Command Timeout=0";
        private List<Student> studentList = new List<Student>();
        private List<Student> proxySearch = new List<Student>();

        public void AdjustView()
        {
            Studentlistview.Columns["firstname"].Visible = false;
            Studentlistview.Columns["middlename"].Visible = false;
            Studentlistview.Columns["lastname"].Visible = false;
            Studentlistview.Columns["houseno"].Visible = false;
            Studentlistview.Columns["city"].Visible = false;
            Studentlistview.Columns["street"].Visible = false;
            Studentlistview.Columns["province"].Visible = false;
            Studentlistview.Columns["zipcode"].Visible = false;
            Studentlistview.Columns["STUDENTID"].HeaderText = "Student ID";
            Studentlistview.Columns["FULLNAME"].HeaderText = "Full Name";
            Studentlistview.Columns["DATEOFBIRTH"].HeaderText = "Date of Birth";
            Studentlistview.Columns["GENDER"].HeaderText = "Gender";
        }
        public void LoadData()
        {
            string loadQuery = @"SELECT * FROM Students;";
            using (SqlConnection conn = new SqlConnection(connString))
            {
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(loadQuery, conn))
                {

                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    proxySearch = dt.AsEnumerable()
                     .Select(row => new Student
                     {
                         STUDENTID = row.Field<int>("StudentID"),
                         FULLNAME = row.Field<string>("StudentName"),
                         ADDRESS = row.Field<string>("Address"),
                         DATEOFBIRTH = row.Field<DateTime?>("DOB")?.ToString("yyyy-MM-dd") ?? string.Empty,
                         GENDER = row.Field<string>("Gender"),
                         CONTACTNO = row.Field<string>("Contactno"),
                         EMAIL = row.Field<string>("Email")
                     })
                    .ToList();
                    Studentlistview.DataSource = proxySearch;

                }
                conn.Close();
            }

        }
        public ucStudents()
        {
            InitializeComponent();
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {
            LoadData();
            AdjustView();
        }

        private void Addstudentbtn_Click(object sender, EventArgs e)
        {

            //putangina haba
            //studentList.Add(new Student(Studidnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text,
            //Housenobox.Text, Streetbox.Text, Citybox.Text, Provincebox.Text,
            //Zipcodebox.Text, Contactnobox.Text, Emailbox.Text, Landlinebox.Text));



            try
            {
                bool fullyFilled = !string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) &&
                   !string.IsNullOrWhiteSpace(Housenobox.Text) && !string.IsNullOrWhiteSpace(Streetbox.Text) && !string.IsNullOrWhiteSpace(Citybox.Text) &&
                   !string.IsNullOrWhiteSpace(Provincebox.Text) && !string.IsNullOrWhiteSpace(Zipcodebox.Text) && !string.IsNullOrWhiteSpace(Contactnobox.Text)
                   ;
                bool goodFormat = Regex.IsMatch(Firstnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Middlenamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Lastnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
              && Regex.IsMatch(Housenobox.Text.Trim(), @"^[A-Za-z0-9\s\-.]+$") // Allows dots and numbers
               && Regex.IsMatch(Streetbox.Text.Trim(), @"^[A-Za-z0-9\s\-.]+$")// Allows dots and numbers
               && Regex.IsMatch(Citybox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
                && Regex.IsMatch(Provincebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
            && Regex.IsMatch(Zipcodebox.Text.Trim(), @"^\d{4}$") // 4 digit zip code
                && Regex.IsMatch(Contactnobox.Text.Trim(), @"^0\d{10}$") //typical phone num
            && Regex.IsMatch(Emailbox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")//email 
            ;

                if (fullyFilled && goodFormat)
                {
                    studentList.Add(new Student(Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text,
                 Housenobox.Text, Streetbox.Text, Citybox.Text, Provincebox.Text,
                 Zipcodebox.Text, Contactnobox.Text, Emailbox.Text));

                    string AddQuery = @"INSERT INTO Students (StudentName, Address, DOB ,Gender, ContactNo , Email  )
                        VALUES (@Name,@Address , @DOB, @Gender, @Contactno, @Email);   ";
                    using (SqlConnection conn = new SqlConnection(connString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(AddQuery, conn))
                        {

                            string fullName = Firstnamebox.Text.Trim() + " " + Middlenamebox.Text.Trim() + " " + Lastnamebox.Text.Trim();

                            cmd.Parameters.AddWithValue("@Name", fullName);
                            cmd.Parameters.AddWithValue("@DOB", dateTimePicker1.Value.ToString("yyyy-MM-dd"));
                            cmd.Parameters.AddWithValue("@Gender", Genderbox.Text);
                            cmd.Parameters.AddWithValue("@Address", Housenobox.Text.Trim() + " " + Streetbox.Text.Trim() + " " + Citybox.Text.Trim() + " " + Provincebox.Text.Trim() + " " + Zipcodebox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Contactno", Contactnobox.Text.Trim());
                            cmd.Parameters.AddWithValue("@Email", Emailbox.Text.Trim());



                            cmd.ExecuteNonQuery();
                        }
                        conn.Close();
                    }


                    MessageBox.Show("Student successfully added to the list");
                }
                else
                {
                    //Console.WriteLine("Please fill up all the fields");
                    MessageBox.Show("Please fill up all the fields correctly");
                    if (!goodFormat)
                        MessageBox.Show("Some inputs were invalid");
                    else if (!fullyFilled)
                        MessageBox.Show("Some fields were left empty");


                }





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //textBox1.Text
            Studentlistview.DataSource = null;
            List<Student> filtered = new List<Student>();
            for (int i = proxySearch.Count() - 1; i >= 0; i--)
            {
                if (proxySearch[i].FULLNAME.Contains(textBox1.Text))
                {
                    filtered.Add(proxySearch[i]);
                }

            }
            
            Studentlistview.DataSource = filtered;
            AdjustView();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Studentlistview.DataSource = null;
            Studentlistview.DataSource = proxySearch;
            AdjustView();
        }
    }
}
