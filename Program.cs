using System;

namespace FromAtoB
{
    class Program
    {
        static int convert(int a, int b)
        {
            if (a == b)
                return 0;

            if (a > b)
                return a - b;

            if (a <= 0 && b > 0)
                return -1;

            if (a % 2 == 0)
                a /= 2;

            else if (a % 4 == 1 || a == 3)
                a += 1;
        }
        public statis void Main ()
        {
            int a >= 1, b <= 10^9;
            Console.Write("Minimum number of " + "operations : " + convert(a, b));
        }
    }
}
