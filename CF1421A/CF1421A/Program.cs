using System;
using System.Dynamic;
using System.Linq;

namespace CF1421A
{
    class Program
    {
       

        static void Main(string[] args)
        {



            var testcase = Convert.ToInt32(Console.ReadLine());
            for(var i=0;i<testcase;i++)
            {
                var arr = Console.ReadLine().Split(' ').Select(double.Parse).ToArray();

                var a = arr[0];
                var b = arr[1];

                var r = Math.Abs(a - b);

                var result = Math.Ceiling(r / 10);
               Console.WriteLine(result);

         



            }

        }
        
    }
}
