using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverloadMethods
{
    static class ExtensionMethods
    {
        public static Int32 IndexOfV1(this StringBuilder sb, Char value)
        {
            for (Int32 index = 0; index < sb.Length; index++)
                if (sb[index] == value) return index;
            return -1;
        }
    }
}
