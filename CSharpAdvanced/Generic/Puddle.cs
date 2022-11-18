using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Puddle : Dog
    {
        public Puddle(string name) : base(name)
        {
        }

        public override void Bark()
        {
            Console.WriteLine($"Woof Woof! I am puddle {Name}!");
        }
    }
}
