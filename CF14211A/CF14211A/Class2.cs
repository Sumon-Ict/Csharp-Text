using System;
using System.Collections.Generic;
using System.Text;

namespace CF14211A
{
    public class Class2 : Class1
    {

        public double age { get; set; }

        public override double discount()
        {
            return price * 30 / 100;

        }

        public void sum(double a,double b)
        {
            var result = a + b;

            Console.WriteLine($"the sum of two double value is {result}");


        }


   


    }
}
