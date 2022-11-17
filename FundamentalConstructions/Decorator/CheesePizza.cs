using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class CheesePizza : IPizzaDecorator
    {
        private IPizza _pizza;

        public CheesePizza(IPizza pizza)
        {
            _pizza = pizza;
        }

        public string Name
        { get { return _pizza.Name; } }

        public double GetCost()
        {
            return _pizza.GetCost() + 3;
        }

        public void AddProduct()
        {
            Console.WriteLine($"{Name} Add cheese to pizza");
        }
    }
}
