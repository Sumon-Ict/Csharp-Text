using Microsoft.VisualBasic;
using System;

namespace SwitchStatemnet
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            static bool checkin(Bank bank,bool isvip)
            {
                bool result = false;

                switch(bank.status)
                {
                    case Bank.Bankstatus.open:
                        result = true;
                        break;
                    case Bank.Bankstatus.closed:
                        result = false;
                        break;

                    case Bank.Bankstatus.vipcustomer:
                        result = isvip;
                        break;
                    default:
                        result = false;
                        break;
                }
                return result;
                    
            }



            static bool checkin2(Bank bank,bool isvip)
            {
                var result = bank.status switch
                {
                    Bank.Bankstatus.open => true,
                    Bank.Bankstatus.closed => false,
                    Bank.Bankstatus.vipcustomer => isvip,
                    _ => false


                };
                return result;
            }


            static bool checkin3(Bank bank, bool isvip)
            {
                var result = bank.status switch
                {
                    Bank.Bankstatus.open => true,
                    Bank.Bankstatus.closed => false,
                    Bank.Bankstatus.vipcustomer => isvip,
                    _ => false

                };
                return result;
            }



            var b = new Bank();
            b.status = Bank.Bankstatus.closed;
            bool b1 = false;

            var r = checkin(b, b1);

            Console.WriteLine(r);  

            static bool checkin4(Bank bank,bool isvip)
            {
                return bank.status switch
                {
                    Bank.Bankstatus.open => true,
                    Bank.Bankstatus.closed => false,
                    Bank.Bankstatus.vipcustomer => isvip,
                    _ => false


                };

            }

            static bool checkin5(Bank bank, bool isvip) => bank.status switch
            {
                Bank.Bankstatus.open => true,
                Bank.Bankstatus.closed => false,
                Bank.Bankstatus.vipcustomer => isvip,
                _ => false
            };


            var M = new Lamdamethod();

            var r3 = M.add(23, 78);

           static bool check1(Bank bank,bool isvip)
            {
                return bank switch
                {
                    {
                        status: Bank.Bankstatus.open
                    } => true,
                    { status:Bank.Bankstatus.closed}=>false,
                    { status:Bank.Bankstatus.vipcustomer}=>isvip,
                    { status:_}=>false

                };

            }














               










                



            
          



          
           





           












        }
    }
}
