using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpAdvanced.Extension
{
    public static class StringHelper
    {
        public static int CharLength(this string str, char c)
        {
            return str.ToCharArray().Select(i => i == c).Count();
        }

        public static int Length(this string str)
        {
            return str.Length;
        }
    }
}
