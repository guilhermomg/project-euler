using System;
using System.Collections;
using System.Collections.Generic;

namespace ProjectEuler.Problems
{
    public class SmallestMultiple
    {
        public static int Run(int max)
        {
            var maxOccur = new Dictionary<int, int>();

            for (int i = 1; i <= max; i++)
            {
                var primes = PrimeFactor(i);

                foreach (KeyValuePair<int, int> entry in primes)
                {
                    if (maxOccur.ContainsKey(entry.Key))
                    {
                        if (maxOccur[entry.Key] < entry.Value)
                            maxOccur[entry.Key] = entry.Value;
                    }
                    else
                    {
                        maxOccur.Add(entry.Key, entry.Value);
                    }
                }
            }

            var mm = 1;

            foreach (KeyValuePair<int, int> entry in maxOccur)
            {
                mm *= (int)Math.Pow(entry.Key, entry.Value);
            }


            return mm;
        }

        private static IDictionary<int, int> PrimeFactor(int number)
        {
            var primes = new Dictionary<int, int>();

            for (int div = 2; div <= number; div++)
            {
                while (number % div == 0)
                {
                    if (primes.ContainsKey(div))
                        primes[div]++;
                    else
                        primes.Add(div, 1);

                    number = number / div;
                }
            }

            return primes;

        }
    }
}