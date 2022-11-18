using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class Student
    {
        private string _name;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2)
                {
                    throw new IvalidStudentInfoException("Name is too short", value);
                }
                else
                {
                    _name = value;
                }
            }
        }
    }
}
