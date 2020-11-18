using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClass
{
   public abstract class Worker
    {

        public string name { get; set; }

        public int age { get; set; }

        public double weight { get; set; }

        public Worker(string st,int ag)
        {
            name = st;
            age = ag;
        }


        public Worker(string s, int i, double we)
        {
            name = s;
            age = i;
            weight = we;
        }


        public double mul()
        {
            return age * weight;
        }

        public string address(string s)
        {
            return s;
        }

        public abstract string detail();

        
    }
}
