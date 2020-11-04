using System;
using System.Collections.Generic;
using System.Text;

namespace CF14211A 
{
    public class Class4
    {

        public double average(params int[] items)
        {
            var sum = 0;
            foreach(var item in items)
            {
                sum += item;
            }
            return sum / items.Length;

        }
        public double average(params double[] values)
        {
            double sum = 0;
            foreach(double v in values)
            {
                sum += v;

            }
            return sum / values.Length;

        }

        public string Add(params string[] str)
        {
            string st = " ";

            foreach(var s in str)
            {
                st = string.Concat(st, s);

            }
            return st;
        }
        public void studentname(int roll)
        {
     
            switch(roll)
            {
                case 1:
                    Console.WriteLine("sumon");
                    Console.WriteLine("Home district : bogra");
                    Console.WriteLine(" weight: 67 ");
                    break;
                case 2:
                    Console.WriteLine("sujon");
                    Console.WriteLine("Home district : bogra");
                    Console.WriteLine(" weight: 67 ");
                    break;
                case 3:
                    Console.WriteLine("suvo");
                    Console.WriteLine("Home district : ksuhtia");
                    Console.WriteLine(" weight: 34 ");
        
                    break;
                case 4:
                    Console.WriteLine("naim");
                    Console.WriteLine("Home district : pbna");
                    Console.WriteLine(" weight: 678");
                    break;
                case 5:
                    Console.WriteLine("kajol");
                    Console.WriteLine("Home district : magura");
                    Console.WriteLine(" weight: 234 ");
                    break;
                case 6:
                    Console.WriteLine("sujon");
                    Console.WriteLine("Home district : jhenaidah");
                    Console.WriteLine(" weight: 34 ");
                    break;
                case 7:
                    Console.WriteLine("sohel");
                    Console.WriteLine("Home district : humayun");
                    Console.WriteLine(" weight: 90");
                    break;
                default:
                    Console.WriteLine("the input is wrong");
                    break;
            }
        }
    }
}
