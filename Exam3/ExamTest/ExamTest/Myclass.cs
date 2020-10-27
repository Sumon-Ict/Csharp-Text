using System;
using System.Collections.Generic;
using System.Text;

namespace ExamTest
{
     public class Myclass
    {

        public string name { get; set; }

        public double weight { get; set; }
        public int age;



        public Myclass()
        {

        }

         public Myclass(string str,double d,int A)
        {

             name=str;
            weight=d;
             age=A;
        }

       


    }
}
