using System;
using System.Collections.Generic;
using System.Text;

namespace CF14211A
{
   public  class Class3:Class1
    {

        public int roll { get; set; }

        public override double discount()
        {
            return price * 50 / 100;

        }


        public void sum(string s1,string s2)
        {
            var s = string.Concat(s1, s2);

            Console.WriteLine($"the sum of two string is {s}");
        }


    }
}
