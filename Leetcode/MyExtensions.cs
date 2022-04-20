using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;

namespace Leetcode
{
    public static class MyExtensions
    {
        public static string ToDebugString<TKey, TValue>(this IDictionary<TKey, TValue> dictionary)
        {
            return "{ " + string.Join(",", dictionary.Select(kv => kv.Key + " = " + kv.Value).ToArray()) + " }";
        }

        public static string ToDebugString(this int[] arr)
        {
            return  String.Join(" ",arr);
                // .Select((d, i) => d.ToString() + "= " + i.ToString()).ToArray());
        }
    }
}