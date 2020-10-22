using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            person p = new person();

            p.Name = "sumon";
            p.weight = 12.34;
            p.height = 34.56;
            p.age = 12;

            p.result("sumon", "suojm");

            p.result(123.34, 45);
            p.result(34.56, 67.8);


            p.result();



        }
    }
}
