using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
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
            studentList.Add(new Student( Studidnobox.Text, Firstnamebox.Text, Middlenamebox.Text, Lastnamebox.Text,
                Housenobox.Text, Streetbox.Text, Citybox.Text, Provincebox.Text,
                Zipcodebox.Text,Contactnobox.Text, Emailbox.Text, Landlinebox.Text));

             bool fullyFilled = !string.IsNullOrWhiteSpace(Studidnobox.Text) && !string.IsNullOrWhiteSpace(Firstnamebox.Text) && !string.IsNullOrWhiteSpace(Middlenamebox.Text) && !string.IsNullOrWhiteSpace(Lastnamebox.Text) &&
               !string.IsNullOrWhiteSpace(Housenobox.Text) && !string.IsNullOrWhiteSpace(Streetbox.Text) && !string.IsNullOrWhiteSpace(Citybox.Text) &&
               !string.IsNullOrWhiteSpace(Provincebox.Text) && !string.IsNullOrWhiteSpace(Zipcodebox.Text) && !string.IsNullOrWhiteSpace(Contactnobox.Text) &&
               !string.IsNullOrWhiteSpace(Emailbox.Text) && !string.IsNullOrWhiteSpace(Landlinebox.Text) ;


        }
    }
}
