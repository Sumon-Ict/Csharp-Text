using System;
using System.Collections.Generic;
using System.Text;

namespace Structure
{
   public  struct Person
    {
        public string name { get; set; }

        public double weight { get; set; }

        public int age { get; set; }


    }

  public   struct address
    {
        public int roll { get; set; }

        public Person p;

    }
}
