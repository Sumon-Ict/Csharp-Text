using System;
using System.Collections.Generic;
using System.Text;

namespace Practise
{
    public class person
    {

        private string name;
        public double weight;
        public int age;

        public double height;


        public string Name { get; set; }


        public void result()
        {
            var r = weight * height;
            Console.WriteLine($"the multiplicatin of the height and weight is {r}");

        }

        public void result(double a,double b)
        {
            var r = a * b;
            Console.WriteLine($"the multiplication od the two number is {r}");

        }

        public void result(double a, int b)
        {
            var r = a * b;
            Console.WriteLine($"the multiplication of the two number is {r}");

        }
        public void result(string s,string s2)
        {
            var r = string.Concat(s, s2);
            Console.WriteLine($"the concatanatoin of the two string is {r}");

        }






    }



}
