using System;
using System.Threading;

namespace PaymentManager.Presentation.Helpers
{
    public static class Reader
    {
        public static bool TryReadNumber(out int number)
        {
            var isNumber = int.TryParse(Console.ReadLine(), out var numberRead);
            if (!isNumber)
            {
                Console.WriteLine("Error not number");
                Thread.Sleep(1000);
                Console.Clear();
                number = 0;
                return false;
            }

            number = numberRead;
            return true;
        }
    }
}
