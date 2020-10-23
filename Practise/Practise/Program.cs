using System;

namespace Practise
{
    class Program
    {
        static void Main(string[] args)
        {




            var val = 1233;

            Console.WriteLine(val.ToString("D8"));



            var agecal = new product();
            agecal.A = -123;

            Console.WriteLine($"the age of the boy is {agecal.A}");



            var productarray = new product[12];

            var abook = new book();

            abook.name = "bangla";
            abook.description = "this  bangla is my favourite book ";
            abook.price = 567.23;
            abook.Author = "sahidullah";

            productarray[0] = abook;


            var bbook = new book();

            bbook.name = "english";
            bbook.description = "the writer of this book shjhkjgk";
            bbook.price = -56;
            bbook.Author = "onumpon prokasioni";


            productarray[1] = bbook;    //store bbook vlaue into the productaray[0] 

            productarray[2] = new book();  

            ((book)productarray[2]).name = "Mathematics";
            ((book)productarray[2]).description = "math is interesting subject";
            ((book)productarray[2]).price = -123;
            ((book)productarray[2]).Author = "chamok hasan";




            var anumberElectronic = new electronics();
            anumberElectronic.name = "computer ";
            anumberElectronic.description = "computer is very important in our socity ";
            anumberElectronic.price = 234.567;
            anumberElectronic.brandname = "HP group company";

            productarray[3] = anumberElectronic;



            var bnumberElectronic = new electronics();

            bnumberElectronic.name = "camera ";
            bnumberElectronic.description = "camera is using in picnic party ";
            bnumberElectronic.price = 234.32;
            bnumberElectronic.brandname = "cannnon camppany";

            productarray[4] = bnumberElectronic;




            print(abook);
            print(bbook);

            print(productarray[2]);

            print(anumberElectronic);

            print(bnumberElectronic);


        }

        static void print( product  prod)
        {

            Console.WriteLine($"the element  name is {prod.name} ");

            Console.WriteLine($"the description of the element is {prod.description}");

            Console.WriteLine($"the prince of the elemet is {prod.price}");
            Console.WriteLine($" the price of the element is {prod.formateprice()}");



            if(prod is book)
            {
                var B = prod as book;

                Console.WriteLine($"the author of the book is {B.Author}");

            }

            else if(prod is electronics)
            {
                var E = prod as electronics;

                Console.WriteLine($"the brandname of the element is {E.brandname}");
            }

        }
    }
}
