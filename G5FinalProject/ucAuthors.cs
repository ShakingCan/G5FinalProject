using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Text.RegularExpressions;


namespace G5FinalProject
{
    public partial class ucAuthors : UserControl
    {

        private List<Author> authorList = new List<Author>();


        public ucAuthors()
        {
            InitializeComponent();
        }

        private void Addauthorbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //fixed goodshi
                bool goodFormat = Regex.IsMatch(Authoridnobox.Text.Trim(), @"^\d+$")
               && Regex.IsMatch(Firstnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Middlenamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$")
               && Regex.IsMatch(Lastnamebox.Text.Trim(), @"^[A-Za-z]+( [A-Za-z]+){0,2}$");
                //bool goodFormat = Regex.IsMatch("^\\d+$",Authoridnobox.Text)&& Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Firstnamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Middlenamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Lastnamebox.Text);
                bool fullyFilled = !string.IsNullOrWhiteSpace(Authoridnobox.Text) && !string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) && !string.IsNullOrWhiteSpace(Genderbox.Text) && Dateofbirthpicker.Value < DateTime.Today;
                if (fullyFilled && goodFormat)
                {
                    authorList.Add(new Author(Authoridnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text, Dateofbirthpicker.Value.ToString("yyyy-MM-dd"), Genderbox.Text));
                    //Console.WriteLine("Author successfully added to the list");
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
            catch (Exception)
            {
                MessageBox.Show("An error occured");
                return;

            }



        }

        private void ucAuthors_Load(object sender, EventArgs e)
        {
            Authorlistview.DataSource = authorList;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorlistview.DataSource = null;
            Authorlistview.DataSource = authorList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            //textBox1.Text
            Authorlistview.DataSource = null;
            List<Author> filtered = new List<Author>();
            for (int i = authorList.Count() - 1; i >= 0; i--)
            {
                if (authorList[i].AUTHORIDNO.Contains(textBox1.Text) || authorList[i].FULLNAME.Contains(textBox1.Text))
                {
                    filtered.Add(authorList[i]);
                }

            }
            Authorlistview.DataSource = filtered;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
           
            
        }
    }
}
