using System;

namespace ArrayMaxResult
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 5;
            int[] inputArray = new int[length];
            for(int i=0; i<length; i++)
            {
                Console.Write($"Enter a number between 1 and 10 ({i} entered): ");
                inputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Select a value to see the score of that value: ");       
            int selectedVal = Convert.ToInt32(Console.ReadLine());
            int score = CalculateScore(inputArray, selectedVal);
            Console.WriteLine($"Score: {score}");
        }
        private static int CalculateScore(int[] array, int val)
        {
            int score = 0;
            foreach(int arrayVal in array)
            {
                if(arrayVal == val)
                {
                    score += arrayVal;
                }
            }
            return score;
        }
    }
}
