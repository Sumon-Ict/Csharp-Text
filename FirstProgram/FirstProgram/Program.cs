using System;
using System.Linq;

namespace FirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var s = 12;
            var y = 23;
            Console.WriteLine(s + y);//summuation of the two value

            Console.Write("my name is sumon ");

            #region type casting

            double v = 23.56;
            string st = Convert.ToString(v);

            int a = Convert.ToInt32(v);

            char ch = Convert.ToChar(v);

            bool b = Convert.ToBoolean(v);

            short s1 = Convert.ToInt16(v);








            #endregion

            #region  user input
            string str;
            Console.WriteLine("enter the vallue of string");
            str = Console.ReadLine();

            Console.WriteLine($" welcome  {str} to our course ");

            double d1, d2;
            d1 = Convert.ToDouble(Console.ReadLine()); // user input and convert string to double
            d2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"the age of two boys are {d1} and {d2}");


            var v1 = Console.ReadLine();  // user input is all time string ,
            var v2 = Console.ReadLine();

            var re = Convert.ToDouble(v1) * Convert.ToDouble(v2); // user string convert to desired data type
            Console.WriteLine(re);



            var r = multifly(234.4, 879);
            Console.WriteLine($"multiply result of two values is {r}");


            #endregion

            #region 1D array
            double[] array=new double[3];

            for(int i=0;i<3;i++)
            {
                array[i] = Convert.ToDouble(Console.ReadLine());


            }

            for(int j=0;j<3;j++)
            {
                Console.WriteLine(array[j]);

            }
            #endregion

            #region operator 

            long v3, v4;
            Console.WriteLine("entrer the values");

            v3 = Convert.ToInt64(Console.ReadLine());


            v4 = Convert.ToInt64(Console.ReadLine());

            var sum = v3 + v4;
            var mul = v3 * v4;
            var sub = v3 - v4;
            var div = v3 / v4;
            var mod = v3 % v4;

            var inc = v3++;  // v3=23 than inc=23 and v3= 24

            var prein = ++v4; //  v4=10 than prein= 12 


            var f = 12;
            f += 34;   //  f=f+34;

            f -= 4;  // means f=f-4;

            var and = v3 & v4;  // convert binary number, add operation than produce decimal output

            var or = v3 | v4; // convert binary number, or operatioon than produce decimal output


            var leftso = v3 << 3;  // convert binary and shift 3 bit in left and output deciml number
            var rightso = v3 >> 3; // shift 3 bit right and decimal output
            #endregion

            #region math function


            int max = Math.Max(23, 67);
            int min = Math.Min(45, 12);
            int abs = Math.Abs(-23);

            double sq = Math.Sqrt(53);
            double pow = Math.Pow(12, 23);
            double sr = Math.Round(234.89);

            #endregion


            #region string function
            string txt = Console.ReadLine();
            string txt2 = Console.ReadLine();


            int len = txt.Length;
            string add = string.Concat(txt, txt2);

            Console.WriteLine(add);
            Console.WriteLine(txt.ToLower());
            Console.WriteLine(txt2.ToUpper());

            Console.WriteLine($" the two strug are {txt} and {txt2}");

            Console.WriteLine("my name is \"sumon\" ");

            Console.WriteLine("my name is \'sujon\'");
            Console.WriteLine("my countrty name is \\ Bangladesh");

            Console.WriteLine("my friend name is \n momin");
            Console.WriteLine("my father name is \t sirajul");

            #endregion

            #region switch statement

            int time =4;
            switch(time)
            {
                case 1:
                    Console.WriteLine("saterday");
                    break;
                case 2:
                    Console.WriteLine("sunday");
                    break;

                case 3:
                    Console.WriteLine("monday");
                    break;
                case 4:
                    Console.WriteLine("tuesday");
                    break;
                case 5:
                    Console.WriteLine("wednesday");
                    break;
                case 6:
                    Console.WriteLine("thusday");
                    break;
                default:
                    Console.WriteLine("friday");
                    break;



            }
            #endregion


            #region  loop

            var c = 0;
            while(c<4)
            {
                Console.WriteLine("my name is sumon");

            }

            var k = 0;

            do
            {
                Console.WriteLine("he is a  good student");

            } while (k < 5);

            for(var i=0;i<8;i++)
            {
                Console.WriteLine("for loop testing");

            }
            #endregion



            string[] names = { "sumon", "sujon", "rahim", "kjhjgjgkk" };


            foreach(string i in names)
            {
                Console.WriteLine(i);

            }

            #region 2D and 3D array

            double[,] values = new double[2, 2];
            values[0, 0] = 12.3;
            values[0, 1] = 34.78;
            values[1, 0] = 567.89;
            values[1, 1] = 12.45;

            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.WriteLine(values[i, j]);

            }

            Array.Sort(values);


            double[,,] va = new double[2, 2, 2];

            for(int i=0;i<2;i++)
            {
                for(int j=0;j<2;j++)
                {
                    for(int p=0;p<2;p++)
                    {
                        va[i, j, p] =Convert.ToDouble(Console.ReadLine());

                    }
                }
            }



            long[] data = { 2345, 56, 78, 9766 };

            Console.WriteLine(data.Sum());
            Console.WriteLine(data.Max());
            Console.WriteLine(data.Min());

            #endregion




            myfun();
            fun("sumon");

            f2("sujon", 34);

            var result = multifly(234.5, 76.90);

            Console.WriteLine("the multiply of the number is " + result);

        }

        static void f2(string str,int d)
        {
            Console.WriteLine($" student name is {str} ans age is {d}");

        }
        static void fun(string s1)
        {
            Console.WriteLine("my name is " + s1);

        }

        static void myfun()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine($" my name is {str}");

        }
        static double multifly(double num,double num2)
        {
            var result = num * num2;
            return result;
        }
    }
}
