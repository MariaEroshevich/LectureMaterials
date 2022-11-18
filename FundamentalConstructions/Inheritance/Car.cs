using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Car : Transport, IMovable 
    {
        private string _mark;
        public new string Model;
        public int Age;
        public string FuelType;

        public Car(string mark, string model, int age, string fuelType) : base(mark, model)
        {
            _mark = mark;
            Age = age;
            FuelType = fuelType;
        }

        public override sealed string Shop => base.Shop;

        public override string Mark
        {
            get { return _mark; }
        }

        public override void GetTypeFuel()
        {
            Console.WriteLine(FuelType);
        }

        public new void Move()
        {
            Console.WriteLine("Car move!");
        }

        public override int GetAge()
        {
            return Age;
        }
    }
}
