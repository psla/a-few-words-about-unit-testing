using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Testing.Tests
{
    class EnumerableExtensionsTests
    {
        [TestCase]
        public void LongestOfTwoCollections()
        {
            Assert.AreEqual("foo", EnumerableExtensions.LongestOfTwoCollections(new[] { "foo" }, new string[0]));
        }
    }
}
