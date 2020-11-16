 using System;
using System.Collections;
using System.Collections.Generic;

namespace CollectionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ArrayList names = new ArrayList();  //non generics form of colection
            names.Add("sumon");
            names.Add("sujon");
            names.Add(23);

            var r = (string)names[1];
            Console.WriteLine(r);

            List<string> name = new List<string>();// generics form of collections 

            name.Add("sajol");
            name.Add("kajol");
            name.Add("suvo");

            HashSet<double> cgpa = new HashSet<double>();
            cgpa.Add(2.45);
            cgpa.Add(3.12);

            Hashtable values = new Hashtable();
            values.Add("name", "sumon");
            values.Add("age", 12);
            values.Add("weight", 45);


            Dictionary<string, double> pairs = new Dictionary<string, double>();  

            pairs.Add("bangla", 45);
            pairs.Add("english", 56);
            pairs.Add("Math", 89);
            pairs.Add("islamic studies", 90);



               
         





        }
    }
}
