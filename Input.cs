using System;

namespace KolatzHypothesis_3xplus1
{
    public static class Input
    {
        public static long VerifyValue()
        {
            long y;
            var input = Console.ReadLine();

            while (!Int64.TryParse(input, out y))
            {
                Console.WriteLine("Input only an integer. " +
                    "\n The value must be between –9 223 372 036 854 775 808 and 9 223 372 036 854 775 807" +
                    "\n Except zero");
                input = Console.ReadLine();
            }

            return y;
        }
    }
}
