using System;
using System.Collections.Generic;
using System.Text;

namespace G5FinalProject
{
    internal class Author
    {
        private int AuthorIDNo;
        private String Firstname;
        private String Middlename;
        private String Lastname;
        private String Dateofbirth;
        private String Gender;
        private String Fullname;

        public int AUTHORIDNO { get => AuthorIDNo; set => AuthorIDNo = value; }
        public String FIRSTNAME { get => Firstname; set => Firstname = value; }
        public String MIDDLENAME { get => Middlename; set => Middlename = value; }
        public String LASTNAME { get => Lastname; set => Lastname = value; }
        public String FULLNAME { get => Fullname; set => Fullname = value; }
        public String DATEOFBIRTH { get => Dateofbirth; set => Dateofbirth = value; }
        public String GENDER { get => Gender; set => Gender = value; }



        public Author()
        {
            AUTHORIDNO = 0;
            FIRSTNAME = "";
            MIDDLENAME = "";
            LASTNAME = "";
            DATEOFBIRTH = "";
            GENDER = "";
        }

        public Author(int authorid, String fullname, String dateofbirth, String gender)
        {
            AUTHORIDNO = authorid;
            FULLNAME = fullname;
            DATEOFBIRTH = dateofbirth;
            GENDER = gender;
           
        }

        public Author( String firstname, String middlename, String lastname, String dateofbirth, String gender)
        {
            
            FIRSTNAME = firstname;
            MIDDLENAME = middlename;
            LASTNAME = lastname;
            DATEOFBIRTH = dateofbirth;
            GENDER = gender;
            FULLNAME = firstname + " " + middlename + " " + lastname;
        }
        

        public void SearchAuthorByID(String authorid)
        {
            

            /*
             logic for searching a student by id 
             
             for (int i = list.size(); i<0; i--){
                if(list[i].AUTHORIDNO == authorid){
                //return or display author
                }
            }             
             */
        }
        public void SearchaAuthorByName(String authorname)
        {

            /*
          
            for(int i =list.size(); i<0; i--){
            if(list[i].FIRSTNAME == Studentname ||list[i].MIDDENAME == Studentname||list[i].LASTNAME == Studentname||list[i].FULLNAME == Studentname){
            //return or display author

            }
            }           
             */
        }

    }
}
