using System;
using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace ModelTest
{
    class Program
    {
        static void Main(string[] args)
        { 

            //number formating by D
            var v = 12347;
            Console.WriteLine(v.ToString("D", CultureInfo.CurrentCulture));
            Console.WriteLine(v.ToString("D9", CultureInfo.CurrentCulture));


            // number formating by F 
            var d = 134434.87;
            Console.WriteLine(d.ToString("F", CultureInfo.CurrentCulture));
            Console.WriteLine(d.ToString("F3", CultureInfo.CurrentCulture));
            Console.WriteLine(d.ToString("F3", CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(d.ToString("f0", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("f12", CultureInfo.InvariantCulture));


            // number formate by C 

            Console.WriteLine(d.ToString("C", CultureInfo.CurrentCulture));
           
            Console.WriteLine(d.ToString("C3"));
            Console.WriteLine("the string is {0}", d.ToString("C3"));

            Console.WriteLine("the value is {0:C2}", d);


            //number formate by P
            double b = .987;

            Console.WriteLine(b.ToString("p3", CultureInfo.CurrentCulture));

            Console.WriteLine(b.ToString("p", CultureInfo.CurrentCulture));
            Console.WriteLine(b.ToString("p", CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(b.ToString("P", CultureInfo.CreateSpecificCulture("hr-HR")));


            //number formting by E
            Console.WriteLine(d.ToString("E", CultureInfo.CurrentCulture));
            Console.WriteLine(d.ToString("E", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("e2", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("e3", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("E", CultureInfo.CreateSpecificCulture("fr-FR")));


            //number formating by G
            Console.WriteLine(d.ToString("G",CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("G2", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("g5", CultureInfo.InvariantCulture));

            //number formating by N
            Console.WriteLine(d.ToString("N", CultureInfo.InvariantCulture));
            Console.WriteLine(d.ToString("N2", CultureInfo.InvariantCulture));

            Console.WriteLine(d.ToString("N5", CultureInfo.InvariantCulture));
            var M =BigInteger.Pow(Int64.MaxValue, 2);

            Console.WriteLine(M.ToString("D"));
            int val = 2345;
            Console.WriteLine(val.ToString("X"));


            Test1 T = new Test1();
            T.pricevalue = 5000;
            T.productname = "computer";

            Test2 T2 = new Test2();
            T2.bookname = "bangla";
            T2.productname = "vaccine";
            T2.pricevalue = 5000;

            Test3 T3 = new Test3();
             T3.productname = "milk";
            T3.pricevalue = 5000;

            Console.WriteLine($"discount of the product is {T.discount()}");

            Console.WriteLine("discount of the book is {0}", T2.discount());

            Console.WriteLine("discount of the product is {0}", T3.discount());


        }
    }
}
