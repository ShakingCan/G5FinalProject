using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace G5FinalProject
{
    internal class BorrowAndReturn
    {
        private String Studentidno;
        private String Borrowdate;
        private String Returndate;
        private String Remarksorcomments;
        private String Isbn;


        public String STUDENTIDNO { get => Studentidno; set => Studentidno = value; }
        public String BORROWDATE { get => Borrowdate; set => Borrowdate = value; }
        public String RETURNDATE { get => Returndate; set => Returndate = value; }
        public String REMARKSORCOMMENTS { get => Remarksorcomments; set => Remarksorcomments = value; }
        public String ISBN { get => Isbn; set => Isbn = value; }

        public BorrowAndReturn()
        {

            Studentidno = "";
            Borrowdate = "";
            Returndate = "";
            Remarksorcomments = "";
            Isbn = "";

        }

        public BorrowAndReturn(String studentidno, String borrowdate, String returndate, String remarksorcomments, String isbn)
        {
            Studentidno = studentidno;
            Borrowdate = borrowdate;
            Returndate = returndate;
            Remarksorcomments = remarksorcomments;
            Isbn = isbn;


        }


    }
}
