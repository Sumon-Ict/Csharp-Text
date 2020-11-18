using System;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            Student s = new Student(34.90,"sumon",89);

            Student s3 = new Student(123, "sujon", 23, 90.87);

            var res = s3.mul();
            Console.WriteLine(res);


            Console.WriteLine(s.name);
            var result = s.mul();

            Console.WriteLine(result);


           var stduentname = s.detail();

            Console.WriteLine(stduentname);

           var s2= s.address("bogra");

            Console.WriteLine(s2);

            Console.WriteLine(s.workhour);


            var t = s.salary();


            Console.WriteLine(t);






        }

    }
}
