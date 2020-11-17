using System;

namespace Interfaceandclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Doel d = new Doel();
            d.color();


            Doel d1 = new Doel();
            d1.name = "cuckoo";
            d1.age = 2;
            d1.height = 4;

            d1.color();

            Console.WriteLine(d1.name);
            var r = d1.sum(d1.height, d1.age);
            Console.WriteLine(r);

            Admin ad = new Admin();
            ad.name = "sumon";
            ad.weight = 123;
            ad.age = 24;
            ad.height = 23.45;


            var r2 = ad.mul(ad.age, ad.weight);



            Console.WriteLine(r2);

            ad.details();

           






        }

       
    }
}
