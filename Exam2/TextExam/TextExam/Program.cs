using System;
using System.Globalization;

namespace TextExam
{
    class Program
    {
        static void Main(string[] args)
        {


            #region  set precision

            double rs = result(23, 45, 1234);

            Console.WriteLine(rs);
            Console.WriteLine(rs.ToString("c4", CultureInfo.CurrentCulture));


            double V = 123.78954;

            Console.WriteLine(V.ToString("0.00"));
            Console.WriteLine("F : {0}", V.ToString("F5", CultureInfo.CurrentCulture));

            #endregion


            #region bitwise operation 

            uint t = 0b_10;
            uint b = ~t;
            Console.WriteLine(Convert.ToString(b, 2));

            // biteise operator 

            uint a1 = 0b_1111;  //binary input system 
            uint a2 = 0b_0011;  //binary inpputr system 

            var res = a1 & a2;  //and operation and produce decimal output 

            var orperation = a1 | a2;
            var xor = a1 ^ a2;
            var complement = ~a1;



            string F1 = Convert.ToString(value : res, toBase: 2);
            string f2 = Convert.ToString(value: orperation, toBase: 2);
            string f3 = Convert.ToString(value: xor, toBase: 2);
            string f4 = Convert.ToString(value: complement, toBase: 2);

            Console.WriteLine($"the bitwise and opertor {F1}");
            Console.WriteLine($"the bitwose or operation {f2}");
            Console.WriteLine($"the xor operation is {f4} ");


            var a3 = 8970;

            string a4 = Convert.ToString(value: a3, toBase: 2);
            Console.WriteLine(a4);

            var p = 123;
            var pout = 123 << 3;
            var pright = 123 >> 3;
            Console.WriteLine(pout);
            Console.WriteLine(pright);





            #endregion

            /// logical operation 
            /// 
            var v1 = 123;
            var v2 = 456;
            var v3 = 765;

            if(v1>v2&& v2<v3)
            {
                Console.WriteLine("the condiotion is true");

            }
            else
            {
                Console.WriteLine("the condition is not true");

            }








        }


        static double result(int a,int b,int c)
        {
            var r = (a + b + c) / 3;
            return r;


        }
        
    }
}
