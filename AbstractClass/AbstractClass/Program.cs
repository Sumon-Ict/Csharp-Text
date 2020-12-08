using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Student s = new Student(34.90,"sumon",89);

            Student s3 = new Student(123, "sujon", 23, 90.87);

            Student s4 = new Student();
            s4.name = "suvo";
            s4.age = 56;
            s4.weight = 100;
            s4.workhour = 200;

            var res = s3.mul();
            Console.WriteLine(res);


            Console.WriteLine(s.name);
            var result = s.mul();

            Console.WriteLine(result);


           var stduentname = s.detail();

            Console.WriteLine(stduentname);

           var s2= s.address("bogra");

            Console.WriteLine(s2);

            Console.WriteLine(s.workhour);

            var t = s.salary();
            Console.WriteLine(t);

            var pro = new product[5];

            var b1 = new Book();
            b1.productname = "bangla";
            b1.price = 500;
            b1.author = "chamok hasan";
            b1.bookagent = "boi ghor ";
            pro[0] = b1;

            var b2 = new Book();
            b2.productname = "english";
            b2.price = 500;
            b2.author = "ragib hasan";
            b2.bookagent = "boi somabes";
            pro[1] = b2;

            var elect1 = new electronics();
            elect1.productname = "computer";
            elect1.price = 500;
            elect1.Brandname = "HP";
            elect1.warranty = 12;

            pro[2] = elect1;

            var elect2 = new electronics();
            elect2.productname = "printer";
            elect2.price = 500;
            elect2.Brandname = "cannon";
            elect2.warranty = 34;

            var p = new product();
            p.productname = "bycyale";
            p.price = 500;


        }

        static void print(product p)
        {
            if(p is product)
            {
                var Prod = p as product;

                Console.WriteLine(Prod.productname);
                Console.WriteLine(Prod.price);

            }
           else if(p is Book)
            {
                var book = p as Book;

                Console.WriteLine(book.productname);
                Console.WriteLine(book.price);
                Console.WriteLine(book.bookagent);
                Console.WriteLine(book.bookagent);

            }
            else if(p is electronics)
            {
                var E = p as electronics;
                Console.WriteLine(E.productname);
                Console.WriteLine(E.price);
                Console.WriteLine(E.Brandname);
                Console.WriteLine(E.warranty);


            }
        }

    }
}
