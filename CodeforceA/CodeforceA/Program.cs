using System;
using System.Linq;

namespace CodeforceA
{
    class Program
    {
        static void Main(string[] args)
        {
            var testcase = Convert.ToInt32(Console.ReadLine());
            for(int i=0;i<testcase;i++)
            {
                var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var value = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

                var m = array[1];

                if (value.Sum() == m)
                {
                    Console.WriteLine("YES");

                }
                else
                    Console.WriteLine("NO");


            }

        }
    }
}
