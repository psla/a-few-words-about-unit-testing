using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Testing
{
    public static class PrimeHelper
    {
        public static bool IsPrimeBuggy(int n) {
            for(int i = 2; i </*=*/ Math.Sqrt(n); i++) {
                if(n % i == 0) {
                    return false;
                }
            }

            return true;
        }
    }
}
