using System;
using System.Collections.Generic;
using System.Text;

namespace RefEOut
{
    class Calculator
    {
        public static void Triple(ref int x)
        {
            x *= 3;
        }

        public static void Triple(int x, out int result)
        {
            result = 3 * x;
        }

    }
}
