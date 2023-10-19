namespace HOTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrWholeNumbers = { 0, 15, 32, 2000, 15000 };
            Array.Sort(arrWholeNumbers);
            var x = 15;

            var pairCount = checkPairsInArrayForSum(arrWholeNumbers, x);

            Console.WriteLine($"Output: {pairCount.ToString()}");
        }

        // static method to find and print sum of the pair equal to x
        static int checkPairsInArrayForSum(int[] arrWholeNumbers, int x)
        {
            var size = arrWholeNumbers.Length;
            var pairSumMatchCounter = 0;


            for (int i = 0; i < (size - 1); i++)
            {
                for (int j = (i + 1); j < size; j++)
                {
                    if (arrWholeNumbers[i] + arrWholeNumbers[j] == x)
                    {
                        pairSumMatchCounter++;
                    }
                }
            }

            return pairSumMatchCounter;
        }
    }
}
