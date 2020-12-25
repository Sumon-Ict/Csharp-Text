using System;
using System.Collections.Generic;
using System.Text;

namespace Sealedclass
{
  public sealed partial  class Person
    {
         public string name { get; set; }
        public int age { get; set; }

        public void tostring()
        {
            Console.WriteLine($"the name {name}");


        }
    }
}
