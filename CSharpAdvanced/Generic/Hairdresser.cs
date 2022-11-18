using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Hairdresser<T> where T: Dog
    {
        public void HairdressDog(T dog)
        {
            Console.WriteLine($"I have hairdressed {dog.Name}!");
        }
    }
}
