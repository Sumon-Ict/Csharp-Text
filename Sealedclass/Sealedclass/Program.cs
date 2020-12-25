using System;

namespace Sealedclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person p = new Person();
            p.age = 12;
            p.name = "sumon";
            p.weight = 123;
            p.details();
            p.tostring();

            Console.WriteLine($"the weight :{p.weight}");

            Console.WriteLine($"the age :{p.age}");

        }
    }
}
