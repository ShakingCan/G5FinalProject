using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G5FinalProject
{
    internal class Student
    {
        //for searching purposes
        private String Address;
        public String ADDRESS { get => Address; set => Address = value; }



        private int Studentid;
        public int STUDENTID { get => Studentid; set => Studentid = value; }

        //name section
        private String Firstname;
        private String Middlename;
        private String Lastname;
        private String Fullname;
        private String Gender;
        private String Dateofbirth;



        public String FIRSTNAME { get => Firstname; set => Firstname = value; }
        public String MIDDLENAME { get => Middlename; set => Middlename = value; }
        public String LASTNAME { get => Lastname; set => Lastname = value; }

        public String FULLNAME { get => Fullname; set => Fullname = value; }
        public String GENDER { get => Gender; set => Gender = value; }
        public String DATEOFBIRTH { get => Dateofbirth; set => Dateofbirth = value; }


        //the address section
        private String Houseno;
        private String Street;
        private String City;
        private String Province;
        private String Zipcode;


        public String HOUSENO { get => Houseno; set => Houseno = value; }
        public String STREET { get => Street; set => Street = value; }
      
        public String CITY { get => City; set => City = value; }
        public String PROVINCE { get => Province; set => Province = value; }
        public String ZIPCODE { get => Zipcode; set => Zipcode = value; }


        //the contact section
        private String Contactno;
        private String Email;
  

        public String CONTACTNO { get => Contactno; set => Contactno = value; }
        public String EMAIL { get => Email; set => Email = value; }
    


        
        public void SearchStudentByID(String Studentid)
        {
            //there should be a list first before we get to implement this but the logic can be laid out

            /*
             logic for searching a student by id 
             
             for (int i = list.size(); i<0; i--){
                if(list[i].STUDENTID == Studentid){
                //return or display whatever
                }
            }             
             */
        }
        public void SearchStudentByName(String Studentname)
        {

            /*
           logic for searching a student by name
            for(int i =list.size(); i<0; i--){
            if(list[i].FIRSTNAME == Studentname ||list[i].MIDDENAME == Studentname||list[i].LASTNAME == Studentname||list[i].FULLNAME == Studentname){
            //return or display whatever

            }
            }           
             */
        }


        public Student()
        {
            Studentid = 0;
            Firstname = "";
            Middlename = "";
            Lastname = "";
            Houseno = "";
            Street = "";
            
            City = "";
            Province = "";
            Zipcode = "";
            Contactno = "";
            Email = "";
            
            



        }
        public Student(int id)
        {
            STUDENTID = id;
        }

        public Student(int studentid, String fullname, String address, String DOB, String gender, String contactno, String email) {

            STUDENTID = studentid;
            FULLNAME = fullname;
            
            ADDRESS  = address;
            DATEOFBIRTH = DOB;
            GENDER = gender;
            CONTACTNO = contactno;
            EMAIL = EMAIL;

        }
        public Student(String firstname, String middlename, String lastname, String houseno, String street, String city, String province, String zipcode, String contactno, String email)
        {
            
            Firstname = firstname;
            Middlename = middlename;
            Lastname = lastname;
            Fullname = firstname + " " + middlename + " " + lastname;
            Houseno = houseno;
            Street = street;
            
            City = city;
            Province = province;
            Zipcode = zipcode;
            Contactno = contactno;
            Email = email;
          
            
            
        }

      


    }
}