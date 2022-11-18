using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    internal class IvalidStudentInfoException : Exception
    {
        public string Value { get; }

        public IvalidStudentInfoException() { }

        public IvalidStudentInfoException(string message) : base(message) { }

        public IvalidStudentInfoException(string message, Exception inner) : base(message, inner) { }

        public IvalidStudentInfoException(string message, string value) : base(message)
        {
            Value = value;
        }

        public override string? HelpLink
        {
            get
            {
                return "Find more information here: https://address.com";
            }
        }
    }
}
