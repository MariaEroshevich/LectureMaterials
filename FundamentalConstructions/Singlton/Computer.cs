using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    internal class Computer
    {
        public OperationSystem OperationSystem { get; set; }

        public void Launch(string name)
        {
            OperationSystem = OperationSystem.GetInstance(name);
        }
    }
}
