using System;
using System.Collections.Generic;
using System.Text;

namespace CF14211A
{
   public class Class1
    {

        public string name { get; set; }
        public string address { get; set; }

        internal double weight { get; set; }
        public double price { get; set; }


        public virtual double  discount()
        {
            return price*20/100;
        }


        public void sum(int a,int b)
        {
            var result = a + b;
            Console.WriteLine($"the sum of two integer value is {result} ");

        }

    }
}
