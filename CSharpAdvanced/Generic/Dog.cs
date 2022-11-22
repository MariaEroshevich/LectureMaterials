using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSharpAdvanced.Generic;

namespace CSharpAdvanced
{
    public abstract class Dog
    {

        public delegate void Command();

        public Dog(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public bool IsVaccinated { get; set; }

        public abstract void Bark();

        public void SetVaccinationStatus(dynamic isVaccinated)
        {
            IsVaccinated = isVaccinated switch
            {
                string when isVaccinated.Equals("Yes") => true,
                string when isVaccinated.Equals("No") => false,
                string => throw new ArgumentException($"Illegal input! Expected Yes/No but was [{isVaccinated}]"),
                bool => isVaccinated,
                _ => throw new ArgumentException("Illegal data type!")
            };
        }


        public void GiveAPaw()
        {
            Console.WriteLine("*Paw was given.");
        }

        public void SitDown()
        {
            Console.WriteLine("*Sat down.");
        }

        public Command SelectCommand(CommandType commandType) =>
            commandType switch
            {
                CommandType.Bark => Bark,
                CommandType.GiveAPaw => GiveAPaw,
                CommandType.SitDown => SitDown,
                _ => throw new NotImplementedException()
            };

    }
}
