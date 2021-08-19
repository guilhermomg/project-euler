namespace ProjectEuler.Problems
{
    public class LargestPalindromeProduct
    {
        public static int Run(int maxProduct)
        {
            int largest = 0;

            for (int i = maxProduct; i > 100; i--)
            {
                for (int j = i; j > 100; j--)
                {
                    int product = i * j;
                    if (IsNumberAPalimdrome(product))
                    {
                        if (product > largest)
                            largest = product;
                    }
                }
            }

            return largest;
        }

        public static bool IsNumberAPalimdrome(int number)
        {
            var numberText = number.ToString();
            var count = 0;

            while (numberText[count] == numberText[numberText.Length - 1 - count] && (count < numberText.Length / 2))
                count++;


            return count >= (numberText.Length / 2);
        }
    }
}