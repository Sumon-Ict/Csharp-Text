using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
   public  class Juicebottle:Bottle
    {
        public string manager { get; set; }

        public Juicebottle(int x,string y,string  z,int k)
            :base(x,y,k)
        {
            manager = z;

        }

       


        public override double mass()
        {
            return capacity * amount;
        }

        public override string  multiply()
        {
            return color + manager;
        }


    }
}
