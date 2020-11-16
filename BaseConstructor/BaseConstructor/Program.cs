using System;

namespace BaseConstructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Trank t = new Trank(12.2, 67, 89.98);

            Console.WriteLine(t.length);

            Console.WriteLine($"the area is {t.area()}");

            Trank t1 = new Trank(12, 3, 4, 1);

            Console.WriteLine(t1.Area());
            Console.WriteLine(t1.length);
            Trank t2 = new Trank("sumon", 23, 2, 3, 5);
            Console.WriteLine(t2.Area());
            Console.WriteLine(t2.name);

            Console.WriteLine(t2.length);


            t2.datails();




           















        }
    }
}
