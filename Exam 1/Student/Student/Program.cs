using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {


            string[,] array = new string[,] { { "sumon", "sujon" },{ "sohag", "karim" },{ "karim", "mosaraff" } };


            Console.WriteLine(array[2, 0]);


            foreach (string str in array)
            {

                Console.WriteLine(str);

            }
            
            
            static string result(int d)
            {


                string str;
               switch(d)
                {
                    case 1:
                        str= "sunday";
                        break;

                    case 2:
                        str = "sunay";
                        break;

                    case 3:
                        str = "monday";
                        break;
                    case 4:
                        str = "tuesday";
                        break;
                    default:
                        str = "input is not correct";
                        break;                                       

                }
                return str;
            }

            Console.WriteLine("enter the number of day");

            int day = Convert.ToInt32(Console.ReadLine());


            string final = result(day);


            Console.WriteLine($"the day name is {final}");



            
            
            
            
            var studentarray = new firstbatch[6];


            var student = new firstbatch();
            student.Name = "sumon";
            student.address = "bogra";
            student.weight = 23.45;
            student.age = 678;
            student.price = 5000;
            studentarray[4] = student;

            var student2 = new firstbatch();
            student2.Name = "sujon";
            student2.address = "sonatola bogra";
            student2.weight = 789.8;
            student2.age = 23.87f;
            student2.price = 5000;
            studentarray[5]=student2;



           /* print(student);
            Console.WriteLine(student.formateage());
            print(student2);

            Console.WriteLine(student2.formateage());*/

            var second1s = new secondbatch();
            second1s.Name = "sagor";
            second1s.address = "pabna";
            second1s.weight = 23.45;
            second1s.age = 23.4f;
            second1s.roll = 13658867;
            second1s.price = 5000;

            studentarray[0] = second1s;

            var second2 = new secondbatch();
            second2.Name = "momin";
            second2.address = "kushtia";
            second2.weight = 23.45;
            second2.age = 675;
            second2.roll = 7756566;
            second2.price = 5000;


            studentarray[2] = second2;


            thirdbatch Th = new thirdbatch();
            Th.Name = "raim";
            Th.address = "jesore";
            Th.weight = 89.67;
            Th.age = 897668;
            Th.session = 223455;
            Th.price = 5000;

            studentarray[3] = Th;

            print(student);
            print(student2);
            print(second1s);
            print(second2);
            print(Th);            
            
        }

      static  void print(firstbatch S )
        {
            Console.WriteLine($"the name of the student is {S.Name}");
            Console.WriteLine($"the address of the student is {S.address}");
            Console.WriteLine($"the weight is {S.weight}");
            Console.WriteLine($" the age of the student is {S.formateage()}");
            Console.WriteLine($" the discount is {S.discount()}");


            if(S is secondbatch)
            {

                var val = S as secondbatch;
             
                Console.WriteLine($" the roll of the student is {val.roll}");
         
            }
            else if (S is thirdbatch)
           {
                var third = S as thirdbatch;
                Console.WriteLine($" the session of the student is {third.session}");
            }

        }
    }
}
