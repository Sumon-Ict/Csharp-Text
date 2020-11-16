using System;
using System.ComponentModel;
using System.Linq;

namespace Answer3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = new int[100];

            int count = 0;
            while(true)
            {

                var value = Console.ReadLine();

                if (string.IsNullOrEmpty(value))
                    break;

                Number[count++] = int.Parse(value);

            }

            int k = count;

            for(int i=0;i<count;i++)
            {
                Console.WriteLine(Number[i]);

            }

            var reversed = new int[100];  //same int[] reversed=new int[100]

            foreach(int item in Number)
            {

                if (count == 0)
                    break;

                reversed[count--] = item;


            }




            for(int j=1;j<=k;j++)
            {
                Console.WriteLine(reversed[j]);

            }

            Console.WriteLine(reversed.Length);


            var oddnumber = new int[(reversed.Length / 2 + reversed.Length % 2)];
            var evennumber = new int[reversed.Length / 2];

            int oddc = 0;
            int evenc = 0;

            for(int i=1;i<=k;i++)
            {
                if (i % 2 == 1)
                    oddnumber[oddc++] = reversed[i];
                else if (i % 2 == 0)
                    evennumber[evenc++] = reversed[i];

            }

            for (int i = 0; i < oddc; i++)
                Console.WriteLine(oddnumber[i]);

            for (int j = 0; j < evenc; j++)

                Console.WriteLine(evennumber[j]);


            var oddreversed = new int[oddc];

            foreach (var item in oddnumber)
            {
                oddreversed[oddc--] = item;

            }

            var evenreversed = new int[evenc];

            foreach(var item in evennumber)
            {
                evenreversed[evenc--] = item;

            }






        }


    }
}
