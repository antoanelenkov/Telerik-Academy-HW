using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implement an extension method Substring(int index, int length) for the class StringBuilder 
 * that returns new StringBuilder and has the same functionality as Substring in the class String.*/

namespace LINQ
{
    public static class SubString
    {
        public static StringBuilder GetSubString(this StringBuilder stringBuilder, int index, int length)
        {
            if (index < 0) { index = 0; }
            if (length < 0) { length = 0; }
            if ((length + index) > stringBuilder.Length)
            {
                length = stringBuilder.Length - index;
            }

            var sb = new StringBuilder();
            for (int i = index; i < length + index; i++)
            {
                sb.Append(stringBuilder[i]);
            }
            return sb;
        }
    }
}
