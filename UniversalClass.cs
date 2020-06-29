using System;

namespace vidak_backend
{
    class UniversalClass
    {

        private void Check(decimal a, decimal b)
        {
            var something = a + b > 10m;
            Console.WriteLine($"{a} + {b} > 10? " + (something ? "It's true" : "It's false"));
        }

        private void Japanese()
        {
            // To generate Japanese invoices:
            // Nihon no seikyū-sho o seisei suru ni wa:
            Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n\t");
            Console.WriteLine(@"c:\invoices\app.exe -j");
        }

        public void DoMath()
        {
            decimal a = 5;
            decimal b = 6;
            Check(a, b);
            b = 3;
            Check(a, b);
            Japanese();
            Random dice = new Random();
            Console.WriteLine($"Random number = {dice.Next(1, 100)} (from 1 to 99)");
        }
    }
}
