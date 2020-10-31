using System;
using System.Linq;

namespace Codeforce1426A
{
    class Program
    {
        static void Main(string[] args)
        {
            var testcase = Convert.ToInt32(Console.ReadLine());


            for(int i=0;i<testcase;i++)
            {
                var b = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                double x = b[0];
                double n = b[1];

                double result = 1;

                if (x <= 2)
                    Console.WriteLine(result);
                else
                {

                    var f = x - 2;
                    double d = f / n;

                    result = Math.Ceiling(d)+1;

                    Console.WriteLine($"{result.ToString("0") }");



                }

            }



        }
    }
}
