using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class Developer
    {
        private string _name;

        public Developer(string name)
        {
            _name = name;
        }

        public string Name { get { return _name; } }

        public abstract House Create();
    }
}
