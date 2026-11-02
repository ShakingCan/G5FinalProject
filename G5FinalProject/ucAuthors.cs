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
                //dissect this later cuz bugging
                bool goodFormat = Regex.IsMatch(@"[\d]", Authoridnobox.Text)
    && Regex.IsMatch(@"^\S+( \S+){0,2}$", Firstnamebox.Text)
    && Regex.IsMatch(@"^\S+( \S+){0,2}$", Middlenamebox.Text)
    && Regex.IsMatch(@"^\S+( \S+){0,2}$", Lastnamebox.Text);
                //bool goodFormat = Regex.IsMatch("^\\d+$",Authoridnobox.Text)&& Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Firstnamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Middlenamebox.Text) && Regex.IsMatch("^[A-Za-z]+(?:['-][A-Za-z]+)*(?: [A-Za-z]+(?:['-][A-Za-z]+)*){0,2}$", Lastnamebox.Text);
                bool fullyFilled = !string.IsNullOrWhiteSpace(Authoridnobox.Text)&& !string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) && !string.IsNullOrWhiteSpace(Genderbox.Text) && Dateofbirthpicker.Value< DateTime.Today;
                if (fullyFilled && goodFormat)
                {
                    authorList.Add(new Author(Authoridnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text, Genderbox.Text, Dateofbirthpicker.Value.ToString("yyyy-MM-dd")));
                    //Console.WriteLine("Author successfully added to the list");
                    MessageBox.Show("Author successfully added to the list");
                }
                else {
                    //Console.WriteLine("Please fill up all the fields");
                    MessageBox.Show("Please fill up all the fields correctly");
                    if(!goodFormat)
                        MessageBox.Show("tite");
                    else if(!fullyFilled)
                        MessageBox.Show("burat");


                }
                






            }       
             catch (Exception)
            { 
                
              
            
            
            
            
            }



        }
    }
}
