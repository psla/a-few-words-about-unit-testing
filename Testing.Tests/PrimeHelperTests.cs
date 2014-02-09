using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Testing.Tests
{
    public class PrimeHelperTests
    {
        [TestCase]
        public void IsPrime()
        {
            Assert.True(PrimeHelper.IsPrimeBuggy(2));
            Assert.True(PrimeHelper.IsPrimeBuggy(3));
            Assert.True(PrimeHelper.IsPrimeBuggy(5));
        }

        [TestCase]
        public void IsNotPrime()
        {
            Assert.False(PrimeHelper.IsPrimeBuggy(6));
            // Assert.False(PrimeHelper.IsPrimeBuggy(4));
        }
        
    }
}
