using System;
using System.Collections;
using System.Collections.Generic;

namespace Genereics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Datastore<string> dt = new Datastore<string>(23);

            dt.putelement(0, "sumon");
            dt.putelement(2, "sujon");
            dt.putelement(3, "kajol");

            Datastore<int> dv = new Datastore<int>(5);

            dv.putelement(2, 89);
            dv.putelement(1, 90);
            dv.putelement(3, 789);
            dv.putelement(4, 123);


            Box<string, int, double> b = new Box<string, int, double>();

            b.name = "sumon";
            b.age = 23;
            b.roll = 789;


            print<string, int, double>("sumon", 89, 78.90);

            print<int, bool, string>(12, true, "sumon");

            display<string>("sumon", "sujon");
            display<int>(12,"suvo");

            object x = 12;
            x = "sumon";
            x = true;

            bool y = (bool)x;
            Console.WriteLine(y);

            ArrayList names = new ArrayList();

            names.Add("sumon");
            names.Add(123);
            names.Add(true);
            names.Add("sujon");

            Hashtable h = new Hashtable();
            h.Add(2, "sumon");
            h.Add(1, "sujon");
            h.Add(7, true);



            //bitarray

            BitArray bt = new BitArray(4);
            bt[0] = true;
            bt[1] = false;
            bt[2] = true;
            bt[3] = true;

            Console.WriteLine(bt.Get(2));

            BitArray bt1 = new BitArray(new byte[] { 1, 1, 0, 0, 0, 0, 0 });

              var x1 =bt1.Count;
            Console.WriteLine(x1);

            byte[] byt = new byte[4] { 2, 3, 4, 7 };
            string[] st = new string[4] { "sumon", "suvo", "kajom", "shkhfk" };


            SortedList sl = new SortedList();
            sl.Add("sumon", 1234);
            sl.Add("rahim", 89);
            sl.Add("suvo", 890);
            sl.Add("kajol", 123);

            for(int i=0;i<sl.Count;i++)
            {
                Console.WriteLine($"the key values is {sl.GetKey(i)} and values is {sl.GetByIndex(i)} ");


            }


            Hashtable ht = new Hashtable();
            ht.Add(12, "sumon");
            ht.Add(8, "sujon");
            ht.Add(9, "sahor");
            ht.Add(2, "samor");

           foreach(DictionaryEntry item in ht)
            {
                Console.WriteLine("{0} and {1} ", item, ht[item]);

            }
           foreach(DictionaryEntry items in ht)
            {
                Console.WriteLine($"the key value is {items.Key} and values is {items.Value} ");

            }


            List<(string, int, double)> l = new List<(string, int, double)>();
            l.Add(("sumon", 12, 23));
            l.Add(("sujon", 2, 89));
            l.Add(("subp", 9 ,90));

            foreach(var item in l)
            {
                Console.WriteLine($"name: {item.Item1}, age:{item.Item2}, weight:{item.Item3}");

            }


            Dictionary<string, string> d = new Dictionary<string, string>();
            d.Add("sumon", "sujon");
            d.Add("suvo", "sagor");
            d.Add("kajpl", "himu");

            foreach(var item in d)
            {
                Console.WriteLine($"firwatname: {item.Key} , secondname : {item.Value}");

            }



            











        }
        static void print<T, T1, T2>(T name, T1 age, T2 weight)
        {
            Console.WriteLine($" firstv: {name}, 2nd value: {age} , 3rdvalue : {weight}");
        }
        static void display<T>(T value,string name)
        {
            Console.WriteLine($" name: {name}, age: {value}");
        }
        static void average<T>(T[] value)
            {

        }
    }
}
