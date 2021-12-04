using System;

namespace KolatzHypothesis_3xplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            long y;

            Console.Write("Input natural number: ");

            var input = Console.ReadLine();

            while (!Int64.TryParse(input, out y))
            {
                Console.WriteLine("Input only an integer");
                input = Console.ReadLine();
            }

            var hailstones = Calculator_3xplus1.Calculation(y);

            Console.WriteLine("Output hailstones: ");

            foreach (long i in hailstones)
            {
                Console.WriteLine($"    {(hailstones.IndexOf(i)) + 1}:    {i} ");
            }

            Console.WriteLine($"Count hailstones: {hailstones.Count}");
        }
    }
}
