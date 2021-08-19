namespace ProjectEuler.Problems
{
    public class SumOfThreeOrFiveMultiples
    {
        public static int Run(int max)
        {
            return SumDivisibleBy(3, max - 1) + SumDivisibleBy(5, max - 1) - SumDivisibleBy(15, max - 1);
        }

        public static int loop(int target)
        {
            int sum = 0;

            for (int i = 1; i <= target; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                    sum += i;
            }

            return sum;
        }

        public static int SumDivisibleBy(int divider, int target)
        {
            int p = target / divider;
            return divider * (p * (p + 1)) / 2;
        }
    }
}