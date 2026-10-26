using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace G5FinalProject
{
    internal class Student
    {
        private String Studentid;


        //name section
        private String Firstname;
        private String Middlename;
        private String Lastname;

        public String FIRSTNAME { get => Firstname; set => Firstname = value; }
        public String MIDDLENAME { get => Middlename; set => Middlename = value; }
        public String LASTNAME { get => Lastname; set => Lastname = value; }


        //the address section
        private String Houseno;
        private String Street;
        private String Municipality;
        private String City;
        private String Province;
        private String Zipcode;

        public String HOUSENO { get => Houseno; set => Houseno = value; }
        public String STREET { get => Street; set => Street = value; }
        public String MUNICIPALITY { get => Municipality; set => Municipality = value; }
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

        public void SearchStudent(String Studentid)
        {
            //there should be a list first before we get to implement this but the logic can be laid out

            /*
             logic for searching a student by id 
             
             for (int i = list.size(); i<0; i--){
                if(list[i].Studentid == Studentid){
                //return or display whatever
                }
            }             

            logic for searching a student by name
            for(int i =list.size(); i<0; i--){
            if(list[i].Studentname == firstname||list[i].Studentname == middlename||list[i].Studentname == lastname){
            //return or display whatever

            }
            }


             */
        }
       


    }


}
