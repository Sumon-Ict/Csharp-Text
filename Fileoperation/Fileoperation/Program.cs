using System;
using System.IO;

namespace Fileoperation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            test<extededitem> t = new test<extededitem>(new extededitem { x = 12, y = 34, z = 90, k = 23 });
            test<extededitem>(new extededitem { x = 89, y = 78, z = 56, k = 23 });

            var math = new Math();
                math.x = 12;
            math.y = 34;

            Math.z = 45;
          var r=  math.sum();
            Console.WriteLine(r);

            var r2 = File.Exists("D:\\Csharp Test\\Csharp-Text\\Fileoperation\\Fileoperation\\Sample.txt");

            Console.WriteLine(r2);

            var filepath = "D:\\Csharp Test\\Csharp-Text\\Fileoperation\\Fileoperation\\Sample.txt";


            var r3 = File.Exists(filepath);

            Console.WriteLine(r3);


            if(File.Exists(filepath))
            {
                var text = File.ReadAllText(filepath);

                Console.WriteLine(text);

                var t2 = File.ReadAllLines(filepath);

                foreach(var line in t2 )
                {
                    Console.WriteLine($"--{line}---");

                }
            }

            var files = new FileInfo(filepath);
            if(files.Exists)
            {
                var reader = files.OpenText();

                string line = null;

                do
                {
                    line = reader.ReadLine();
                    Console.WriteLine(line);

                } while (line != null);


            }







        }
        public static void test<T>(T item)where T:extededitem
        {
            // var x = item.ToString();

            var r1 = item.x;
            var r2 = item.y;
            var r3 = item.z;
           



        }
        public interface items
        {
            public int x { get; set; }
            public double y { get; set; }
        }

        public class it:items
        {
            public int z { get; set; }
            public int x { get; set; }
            public double y { get; set; }
        }
        public class extededitem:it
        {
            public int k { get; set; }

        }

    }
    public class Math
    {
        public int x { get; set; }
        public int y { get; set; }
        public static int z { get; set; }


        public int sum()
        { return x + y+z; }

        public int mul()
        { return x * y; }

       

    }
}
