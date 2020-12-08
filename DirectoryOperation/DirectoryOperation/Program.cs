using System;
using System.IO;
using System.Text;

namespace DirectoryOperation
{
    class Program
    {
        static void Main(string[] args)
        {


           

            var r1 = File.Exists("D:\\Csharp Test\\Csharp-Text\\DirectoryOperation\\DirectoryOperation\\writesample.txt");

            var r2 = File.Exists(@"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\sampletext.txt");

            

           // Console.WriteLine(r1);
            //Console.WriteLine(r2);



            var content = "my name is sumon";

            var writepath = @"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\writesample.txt";

            var samplepath = @"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\sampletext.txt";
 
            File.WriteAllText(writepath, content);



            if(File.Exists(samplepath))
            {

                var lines = File.ReadAllText(samplepath);

                Console.WriteLine(lines);

                var text = File.ReadAllLines(samplepath);

                foreach(var t in text)
                {
                    Console.WriteLine(t);

                }


            }

            File.Create(@"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\creatfile.txt");

            File.CreateText(@"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\creatfile2.txt");

            File.Create(@"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\creatfile3.txt");

            var filepath2 = @"D:\Csharp Test\Csharp-Text\DirectoryOperation\DirectoryOperation\creatfile.txt";


            var file = new FileInfo(samplepath);

            if(file.Exists)
            {

                var reader = file.OpenText();

                //var test = reader.ReadLine();

                string line = null;
                do
                {
                    line = reader.ReadLine();

                    Console.WriteLine(line);

                } while (line != null);

            }


            var content1 = "my name is sumon. I live in kusthia";

            File.WriteAllText(writepath, content1);

            using var writer = File.OpenWrite(writepath);

            var bytes = Encoding.ASCII.GetBytes(content1);

            writer.Write(bytes);

            FileInfo file2 = new FileInfo(writepath);

            Console.WriteLine(file2.Length);
            var currentDirectory = Directory.GetCurrentDirectory();

            DirectoryInfo directory = new DirectoryInfo(currentDirectory);

            var directorylocation = directory.Parent.Parent.Parent.FullName;

            var filepath = Path.Combine(directorylocation, "sample2.txt");

            var files = directory.Parent.Parent.Parent.GetFiles();

            foreach(var file3 in files)
            {
                Console.WriteLine(file3);

            }




































        }
    }
}
