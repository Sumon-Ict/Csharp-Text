using System;

namespace Delegates
{
    class Program
    {


        public delegate void addnum(int a, int b);
        public delegate void subnum(int a, int b);

        // method "sum" 
        public void sum(int a, int b)
        {
            Console.WriteLine("(a + b) = {0}", a + b);
        }

        // method "subtract" 
        public void subtract(int a, int b)
        {
            Console.WriteLine("(a - b) = {0}", a - b);
        }


        static void Main(string[] args)
        {

            Program obj = new Program();
            addnum dele_obj = new addnum(obj.sum);
            subnum deleobj2 = new subnum(obj.subtract);

            dele_obj(122, 34);
            deleobj2(100, 23);


        }
    }
}
