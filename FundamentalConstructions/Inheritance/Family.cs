using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal struct Family
    {
        public string Name;
        public int NumberOfPeople;

        public Family(string name, int numberOfPeople)
        {
            Name = name;
            NumberOfPeople = numberOfPeople;
        }

        public void Print()
        {
            Console.WriteLine($"Name {Name}, number of people {NumberOfPeople}");
        }
    }
}
