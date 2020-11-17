using System;
using System.Collections.Generic;
using System.Linq;

namespace GenericText
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Dictionary<int, string> d = new Dictionary<int, string>();

            d.Add(12, "sumon");
            d.Add(1, "sujn");

            List<int> li = new List<int>();

            li.Add(12);
            li.Add(23);
            li.Add(56);
            var c = li.Count;
            Console.WriteLine(c);

            li.RemoveAt(2);

            li.Add(234);

            for(int i=0;i<li.Count;i++)
            {
                Console.WriteLine(li[i]);

            }


            LinkedList<string> ll = new LinkedList<string>();

            Queue<string> Q = new Queue<string>();
            Q.Enqueue("sumon");
            Q.Enqueue("suon");
            Q.Enqueue("sohag");

            foreach (var str in Q)
                Console.WriteLine(str);


            Queue<string> qc = new Queue<string>(Q.ToArray());

            foreach (var s in qc)
               Console.WriteLine(s);

            Queue<string> q2 = new Queue<string>(Q);





          





            








        }
    }
}
