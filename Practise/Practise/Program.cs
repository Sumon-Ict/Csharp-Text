using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");




           #region  method overloading
            /* person p = new person();

            p.Name = "sumon";
            p.weight = 12.34;
            p.height = 34.56;
            p.age = 12;

            p.result("sumon", "suojm");

            p.result(123.34, 45);
            p.result(34.56, 67.8);

            var a = 123;
            var b = 34;

            var r = a > b ? a : b;// ternary operator using 
            Console.WriteLine("the grather value is " + r);
            p.result(123, 45);

            p.result();
            p.result(345); */

            #endregion 


            electronics E = new electronics();

            E.name = "Camera";
            E.description = "this camera is imprtant for our happily life";
            E.price = 235.56;
            E.Author = "sumon";
            E.AuthorMother = "rumi begum";



            Console.WriteLine($"the discriptiomn of the thing is {E.description}");
            Console.WriteLine($"the author name is {E.Author}");
            Console.WriteLine($"the authormothe name is {E.AuthorMother}");

            var Product = new product[12];

            var abook = new book();
            abook.name = "bangla";
            abook.description = "rthis book is very interesting";
            abook.price = 123.45;
            abook.Author = "sumon";

            Product[0] = abook;



            var Et = new electronics();
            Et.name = "computer";

            Et.AuthorMother = "rumana";
            Et.price = 456.67;

            Product[1] = Et;
            Product[2] = new electronics();
            Console.WriteLine(((book)Product[0]).Author); // type casting from product into book class
            Console.WriteLine(((electronics)Product[1]).AuthorMother); // type casting from product into electronics 












        }
    }
}
