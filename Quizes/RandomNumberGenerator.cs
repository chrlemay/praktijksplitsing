using System;
using System.Collections.Generic;
using System.Text;

namespace Quizes
{
    public class RandomNumberGenerator
    {
        private Random RandomGenerator { get;}

        public RandomNumberGenerator()
        {
            RandomGenerator = new Random();
        }

        public int Next(int maxValue, int minValue = 0)
        {
            return RandomGenerator.Next(minValue, maxValue+1);
        }

        public List<int> RandomNumberList(int length)
        {
            var numbers = new List<int>();

            while(numbers.Count != length)
            {
                int number = Next(length, 1);

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            return numbers;
        }

        public List<int> RandomNumberList(int maxValue, int returnLength, int requiredNumber)
        {
            var numbers = new List<int>();

            while (numbers.Count != returnLength)
            {
                int number = Next(maxValue);

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }

            if (!numbers.Contains(requiredNumber))
            {
                numbers[Next(returnLength-1)] = requiredNumber;
            }

            return numbers;
        }

        public List<int> RandomNumberList(int maxValue, int returnLength, int[] requiredNumbers)
        {
            var numbers = new List<int>();
            int number = -1;

            while (numbers.Count != returnLength)
            {
                number = Next(maxValue, requiredNumbers.Length);

                if (!numbers.Contains(number))
                {
                    numbers.Add(number);
                }
            }
            
            numbers[Next(requiredNumbers.Length - 1)] = Next(requiredNumbers.Length - 1);

            return numbers;
        }
    }
}
