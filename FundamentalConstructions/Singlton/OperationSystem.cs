using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singlton
{
    public class OperationSystem
    {
        private static OperationSystem _instance;

        public string Name;

        public OperationSystem(string name)
        {
            Name = name;
        }

        public static OperationSystem GetInstance(string name)
        {
            if (_instance == null)
            {
                _instance = new OperationSystem(name);
            }
            return _instance;
        }
    }
}
