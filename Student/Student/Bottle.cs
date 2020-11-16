using System;
using System.Collections.Generic;
using System.Text;

namespace Student
{
   public abstract class Bottle
    {

        public int capacity { get; }
        public string color { get; }

        public int amount { get; private set; }



        public Bottle()
        {

        }




        public Bottle(int capa, string col,int amou)
        {
            capacity = capa;
            color = col;
            amount = amou;
        }


        public Bottle(int c,string C)
        {
            capacity = c;
            color = C;
            amount = 0;

        }
        public abstract double mass();

        public abstract string multiply();
             
        
    }
}
