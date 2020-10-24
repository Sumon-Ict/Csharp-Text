using System;

namespace Student
{
    class Program
    {
        static void Main(string[] args)
        {



            #region string 1D array and foreach
            string[,] array = new string[,] { { "sumon", "sujon" }, { "sohag", "karim" }, { "karim", "mosaraff" } };


            foreach (string str in array)
            {

                Console.WriteLine(str);

            }

            #endregion



            #region multidimension array
            string[,,] Array = new string[2, 2, 2];

            Array[0, 0, 0] = "raka";
            Array[0, 0, 1] = "nowraj";
            Array[0, 1, 0] = "sopnil";
            Array[1, 1, 1] = "nilufa";


            Console.WriteLine(Array[0, 1, 0]);

            #endregion


            #region Jagged Array


            string[][,] jaggedarray = new string[3][,];



            jaggedarray[0] = new string[,] { { "sumon", "sujon", "hargi" }, { "momin", "salam", "suvo" }, { "sorna", "kajol", "moon" } };


            Console.WriteLine(jaggedarray[0][1, 2]);


            Console.WriteLine(array[2, 0]);

            string[][,,] jaggedA = new string[10][,,];

            jaggedA[0] = new string[,,] {

                { { "sumon", "sujon" }, { "rashid", "imran" } },

                  { { "masud", "surjo" }, { "khairul", "plabon" } }
            };


            jaggedA[1] = new string[,,] { { { "bristy","nilu" },{ "jiniya","marful"} },{ { "tomal","mahfuj" },{ "alamin","debasis" } } };


            Console.WriteLine(jaggedA[1][1, 0, 1]);



            #endregion


            #region   switch array

            static string result(int d)
            {


                string str;
                switch (d)
                {
                    case 1:
                        str = "sunday";
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


            Console.WriteLine("enter the value");


            int day = Convert.ToInt32(Console.ReadLine());


            string final = result(day);


            Console.WriteLine($"the day name is {final}");  
            Console.WriteLine("the day name is {0}", final);  //same method for output 


            #endregion




            #region inhertence and override 

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



            print(student);
            Console.WriteLine(student.formateage());
            print(student2);

            Console.WriteLine(student2.formateage());

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
            #endregion


            #region method overloading 

            secondbatch F = new secondbatch();  //using secondbatch class 

            F.myfun();

            F.myfun("sumon", "sujom");
            F.myfun(2434.78, 789);
            F.myfun(89.9, 12.890);

            #endregion


            int b = 0b_10000_1111;

            int t = ~b;
            Console.WriteLine(Convert.ToString(t, toBase: 2));









        }

    }
}
