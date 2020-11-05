using System;
using System.Collections;
using System.Reflection.Metadata;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {



            #region 
            person p6 = new person();
                p6.name = "sobuj";
            p6.weight = 90;
            p6.Roll = -12;

            Console.WriteLine(p6.Roll);


            student s1 = new student();
            s1.name = "sarafat";
            s1.weight = 78;
            s1.Roll = 10;
            s1.age = 20;
            
            var re = p6.multiply();

            Console.WriteLine($"the multipy result is {re}");

            var re1 = s1.multiply();

            Console.WriteLine($"the s1 multiply result is {re1}");


            student s2 = new student("rakib", 78, 12, 100);


            Console.WriteLine(s2.multiply());

            person p3 = new person("rahim", 78.90, -12);
            Console.WriteLine(p3.Roll);

            person p2 = new person("sumon", 67.9, 12);

            Console.WriteLine(p2.Roll);


            uint b = 0b_1000_1111;
            uint r = ~b;

            Console.WriteLine($"the result is {Convert.ToString(value: r, toBase: 2)}");
            uint k= 0b_0000_1111_0000_1111_0000_1111_0000_1100;

            uint d = ~k;
            Console.WriteLine($"the result is {Convert.ToString(d, toBase: 2)}");
            int i = 0b00001111;
            int j = ~i;
            Console.WriteLine($"the 1 complement is {Convert.ToString(j, toBase: 2)}");


          //  Parameter method

            static void mymethod(string s1,string s2,string  s3)
            {
                Console.WriteLine($"the string name is {s3}");

            }


            mymethod(s3: "sumon", s1: "sujon", s2: "parvej");

            /*
            var personarray = new person[5];

            person p1 = new person();
            p1.name = Console.ReadLine();
            p1.weight = Convert.ToDouble(Console.ReadLine());
            p1.Roll = Convert.ToInt32(Console.ReadLine());

            personarray[0] = p1;

            person p2 = new person("sumon", 67.9, 12);

            personarray[1] = p2;


            person p3 = new person("rahim", 78.90, -12);

            personarray[2] = p3;

            person p4 = new person();
            p4.name = Console.ReadLine();
            p4.weight = Convert.ToDouble(Console.ReadLine());
            p4.Roll = Convert.ToInt32(Console.ReadLine());

            personarray[3] = p4;

            person p5 = new person(Convert.ToString(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

            personarray[4] = p5;


            for(int i=0;i<personarray.Length;i++)
            {
                print(personarray[i]);

            }



            static void print(person p)
            {
                Console.WriteLine($"the name is {p.name}");
                Console.WriteLine($"the weight is {p.weight}");
                Console.WriteLine($"the roll  is {p.Roll}");


            }*/




        }
    }
}
