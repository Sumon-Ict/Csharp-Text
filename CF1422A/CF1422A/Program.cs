using System;
using System.Linq;

namespace CF1422A
{
    class Program
    {
        static void Main(string[] args)
        {
            var testcase = Convert.ToInt32(Console.ReadLine());

            for(int i=0;i<testcase;i++)
            {

                var array = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();

                var result = array.Sum() - 1;
                Console.WriteLine(result);
               


            }
            

        
        }
    }
}
