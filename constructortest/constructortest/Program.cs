using System;
using System.Security.Cryptography;

namespace constructortest
{
    class Program
    {
        static void Main(string[] args)
        {
            static  void mymethod(string s1,string s2,string s3)
                {

                Console.WriteLine($"my name is {s3}");

            }

            mymethod(s3: "sumon", s2: "sujon", s1: "parvej");


        }
    }
}
