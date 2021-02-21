using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp29
{
    static class Extensions
    {
        public static int? SameCountOfSymbols(this string data,char symbol)
        {
            int count = 0;
            for(int i = 0; i < data.Length; i++)
            {
                if (data[i] == symbol)
                {
                    count++;
                }
            }
            if (count < 0) return null;
            return count;
        }
        public static bool? CheckOccurrence(this string data, int count)
        {
            if (String.IsNullOrWhiteSpace(data))
                return null;

            var sb = new StringBuilder(data);
            for (int i = 0; i < sb.Length; i++)
            {
                if (data.Count(s => s == sb[i]) == count)
                    return true;
            }

            return false;
        }
    }
}
