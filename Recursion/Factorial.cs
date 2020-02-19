using System;
using System.Collections.Generic;
using System.Text;

namespace Recursion {
    public class Factorial {

        public static int factorial(int n) {
            //check for terminating condition first thing
            if (n == 1) {
                return 1;
            }
            return n * factorial(n - 1);
        }
    }
}
