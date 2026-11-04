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
        private List<Student> studentList = new List<Student>();
        public ucStudents()
        {
            InitializeComponent();
        }

        private void ucStudents_Load(object sender, EventArgs e)
        {

        }

        private void Addstudentbtn_Click(object sender, EventArgs e)
        {

            //putangina haba
            //studentList.Add(new Student(Studidnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text,
                //Housenobox.Text, Streetbox.Text, Citybox.Text, Provincebox.Text,
                //Zipcodebox.Text, Contactnobox.Text, Emailbox.Text, Landlinebox.Text));



            try
            {
                bool fullyFilled = !string.IsNullOrWhiteSpace(Studidnobox.Text) && !string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) &&
                   !string.IsNullOrWhiteSpace(Housenobox.Text) && !string.IsNullOrWhiteSpace(Streetbox.Text) && !string.IsNullOrWhiteSpace(Citybox.Text) &&
                   !string.IsNullOrWhiteSpace(Provincebox.Text) && !string.IsNullOrWhiteSpace(Zipcodebox.Text) && !string.IsNullOrWhiteSpace(Contactnobox.Text) &&
                   !string.IsNullOrWhiteSpace(Emailbox.Text) && !string.IsNullOrWhiteSpace(Landlinebox.Text)
                   ;
                bool goodFormat = Regex.IsMatch(Studidnobox.Text.Trim(), @"^\d+$")
               && Regex.IsMatch(Firstnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Middlenamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Lastnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
              && Regex.IsMatch(Housenobox.Text.Trim(), @"^[A-Za-z0-9\s\-.]+$") // Allows dots and numbers
               && Regex.IsMatch(Streetbox.Text.Trim(), @"^[A-Za-z0-9\s\-.]+$")// Allows dots and numbers
               && Regex.IsMatch(Citybox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
                && Regex.IsMatch(Provincebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
            && Regex.IsMatch(Zipcodebox.Text.Trim(), @"^\d{4}$") // 4 digit zip code
                && Regex.IsMatch(Contactnobox.Text.Trim(), @"^0\d{10}$") //typical phone num
            && Regex.IsMatch(Emailbox.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$")//email 
             && Regex.IsMatch(Landlinebox.Text.Trim(), @"^(?i:n/a)|^(\d{2,3}-)?\d{7,8}$");// can be n/a or 7-8 numbers

                if (fullyFilled && goodFormat)
                {
                    studentList.Add(new Student(Studidnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text,
                 Housenobox.Text, Streetbox.Text, Citybox.Text, Provincebox.Text,
                 Zipcodebox.Text, Contactnobox.Text, Emailbox.Text, Landlinebox.Text));
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
            catch (Exception)
            {
                MessageBox.Show("An error occured");
                return;
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //textBox1.Text
            Studentlistview.DataSource = null;
            List<Student> filtered = new List<Student>();
            for (int i = studentList.Count() - 1; i >= 0; i--)
            {
                if (studentList[i].STUDENTID.Contains(textBox1.Text) || studentList[i].FULLNAME.Contains(textBox1.Text))
                {
                    filtered.Add(studentList[i]);
                }

            }
            Studentlistview.DataSource = filtered;

        }
    }
}
