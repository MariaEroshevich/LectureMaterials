using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class Hero
    {
        private string _name;
        private IWeapon _weapon;

        public Hero(string name)
        {
            _name = name;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _weapon = weapon;
        }

        public void Attack()
        {
            if (_weapon == null)
            {
                Console.WriteLine($"{_name} can't attack. Set a weapon.");
            }
            else
            {
                _weapon.Shoot();
            }
        }
    }
}
