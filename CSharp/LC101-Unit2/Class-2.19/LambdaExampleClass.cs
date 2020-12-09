using System;
using System.Linq;

namespace Class_2._19
{
    public class LambdaExampleClass
    {
        // Lambda select example
        public static void SelectExample()
        {
            int[] nums = { 1, 2, 3, 4 };
            // 20.2.1 An example of a lambda 
            var doubledNums = nums.Select(x => 2 * x);
            Console.WriteLine(string.Join(" ", doubledNums));
        }

        // For-each example of the select lambda
        public static void SelectExampleAsForEach()
        {
            // Note: This code does the EXACT SAME THING as the select lambda above
            int[] nums = { 1, 2, 3, 4 };
            int[] doubledNums = new int[4];
            int counter = 0;
            foreach (int curNum in nums) {
                doubledNums[counter] = curNum * 2;
                counter++;
            }

            Console.WriteLine(string.Join(" ", doubledNums));
        }

        public static void WhereExample()
        {
            int[] nums = { 1, 2, 3, 4 };
            var evens = nums.Where(x => (x % 2 == 0));
            Console.WriteLine(string.Join(" ", evens));
        }

        public static void WhereExampleAsForEach()
        {
            int[] nums = { 1, 2, 3, 4 };
            int counter = 0;
            int[] evenNums = new int[2];
            foreach (int curNum in nums)
            {
                // If it's an even number, i.e. if number modulo 2 equals 0
                if(curNum % 2 == 0)
                {
                    evenNums[counter] = curNum;
                    counter++;
                }
            }

            Console.WriteLine(string.Join(" ", evenNums));
        }
    }
}
