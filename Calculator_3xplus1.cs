using System.Collections.Generic;
using System;

namespace KolatzHypothesis_3xplus1
{
    public class Calculator_3xplus1
    {
        public static long CalculateSequenceHailstones(long minNumber, long maxNumber)
        {
            long maxCountValue = 0;

            var hailstones = CalculateHailstones(minNumber);

            int maxCountHeilstones = hailstones.Count;

            for (long i = minNumber; i <= maxNumber; i++)
            {
                Console.WriteLine($"Present value of hailstone: {i} ");

                hailstones = CalculateHailstones(i);

                if (maxCountHeilstones <= hailstones.Count)
                {
                    maxCountHeilstones = hailstones.Count;
                    maxCountValue = i;
                }
            }

            return maxCountValue;
        }

        public static List<long> CalculateHailstones(long number)
        {
            List<long> hailstones = new(1);
            long hailstone = number;

            while (true)
            {
                if (hailstone % 2 == 0)
                {
                    hailstone /= 2;
                }
                else
                {
                    hailstone *= 3;
                    hailstone += 1;
                }

                if (hailstones.Contains(hailstone))
                {
                    return hailstones;
                }

                hailstones.Add(hailstone);
            }
        }
    }
}
