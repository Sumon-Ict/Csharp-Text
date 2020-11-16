using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var b1 = new Waterbottle(12, "red", "kannon", 34);

            Console.WriteLine(b1.color);

            var b2 = new Waterbottle(89, "Yellow");
            Console.WriteLine(b2.amount);

            var r = b2.mass();

            Console.WriteLine(r);

            var b3 = new Waterbottle(78, "red", "BRB", "sumon", 90);
            Console.WriteLine(b3.multiply());


            Console.WriteLine(b3.agentname);

            Console.WriteLine(b3.comapanyname);



            var b4 = new Juicebottle(12, "blue", "parvej",90);

            Console.WriteLine(b4.amount);

            Console.WriteLine(b4.manager);

            Console.WriteLine(b4.mass());

            Console.WriteLine(b4.multiply());
















        }
    }
}
