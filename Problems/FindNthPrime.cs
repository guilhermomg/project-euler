using System;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class FindNthPrime
    {
        public static int Run(int th)
        {
            var count = 1;
            var current = 1;

            do
            {
                current += 2;

                if (IsPrime(current))
                    count++;
            } while (count < th);

            return current;
        }

        public static bool IsPrime(int number)
        {
            if (number == 1)
                return false;
            else if (number < 4)
                return true;
            else if (number % 2 == 0)
                return false;
            else if (number < 9) // Excluded 4,6,8 previously
                return true;
            else if (number % 3 == 0)
                return false;
            else
            {
                int res = (int)Math.Floor(Math.Sqrt(number));
                int floor = 5;

                while (floor <= res)
                {
                    if (number % floor == 0)
                        return false;
                    if (number % (floor + 2) == 0)
                        return false;

                    floor += 6;
                }

                return true;
            }
        }
    }
}