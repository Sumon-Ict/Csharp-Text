using System;
using System.Linq;

namespace Codeforce
{
    class Program
    {
        static void Main(string[] args)
        {

            var testcase = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<testcase;i++)
            {
                var b = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


                var n = b[0];
                var m = b[1];

                var a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
               

                



                if (a.Sum() == m)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");



            }

           


        }
    }
}
