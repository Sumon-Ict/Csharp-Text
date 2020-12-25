using System;
using System.IO;
using System.Linq.Expressions;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {


            /* try
             {
                 /*int a = 12;
                 int b = 0;
                 int r = a / b;

                 Console.WriteLine($"the result is{r} ");

                 var path = "c://myfile.txt";
                 var text = File.ReadAllText(path);
                 if(!string.IsNullOrWhiteSpace(text))
                 {
                     throw new EmptyFileException("file does not exits");

                 }

                 Console.WriteLine(text);



             }
             catch(DivideByZeroException ee)
             {
                 Console.WriteLine(ee.Message);

             }
             catch(DllNotFoundException ee)
             {
                 Console.WriteLine(ee.Message);

             }
             catch(ApplicationException ee)
             {
                 Console.WriteLine(ee.Message);

             }
             catch(EmptyFileException ee)
             {
                 Console.WriteLine(ee.Message);

             }
             catch(Exception ee)
             {
                 Console.WriteLine(ee.Message);

             }
             finally
             {
                 Console.WriteLine("program ended");

             } */

            text(x => x > 5);
            text2(x => x < 5);


        }

        static void text(Expression<Func<int,bool>>exp)
        {
            Func<int, bool> deleg = exp.Compile();

            Console.WriteLine("deleg(4)={0}", deleg(4));
            Console.WriteLine();


        }
        static void text2(Func<int,bool>f)
        {
            Console.WriteLine("deleg(4) ={0}", f(4));

        }
            
    }
}
