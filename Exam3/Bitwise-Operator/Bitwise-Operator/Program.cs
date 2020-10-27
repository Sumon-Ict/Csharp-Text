using System;
using System.Security.Cryptography.X509Certificates;

namespace Bitwise_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var v = 32;
            var r = v >> 3;
            Console.WriteLine(r);

            var a = 0b_1000;
            var c = 0b_1111;

            var b = ~a;

            Console.WriteLine(Convert.ToString(value: b, toBase: 2));
            
            
            
           var r1 = a ^ c;
            Console.WriteLine(r1);


            Console.WriteLine(Convert.ToString(value: r1, toBase: 2));

            var r2 = a | c;
            Console.WriteLine(r2);
            Console.WriteLine(Convert.ToString(value: r2, toBase: 2));
            var r3 = a << 3;
            Console.WriteLine(r3);
            Console.WriteLine(Convert.ToString(value: r3, toBase: 2));

            var r4 = a >> 3;
            Console.WriteLine(r4);
            Console.WriteLine(Convert.ToString(value: r4, toBase: 2));

            var r5 = a & c;
            Console.WriteLine(r5);
            Console.WriteLine(Convert.ToString(value: r5, toBase: 2));

            uint d = 60;
            uint r6 = ~d;
            Console.WriteLine(r6);

            Console.WriteLine(Convert.ToString(value: r6, toBase: 2));


            var Batch = new batch1[5];

            var B = new batch1();
            B.name = "sumon";
            B.weight = 123.45;
            B.price = 500;

            Batch[0] = B;

            batch2 B2 = new batch2();
            B2.name = "sujo";
            B2.weight = 45.2;
            B2.age = 12;
            B2.price = 500;

            Batch[1] = B2;

            batch3 B3 = new batch3();
            B3.name = "karim";
            B3.weight = 782;
            B3.roll = 12356;
            B3.price = 500;

            Batch[3] = B3;

            print(B);
            print(B2);
            print(B3);


            static void print(batch1 p)
                {


                //Console.WriteLine(p.name);
                Console.WriteLine($"the name of student batch is {p.name}");

                Console.WriteLine($"the weight of student batch is {p.weight}");
                Console.WriteLine($"the discount of prince is {p.discount()}");

                Console.WriteLine(p.formte());

               



                if(p is batch2)
                {
                    var child = p as batch2;
                    //Console.WriteLine(child.age);
                    Console.WriteLine("the age of the student is {0}", child.age);

                }

                else if(p is batch3)
                {
                    Console.WriteLine(((batch3)p).roll);

                }

            }

           
            

        }
    }
}
