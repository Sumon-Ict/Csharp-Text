using System;

namespace SwitchandEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var res = checkpermision(new Bank { status = Bankstatus.open }, true);

            var re2 = checkpermision2(new Bank { status = Bankstatus.closed }, false);
            var r3 = checkpermision3(new Bank { status = Bankstatus.vipcustomer }, true);


            Console.WriteLine(re2);

            Console.WriteLine(res);

            //out parameters

            var result = 0;

            sum(23, 89, out result);

            Console.WriteLine(result);



            //params 
            var r5 = average(3, 4, 5);
            var r6 = average(new int[] { 7, 8, 90 });
            Console.WriteLine(r5);
            Console.WriteLine(r6);





        }


       public static void sum(int a,int b,out int r)
        {
            r = a + b;
           
        }

        static double average(params int[] array)
        {
            var sum = 0;

            foreach(int x in array)
            {
                sum = sum + x;

            }
            return sum / array.Length;

        }

        static bool checkpermision(Bank bank,bool isvip)
        {
            bool result = false;
            switch(bank.status)
            {
                case Bankstatus.open:
                    result = true;
                    break;
                case Bankstatus.closed:
                    result = false;
                    break;
                case Bankstatus.vipcustomer:
                    result = isvip;
                    break;
                default:
                    result = false;
                    break;

            }
            return result;

        }

        static bool checkpermision2(Bank bank,bool isvip)
        {
            var result = bank.status switch
            {
                Bankstatus.open => true,
                Bankstatus.closed => false,
                Bankstatus.vipcustomer => isvip,
                _ => false,



            };
            return result;
        }
        static bool checkpermision3(Bank bank,bool isvip)
        {
            return bank.status switch
            {
                Bankstatus.open=>true,
                Bankstatus.closed=>false,
                Bankstatus.vipcustomer=>true,
                _=>false

            };
        }

        static bool checkpermision4(Bank bank, bool isvip) => bank.status switch

        {
            Bankstatus.open => true,
            Bankstatus.closed => false,
            Bankstatus.vipcustomer => isvip,
            _ => false

        };

        static bool checkpermision5(Bank bank, bool isvip)
        {
            return bank.status switch
            {
                Bankstatus.open => true,
                Bankstatus.closed => false,
                Bankstatus.vipcustomer when isvip => true,
                Bankstatus.vipcustomer when !isvip => false,
                _ => false
            };


        }
        static bool checkpermision6(Bank bank,bool isvip)
        {
            return (bank.status, isvip) switch
            {
                (Bankstatus.open, _) => true,
                (Bankstatus.closed, _) => false,
                (Bankstatus.vipcustomer, true) => true,
                (Bankstatus.vipcustomer, false) => false,
                (_, _) => false

            };

        }
        static bool checkpermision7(Bank bank,bool isvip)
        {
            return bank switch
            {
                { status: Bankstatus.open } => true,
                { status: Bankstatus.closed } => false,
                { status: Bankstatus.vipcustomer } => true,
                { status: _ } => false
            };
        }


    }
}
