using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KolatzHypothesis_3xplus1
{
    public class Calculator
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
    }
}
