using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaceandclass
{
   public abstract class user
    {


        public string name { get; set; }

        public int age { get; set; }
        public int    weight { get; set; }


        public virtual void login(string name,string pass)
        {

        }

        public  void logout()
        {

        }
            

        public void details()
        {
            Console.WriteLine("my name is sumon");

        }

        public virtual double mul(int a,int b)
        {
            return a + b;

        }


        public abstract void changepass(string newpass);



    }
}
