using System;

namespace Codeforce1433
{
    class Program
    {
        static void Main(string[] args)
        {

            var testcase = Convert.ToInt32(Console.ReadLine());

            for(var i=0;i<testcase;i++)
            {


                long result;
                var str = Console.ReadLine();


                int digit = (str[0]-'0') - 1;

               

                result = digit * 10;

               


                if (str.Length == 1)
                {
                    result = result + 1;

                }
                else if (str.Length == 2)
                {
                    result = result + 3;
                }
                else if (str.Length == 3)
                    result = result + 6;
                else
                    result = result + 10;

                Console.WriteLine(result);



            }
        }
    }
}
