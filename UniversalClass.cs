using System;

namespace vidak_backend
{
    class UniversalClass
    {

        private void check(decimal a, decimal b)
        {
            var something = a + b > 10m;
            Console.WriteLine($"{a} + {b} > 10? " + (something ? "It's true" : "It's false"));
        }

        public void DoMath()
        {
            decimal a = 5;
            decimal b = 6;
            check(a, b);
            b = 3;
            check(a, b);
        }
    }
}
