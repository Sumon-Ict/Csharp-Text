using System;
using System.Collections.Generic;
using System.Text;

namespace Sealedclass
{
   public sealed partial class Person
    {
        public double weight { get; set; }

        public void details()
        {
            Console.WriteLine("my name is sumon");

        }

    }
}
