using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Student
{
    public class secondbatch : firstbatch
    {

        public int roll { get; set; }
        public override double discount()
        {
            return price * 50 / 100;

        }


        public void myfun(string s1,string s2)
        {

            var R = string.Concat(s1, s2);
            Console.WriteLine("the concatanatiom of two string is {0}", R);
        }

        public void myfun(double a,double b)
        {
            var r = a + b;
            Console.WriteLine("the sum of two value is {0}", r);
        }

        public void myfun(double a,long b)
        {
            var r = a * b;
            Console.WriteLine("the multiplication of two number is {0}", r);

        }
       

        public void myfun()
        {
            Console.WriteLine("this is my function");

        }


    }
}

