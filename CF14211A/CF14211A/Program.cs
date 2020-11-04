using System;
using System.Linq;
using System.Net.WebSockets;

namespace CF14211A
{
    class Program
    {
        static void Main(string[] args)
        {

            

            #region inheritence 

            Class4 cl4 = new Class4();


            var classarray = new Class1[3];
            Class1 c1 = new Class1();
            c1.name = Console.ReadLine();
            c1.address = Console.ReadLine();
            c1.price = Convert.ToDouble(Console.ReadLine());
            c1.weight = Convert.ToDouble(Console.ReadLine());
            c1.sum(123, 345);



            classarray[0] = c1;

            Class2 c2 = new Class2();
            c2.name = Console.ReadLine();
            c2.address = Console.ReadLine();
            c2.price = Convert.ToDouble(Console.ReadLine());
            c2.weight = Convert.ToDouble(Console.ReadLine());
            c2.age = Convert.ToInt32(Console.ReadLine());
            c2.sum(34, 678);
            c2.sum(123.4, 56.78);


            classarray[1] = c2;

            Class3 c3 = new Class3();
            c3.name = Console.ReadLine();
            c3.address = Console.ReadLine();
            c3.price = Convert.ToDouble(Console.ReadLine());
            c3.weight = Convert.ToDouble(Console.ReadLine());
            c3.roll = Convert.ToInt32(Console.ReadLine());

            
            classarray[2] = c3;
            c3.sum("sumon", "sujon");
            c3.sum(34, 567);





            static string formateprice(double a)
            {
                return $"the formate value {a.ToString("0")} ";
            }

            for (int i=0;i<classarray.Length;i++)
            {
                print(classarray[i]);
            }

           // print(c1);
            //print(c2);
            //print(c3);

            static void print(Class1 C)

            {

                Console.WriteLine($"the address is {C.address}");
                Console.WriteLine($"the weight is {C.weight}");
                Console.WriteLine($"the name is {C.name}");
                Console.WriteLine($"the discount is  {C.discount()}");
                Console.WriteLine(formateprice(C.price));
                
                if(C is Class2)
                {
                    var cl2 = C as Class2;

                    Console.WriteLine($"the age is {cl2.age}");

                }
                else if(C is Class3)
                {
                    var cl3 = C as Class3;

                    Console.WriteLine($"the roll is {cl3.roll}");

                }
            }
            #endregion



            var M = new Class4();

                var result = M.average(2, 3, 7, 8);

            Console.WriteLine($"the average value is {result}");

            var re = M.average(new int[] { 5, 6, 7, 89 });
            Console.WriteLine($"the average value is {re}");

            var r = M.average(new double[] { 34.4, 87, 89.7 });

            var r1 = M.average(34, 56, 879);
            Console.WriteLine($"the average value of the double values is{r1} ");
            var r2 = M.average(78.9, 90.76);

            Console.WriteLine($"the value is {r2}");




            var s = M.Add(new string[] { "sumon", "sujon", "sohag" });


            var v = Convert.ToInt32(Console.ReadLine());

            var res = switchfunction(v);

            Console.WriteLine($"the day name is {res}");

            var roll = Convert.ToInt32(Console.ReadLine());
            M.studentname(roll);




                

       

         static string switchfunction(int day)
            {
                string str;
                switch(day)
                {
                    case 1:
                        str = "saterday";
                        break;
                    case 2:
                        str = "sunday";
                        break;
                    case 3:
                        str = "monday";
                        break;
                    default:
                        str = "input is wrong";
                        break;
                        
                }
                return str;
            }









               


        }
    }
}

