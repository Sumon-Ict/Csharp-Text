using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            static int add(int a, int b) => a + b;

            var r = add(12, 34);

            static int sub(int a, int b) => a - b;

            var r1 = sub(34, 89);
            Console.WriteLine(r);
            Console.WriteLine(r1);

            var b1 = new Box<int>();
            b1.Height = 12;
            b1.length = 34;
            b1.Width = 89;

            var b2 = new Box<double>();

            b2.Height = 45.89;
            b2.length = 890.78;
            b2.Width = 12.34;



            var b3 = new Box<long>();

            b3.Height = 908;
            b3.length = 789;
            b3.Width = 9087;


            var b4 = new Box<Type1>();

            var storage = new Storage<string>(6);

            storage.putitems(1, "sumon");
            storage.putitems(2, "sujon");
            storage.putitems(4, "kajol");


            var st1 = new Storage<int>(12);

            st1.putitems(1, 78);
            st1.putitems(2, 890);

            st1.putitems(3, 6990);


            Stack<int> stack = new Stack<int>();

            stack.Push(12);
            stack.Push(78);
            stack.Push(123);

            Stack<string> st = new Stack<string>();
            st.Push("sumon");
            st.Push("kalam");
            st.Push("kajol");

            st.Push("feramkhh");

            var testarray = new int[5];

            Console.WriteLine(testarray.Length);

            var list = new List<string>();
            list.Add("suvo");
            list.Add("kalam");
            list.Add("kajpl");
            list.Add("kajol");
            list.Add("rasid");


            var t = "  sumon  ";

            var ft = t.Trim();

            Console.WriteLine(ft);
            ft.ToLower();

            ft.Substring(2, 2);

            int mynum = (int)month.january;

            Console.WriteLine(mynum);


        }

        public enum month
        {
            january,
            february,
            march
        }


       
    }
}
