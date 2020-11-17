using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceandclass
{
    public class Doel : Ianimal
    {
        public string name { get; set; }

        public int age { get; set; }
        public int height { get; set; }



        public void color()
        {
            Console.WriteLine("the color is red");

        }

        public double sum(int c,int d)
        {
            return c+ d;
        }


    }
}
