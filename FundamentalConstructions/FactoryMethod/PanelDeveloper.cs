using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class PanelDeveloper : Developer
    {
        public PanelDeveloper(string name) : base(name) { }

        public override House Create()
        {
            return new PanelHouse();
        }
    }
}
