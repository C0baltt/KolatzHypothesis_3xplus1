using System.Collections.Generic;

namespace KolatzHypothesis_3xplus1
{
    public class Calculator_3xplus1
    {
        public static List<long> Calculation(long x)
        {
            List<long> hailstones = new(1);
            long hailstone = x;

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

        public static long CalculateSequence(long minNumber, long maxNumber)
        {
            long maxCountValue = 0;

            var hailstones = Calculation(minNumber);

            int maxCountHeilstones = hailstones.Count;

            for (long i = minNumber; i <= maxNumber; i++)
            {
                hailstones = Calculation(i);

                if (maxCountHeilstones < hailstones.Count)
                {
                    maxCountHeilstones = hailstones.Count;
                    maxCountValue = i;
                }
            }

            return maxCountValue;
        }

    }
}
