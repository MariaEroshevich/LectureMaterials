using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced
{
    public class Pug : Dog
    {
        public Pug(string name) : base(name)
        {
        }

        public override void Bark()
        {
            Console.WriteLine($"Tyaff Tyaff! I am pug {Name}!");
        }
    }
}
