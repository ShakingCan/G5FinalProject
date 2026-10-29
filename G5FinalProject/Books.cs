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

        public Books()
        {
            TITLE = "";
            BRIEFDESCRIPTION = "";
            ISBN1 = "";
            CATEGORY = "";
            AUTHOR = "";
            AVAILABLECOPIES = 0;
            STATUS = "";
        }

        public Books(String title, String briefdescription, String isbn, String category, String author, int availablecopies, String status)
        {
                
            TITLE = title;
            BRIEFDESCRIPTION = briefdescription;
            ISBN1 = isbn;
            CATEGORY = category;
            AUTHOR = author;
            AVAILABLECOPIES = availablecopies;
            STATUS = status;
        }
        public void SearchByTitle(String title)
        {
            /*
           for (int i = List.Size(); i<0; i--){
            if(List[i].TITLE == title){
            //show book with that title
            }    
            }



            */
        }
        public void SearchByAuthor(String author)
        {
            /*
        for (int i = List.Size(); i<0; i--){
         if(List[i].AUTHOR == author){
         //show book with that auhotr
         }    
         }



         */
        }
        public void SearchByCategory(String categoruy)
        {
            /*
        for (int i = List.Size(); i<0; i--){
         if(List[i].CATEGORY == title){
         //show book with that category
         }    
         }



         */
        }
        public void SearchByISBN(String isbn)
        {
            /*
        for (int i = List.Size(); i<0; i--){
         if(List[i].ISBN == isbn){
         //show book with that isbn
         }    
         }



         */
        }
        public void SearchByStatus(String status)
        {
            /*
        for (int i = List.Size(); i<0; i--){
         if(List[i].STATUS == status){
         //show book with that status
         }    
         }



         */
        }



    }
}
