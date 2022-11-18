using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class AmericanPizza : IPizza
    {
        private string _name;
        public AmericanPizza(string name)
        {
            _name = name;
        }

        public string Name
            { get { return _name; } }

        public double GetCost()
        {
            return 10;
        }
    }
}
