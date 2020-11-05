using System;

namespace PractiseProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            person p1 = new person();
            p1.name = "sumon";
            p1.age = 123;
            p1.weight = 23.45;
            p1.gender = "male";
            p1.result();

            person p2 = new person();
            p2.name = "modina";
            p2.weight = 45.45;
            p2.age = 23;
            p2.gender = "female";
            Console.WriteLine(p2.name);

            p2.result();


            uint b = 0b_10000_1111;
            uint t = ~b;
            Console.WriteLine(Convert.ToString(t, toBase: 2));


            int d;
            Console.WriteLine("enterr the day number");
             d = Convert.ToInt32(Console.ReadLine());

            string fr = result(d);

            Console.WriteLine(fr);

            static string result( int  day)
            {
                string str;
                switch (day)
                {
                    case 1:
                        str = "saturday";
                        break;
                    case 2:
                        str = "sunday";
                        break;
                    case 3:
                        str = "monday";
                        break;
                    default:
                        str = "input is wrong";
                        break;

                }
                return str;
            }





            }
}
}
