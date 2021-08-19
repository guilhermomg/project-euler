namespace ProjectEuler.Problems
{
    public class SumEvenFibonacciNumbers
    {
        public static int Run(int max)
        {
            int j = 2;
            int sum = 3;
            int sumEven = 2;

            while (j <= max)
            {
                int currSum = sum;
                sum = sum + j;
                j = currSum;

                if (j % 2 == 0)
                    sumEven = sumEven + j;
            }

            return sumEven;
        }
    }
}