using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOP
{
    public class Pumpkin
    {
        static Pumpkin()
        {
            Type = "Undefined";
        }

        public Pumpkin()
        {
        }

        internal Pumpkin(string name)
        {
            Name = $"Pumpkin {name}";
        }

        internal Pumpkin(string name, string type)
        {
            Name = $"Pumpkin {name}";
            Type = type;
        }

        public Pumpkin(string name, int age, string color, bool hasTail)
        {
            Name = $"Pumpkin {name}";
            Age = age;
            Color = color;
            HasTail = hasTail;
        }

        public string Name;
        public bool HasTail;
        public int Age;
        public static string Type;// = "Vegetable";

        public string Color { get; set; } = "Yellow";

        private double _numberOfSweetsEarned;
        public double NumberOfSweetsEarned
        {
            set => _numberOfSweetsEarned = value;
        }

        //public double SweetTax = 0.15;
        private double _sweetTax = 0.15;
        public double SweetTax
        {
            get => _sweetTax;
        }

        public bool ShortSignature(bool isShort) => !isShort;

        public string GetType() => Type;

        public static void GreetPumpkin() => Console.WriteLine("Hello Pumpkin");

        public void GreetPumpkin(string name) => Console.WriteLine($"Hello Pumpkin [{name}]");

        public void CheckColor()
        {
            if (Color.Equals("Yellow"))
            {
                Console.WriteLine("Pumpkin is young!");
            }
            else if (Color.Equals("Orange"))
            {
                Console.WriteLine("Pumpkin is great!");
            }
            else
            {
                Console.WriteLine("Pumpkin is undefined!");
            }
        }
    }

}
