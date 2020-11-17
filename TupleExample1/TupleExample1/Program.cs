using System;
using System.Collections.Generic;

namespace TupleExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var res = getpersonInfo();

            Console.WriteLine($"name: {res.name}, roll: {res.roll}, districname: {res.r.Districname}, weight: {res.r.weight}, age: {res.r.age}");


            var p = ("sumon", 45, gender: "male", weight: 89);

            Console.WriteLine($"name: {p.Item1}, age:{p.Item2}, gender: {p.gender}, weight: {p.weight}");


            var listofperson = new List<(string str, int age, double weight)>();


            listofperson.Add(("sumon", 23, 23.90));
            listofperson.Add(("sujon", 56, 90.89));
            listofperson.Add(("salam", 78, 90.87));
            listofperson.Add(("suvo", 12, 566.89));

            foreach (var item in listofperson)
            {
                Console.WriteLine($"name: {item.str}, age: {item.age}, weight:{item.weight} ");
            }


            var sl = new SortedList<string, int>();
            sl.Add("sumon", 23);
            sl.Add("parveh", 6);
            sl.Add("kajol", 3);

            foreach (var items in sl)
            {
                Console.WriteLine($"name: {items.Key}: age: {items.Value}");

            }

            //lamdamethod


            var r = sum(89, 90);
            Console.WriteLine(r);
            var r1 = average(89, 190);

            Console.WriteLine(r1);


            int[][] jaggedarray = new int[3][];
            jaggedarray[0] = new int[] { 90, 12, 34, 56, 78 };
            jaggedarray[1] = new int[3] { 12, 34, 55 };

            jaggedarray[2] = new int[] { 90, 2, 4, 54, 6, 7, 8 };

            for(int i=0;i<3;i++)
            {
                for(int j=0;j<jaggedarray[i].Length;j++)
                {
                    Console.Write($" {jaggedarray[i][j]},");
                }
                Console.WriteLine();
           
            }




        }

        static (string name, int roll, Result r) getpersonInfo()
        {
            return ("sumon", 1234, new Result { Districname = "bogra", weight = 89.09, age = 89 });

        }

        static long sum(int a, int b) => a + b;
        static double average(int a, int b) => a > b ? (a / b) : (b / a);

            

            
    }
}
