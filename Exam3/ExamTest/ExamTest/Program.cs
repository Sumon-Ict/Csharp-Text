using System;

namespace ExamTest
{
    class Program
    {
        static void Main(string[] args)
        {
          



            Myclass ob = new Myclass();  // without paramter constructor 
            Console.WriteLine($"the name of the obeject is {ob.name}");
            Console.WriteLine($"the weoght of the ob is {ob.weight}");
            Console.WriteLine($"the age of the ob is {ob.age}");

            Myclass ob1 = new Myclass("sujon", 23.4589, 87); //parameter constructor 


            var ob2 = new Myclass();   // create object by var keyword 

            ob2.name = "salam";
            ob2.weight = 123.567;
            ob2.age = 123;

            Console.WriteLine($"the name of ob1 is {ob1.name}");

            Console.WriteLine("the weight of ob1 is {0}", ob1.weight);
           
            Console.WriteLine($"the age of ob1 is {ob1.age}");

            Console.WriteLine($"the name of ob1 is {ob2.name}");

            Console.WriteLine("the weight of ob2 is {0}", ob2.weight);
            Console.WriteLine($"the age of ob2 is {ob2.age}");

            Console.WriteLine($" the converted weight is  {ob1.weight.ToString("0.00")}");  //set weight with 2 decimal 

            Console.WriteLine("the converted weight is {0}", ob2.weight.ToString("0.000")); // set precision with 3 decimal 






        }
    }
}
