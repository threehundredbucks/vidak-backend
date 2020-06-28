using System;

namespace vidak_backend
{
    class UniversalClass
    {

        private void check(decimal a, decimal b)
        {
            Console.Write($"{a} + {b} > 10? ");
            bool something = a + b > 10m;
            if (something)
            {
                Console.Write("It's true");
            }
            else
            {
                Console.Write("It's false");
            }
        }

        public void DoMath()
        {
            decimal a = 5;
            decimal b = 6;
            check(a, b);
            b = 3;
            check(a, b);
            var line = Console.ReadLine();
        }
    }
}
