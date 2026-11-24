using System;
using System.Collections.Generic;
using System.Text;

namespace G5FinalProject
{
    internal class Books
    {
        private String Title;
        private String Briefdescription;
        private int ISBN;
        private String Category;
        private String Author;
        private int Availablecopies;
        private String Status;

        public String TITLE { get => Title; set => Title = value; }
        public String BRIEFDESCRIPTION { get => Briefdescription; set => Briefdescription = value; }
        public int ISBN1 { get => ISBN; set => ISBN = value; }
        public String CATEGORY { get => Category; set => Category = value; }
        public String AUTHOR { get => Author; set => Author = value; }
        public int AVAILABLECOPIES { get => Availablecopies; set => Availablecopies = value; }
        public String STATUS { get => Status; set => Status = value; }


       
        public Books()
        {
            TITLE = "";
            BRIEFDESCRIPTION = "";
            ISBN1 = 0;
            CATEGORY = "";
            AUTHOR = "";
            AVAILABLECOPIES = 0;
            STATUS = "";
        }
        public Books(int isbn)
        {
            ISBN1 = isbn;

        }


        public Books(String title, String briefdescription, int isbn, String category, String author, int availablecopies, String status)
        {
                
            TITLE = title;
            BRIEFDESCRIPTION = briefdescription;
            ISBN1 = isbn;
            CATEGORY = category;
            AUTHOR = author;
            AVAILABLECOPIES = availablecopies;
            STATUS = status;
        }
     


    }
}
