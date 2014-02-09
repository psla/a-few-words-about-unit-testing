using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq;

namespace Testing
{
    public static class EnumerableExtensions
    {
        public static string Longest(this IEnumerable<string> elements)
        {
            return elements.OrderByDescending(x => (x ?? string.Empty).Length).FirstOrDefault();
        }

        public static string LongestOfTwoCollections(IEnumerable<string> elements1, IEnumerable<string> elements2)
        {
            return elements1.Concat(elements2).Longest();
        }
    }
}
