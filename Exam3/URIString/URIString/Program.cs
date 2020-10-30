using System;
using System.Security.Cryptography.X509Certificates;

namespace URIString
{
    class Program
    {
        static void Main(string[] args)
        {

          
            var s1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(s1);

            Console.WriteLine("the integer number is {0}", s1);

            var v = Console.ReadLine().Split(' ');

            for(int i=0;i<v.Length;i++)
            {
                Console.WriteLine(v[i]);

            }

            var a = Convert.ToInt32(v[0]);
            var b = int.Parse(v[1]);

            Console.WriteLine($"the first value of string {a}");
            Console.WriteLine($"the second value of string is {b}");


            var C = new class1();
            var array = new class1[12];

            C.name = "sumon";
            C.price = 456.78;

            Console.WriteLine(C.name);
            Console.WriteLine(C.formate());



        }
   
    }
}
