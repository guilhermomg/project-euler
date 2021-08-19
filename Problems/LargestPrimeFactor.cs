namespace ProjectEuler.Problems
{
    public class LargestPrimeFactor
    {
        public static int Run(long target)
        {
            int factor = 2;
            int greatestFactor = 2;
            long decomposed = target;

            if (decomposed % factor == 0)
            {
                decomposed = decomposed / factor;
                greatestFactor = factor;
            }

            factor++;

            while (decomposed > 1)
            {
                if (decomposed % factor == 0)
                {
                    decomposed = decomposed / factor;
                    greatestFactor = factor;
                }

                factor = factor + 2;
            }

            return greatestFactor;
        }
    }
}