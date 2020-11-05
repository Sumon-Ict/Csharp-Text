using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
   public class student:person

    {


       
        public int age { get; set; }

        public student(string s1, double d, int r, int ag)
        {
            name = s1;
            weight = d;
            Roll = r;
            age = ag;
        }
       
        public student()
        {

        }
        public override double multiply()
        {
            return weight * age;

        }

    }
}
