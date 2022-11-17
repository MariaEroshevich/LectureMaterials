using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Gun : IWeapon
    {
        public void Shoot()
        {
            Console.WriteLine("Attck by gun");
        }
    }
}
