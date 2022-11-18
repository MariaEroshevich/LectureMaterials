using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public abstract class Transport
    {
        private string _mark;
        public string Model;
        public int Age;
        public string FuelType;
        private string _shop;

        public Transport(string mark, string model)
        {
            _mark = mark;
            Model = model;
        }

        public virtual string Shop
        {
            get { return _shop; }
        }

        public abstract string Mark { get; }

        public virtual void GetTypeFuel()
        {
            Console.WriteLine("Flue");
        }

        public void Move()
        {
            Console.WriteLine("Move!");
        }

        public abstract int GetAge(); 
    }
}
