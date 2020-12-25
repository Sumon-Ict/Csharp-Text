using System;

namespace Structure
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Person p = new Person();
            p.name = "summon";
            p.weight = 23.90;
            p.age = 123;

            Console.WriteLine($"the name of student is {p.name}");
            Console.WriteLine($"the weight of student is {p.weight}");
            Console.WriteLine($"the age is {p.age}");*/

            address A = new address();
            A.roll = 890;
            A.p.name = "sumon";  //nested structure example

            A.p.weight = 67;
            A.p.age = 678;

            Console.WriteLine($"name :{A.p.name}");
            Console.WriteLine($"roll: {A.roll}");


        }
    }
}
