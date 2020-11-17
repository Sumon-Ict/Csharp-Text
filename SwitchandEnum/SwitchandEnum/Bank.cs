using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchandEnum
{
   public class Bank
    {

        public Bankstatus status { get; set; }


    }

    public enum Bankstatus
    {
        open,
        closed,
        vipcustomer

    }
}
