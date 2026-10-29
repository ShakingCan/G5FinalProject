using System;
using System.Collections.Generic;
using System.Text;

namespace G5FinalProject
{
    internal class Books
    {
        private String Title;
        private String Briefdescription;
        private String ISBN;
        private String Category;
        private String Author;
        private int Availablecopies;
        private String Status;

        public String TITLE { get => Title; set => Title = value; }
        public String BRIEFDESCRIPTION { get => Briefdescription; set => Briefdescription = value; }
        public String ISBN1 { get => ISBN; set => ISBN = value; }
        public String CATEGORY { get => Category; set => Category = value; }
        public String AUTHOR { get => Author; set => Author = value; }
        public int AVAILABLECOPIES { get => Availablecopies; set => Availablecopies = value; }
        public String STATUS { get => Status; set => Status = value; }



    }
}
