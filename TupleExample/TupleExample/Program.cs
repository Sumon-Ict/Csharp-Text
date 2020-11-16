using System;
using System.Collections.Generic;

namespace TupleExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
     //outparameter code 
            var r1 = 0;
            var r2 = 0;
            summul(12, 45, out r1, out r2);
            Console.WriteLine(r1);
            Console.WriteLine(r2);


            (double sum, int count) t = (23.56, 8);   //tuple  declaration 
            Console.WriteLine(t.sum);
            Console.WriteLine(t.count);

            var tuple1 = (Name: "sumon", Home: "bogra", age: 24); //tuple declaration
            Console.WriteLine(tuple1.Name);
            Console.WriteLine(tuple1.age);

            var t2 = ("sumon", 24, "bogra");  //tuple example 

            Console.WriteLine(t2.Item1);
            Console.WriteLine(t2.Item2);
            Console.WriteLine(t2.Item3);

            var t3 = ("sumon", age: 34, "male", Home: "bogra");  //tuple example
            Console.WriteLine(t3.Item3);
            Console.WriteLine(t3.Home);

            var re = getpersonresult();

            Console.WriteLine($"name : {re.name}  age: {re.age} ,subject: {re.result.subject} cgpa: {re.result.CGPA} ");



            var listofperson = new List<(string name, int age, double weight)>();


            for(int i=0;i<12;i++)
            {
                listofperson.Add(( "sumon", i + 2, i * 6));


            }

            foreach(var value in listofperson)
            {
                Console.WriteLine( $"{ value.age} age: { value.name}  weight: { value.weight}" );


            }



            static (string name,int age,Result result) getpersonresult()
            {
                return ("sumon", 23, new Result { subject = "bangla", CGPA = 3.2 });

            }

        }

        static void summul(int a,int b,out int r,out  int m)
        {
            r = a + b;
            m = a * b;

        }
    }
}
