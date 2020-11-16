using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
    public class Waterbottle:Bottle
    {
        public string comapanyname { get; set; }

        public string agentname { get; set; }

       //base constructor calling 
        public Waterbottle(int x,string y,string cmpanyN ,int z):
            base(x,y,z)
        {
            comapanyname = cmpanyN;

        }
        public Waterbottle(int x,string y)
            :base(x,y)
        {

        }


        //own constructor calling 
        public Waterbottle(int x,string  y,string z,string m, int k)
            :this(x,y,z,k)
        {
            agentname = m;
        }


        public override double mass()
        {
            return capacity * amount;

        }

        public override string multiply()
        {
            return color + agentname;
        }
    }
}
