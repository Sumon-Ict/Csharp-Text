using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionHandling
{
  public  class EmptyFileException : Exception
    {
        public EmptyFileException(string message)
            : base(message)
        {


        }
    }
}
