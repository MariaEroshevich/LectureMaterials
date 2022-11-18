using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public abstract class Dog
    {
        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract void Bark();
    }
}
