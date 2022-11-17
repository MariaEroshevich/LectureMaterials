using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class StringLength
    {
        public void CheckString(string str)
        {
            if (str == String.Empty)
            {
                throw new Exception("The entered number is null");
            }
            else
            {
                Console.WriteLine($"Entered string: {str}");
            }
        }
    }
}
