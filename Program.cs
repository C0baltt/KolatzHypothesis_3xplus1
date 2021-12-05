using System;

namespace KolatzHypothesis_3xplus1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input start value ");
            long minValue = Input.InputValues();

            Console.Write("Input end value ");
            long maxValue = Input.InputValues();

            var hailstone = Calculator_3xplus1.CalculateSequence(minValue, maxValue);

            var hailstones = Calculator_3xplus1.Calculation(hailstone);

            Console.WriteLine($"Output hailstones from {hailstone}: ");

            foreach (long i in hailstones)
            {
                Console.WriteLine($"    {(hailstones.IndexOf(i)) + 1}:    {i} ");
            }

            Console.WriteLine($"Count hailstones: {hailstones.Count}, from number: {hailstone}");
        }
    }
}
