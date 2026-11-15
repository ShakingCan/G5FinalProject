using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace G5FinalProject
{
    internal class BorrowAndReturn
    {
        private int Studentidno;
        private String Borrowdate;
        private String Returndate;
        private String Remarksorcomments;
        private int Isbn;


        public int STUDENTIDNO { get => Studentidno; set => Studentidno = value; }
        public String BORROWDATE { get => Borrowdate; set => Borrowdate = value; }
        public String RETURNDATE { get => Returndate; set => Returndate = value; }
        public String REMARKSORCOMMENTS { get => Remarksorcomments; set => Remarksorcomments = value; }
        public int ISBN { get => Isbn; set => Isbn = value; }

        public BorrowAndReturn()
        {

            Studentidno = 0;
            Borrowdate = "";
            Returndate = "";
            Remarksorcomments = "";
            Isbn = 0;

        }

        public BorrowAndReturn(int isbn, int studentidno, String borrowdate, String returndate, String remarksorcomments)
        {
            Studentidno = studentidno;
            Borrowdate = borrowdate;
            Returndate = returndate;
            Remarksorcomments = remarksorcomments;
            Isbn = isbn;


        }


    }
}
