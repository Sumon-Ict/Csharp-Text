using System;
using System.Collections.Generic;
using System.Text;

namespace SwitchStatemnet
{
   public  class Bank
    {

        public Bankstatus status { get; set; }

        public string name { get; set; }

        #region exam1
        /*
           public void test(Bankstatus bs)
        {
            if(status==bs)
            {

            }
            else if(status==Bankstatus.closed)
            {

            }
            else if(status==Bankstatus.vipcustomer)
            {

            }
        }*/
        #endregion 





        public enum Bankstatus
        {
            open=5,
            closed=9,
            vipcustomer=45
        }

        public enum dayname
        {

        }

    }
}
