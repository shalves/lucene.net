﻿using System.Text;

namespace Lucene.Net
{
    public static class SystemTypesHelpers
    {
        public static char[] toCharArray(this string str)
        {
            return str.ToCharArray();
        }

        public static string toString(this object obj)
        {
            return obj.ToString();
        }

        public static bool equals(this object obj1, object obj2)
        {
            return obj1.Equals(obj2);
        }

        public static StringBuilder append(this StringBuilder sb, long value)
        {
            sb.Append(value);
            return sb;
        }

        public static StringBuilder append(this StringBuilder sb, string value)
        {
            sb.Append(value);
            return sb;
        }
    }
}
