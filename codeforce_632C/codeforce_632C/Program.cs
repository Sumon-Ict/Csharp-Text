using System;
using System.Collections.Generic;
using System.Linq;


namespace codeforce_632C
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> li = new List<string>();

            for (int i = 0; i < n; i++)
            {

                string str = Console.ReadLine();
                li.Add(str);  
            }


            li.Sort();

            for(int i=0;i<li.Count;i++)
            {
                Console.Write(li[i]);

            }



           




        }
    }
}
