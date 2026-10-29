using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G5FinalProject
{
    internal class Student
    {
        private String Studentid;
        public String STUDENTID { get => Studentid; set => Studentid = value; }

        //name section
        private String Firstname;
        private String Middlename;
        private String Lastname;
        private String Fullname;



        public String FIRSTNAME { get => Firstname; set => Firstname = value; }
        public String MIDDLENAME { get => Middlename; set => Middlename = value; }
        public String LASTNAME { get => Lastname; set => Lastname = value; }

        public String FULLNAME { get => Fullname; set => Fullname = value; }


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
        private String Landline;

        public String CONTACTNO { get => Contactno; set => Contactno = value; }
        public String EMAIL { get => Email; set => Email = value; }
        public String LANDLINE { get => Landline; set => Landline = value; }


        //parents section prolly should include a selection if 1 guardian or 2 guardians
        private String G1name;
        private String G1Contactno;
        private String G1Email;
        private String G1Landline;
        public String G1NAME { get => G1name; set => G1name = value; }
        public String G1CONTACTNO { get => G1Contactno; set => G1Contactno = value; }
        public String G1EMAIL { get => G1Email; set => G1Email = value; }
        public String G1LANDLINE { get => G1Landline; set => G1Landline = value; }



        private String G2name;
        private String G2Contactno;
        private String G2Email;
        private String G2Landline;

        public String G2NAME { get => G2name; set => G2name = value; }
        public String G2CONTACTNO { get => G2Contactno; set => G2Contactno = value; }
        public String G2EMAIL { get => G2Email; set => G2Email = value; }
        public String G2LANDLINE { get => G2Landline; set => G2Landline = value; }

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
            Studentid = "";
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
            Landline = "";
            G1name = "";
            G1Contactno = "";
            G1Email = "";
            G1Landline = "";
            G2name = "";
            G2Contactno = "";
            G2Email = "";
            G2Landline = "";



        }


        public Student(String studentid, String firstname, String middlename, String lastname, String houseno, String street, String city, String province, String zipcode, String contactno, String email, String landline, String g1name, String g1Contactno, String g1Email, String g1Landline)
        {
            Studentid = studentid;
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
            Landline = landline;
            G1name = g1name;
            G1Contactno = g1Contactno;
            G1Email = g1Email;
            G1Landline = g1Landline;
            
        }

        public Student(String studentid, String firstname, String middlename, String lastname, String houseno, String street, String city, String province, String zipcode, String contactno, String email, String landline, String g1name, String g1Contactno, String g1Email, String g1Landline, String g2name, String g2Contactno, String g2Email, String g2Landline)
        {
            Studentid = studentid;
            Firstname = firstname;
            Middlename = middlename;
            Fullname = firstname + " " + middlename + " " + lastname;
            Lastname = lastname;
            Houseno = houseno;
            Street = street;
           
            City = city;
            Province = province;
            Zipcode = zipcode;
            Contactno = contactno;
            Email = email;
            Landline = landline;
            G1name = g1name;
            G1Contactno = g1Contactno;
            G1Email = g1Email;
            G1Landline = g1Landline;
            G2name = g2name;
            G2Contactno = g2Contactno;
            G2Email = g2Email;
            G2Landline = g2Landline;
        }


    }
}