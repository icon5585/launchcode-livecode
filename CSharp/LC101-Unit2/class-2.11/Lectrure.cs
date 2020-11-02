using System;
using System.Collections.Generic;

/**
 * LC 101 - Unit 2 
 * Class 2.11
 * Chapter X - Sorting/Searching and Big O
 * Hank DeDona
 * 11/03/20
 */
namespace class_2._11
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // Today's bonus lecture will cover a simple sort method (bubble sort)
            // and a simple search method (linear search).

            // For these examples, we will start with a list (or array) of integers
            // as these are easier, concrete examples that don't involve complex
            // comparison logic necessary. i.e. 5 > 7, 3 < 9 and 4 = 4 always.
            BubbleSortExample();

            // Linear search for 48 example
            LinearSearchExample(48);

            // Linear search for 24 example (doesn't exist)
            LinearSearchExample(24);

            // In order to use a binary search, we must have a sorted list
            List<int> sortedList = BubbleSortExample();

            // Binary search for 48 example
            BinarySearchExample(sortedList, 48);

            // Binary search for 24 example (doesn't exist)
            BinarySearchExample(sortedList, 24);
        }


        private static List<int> BubbleSortExample()
        {
            // Create an unsorted list of integers
            List<int> unsortedList = GetUnsortedList();

            // Output unsorted list
            Console.WriteLine("Unsorted list: ");
            foreach (int i in unsortedList)
            {
                Console.Write(i + " ");
            }

            // Bubble sort
            // A bubble sort allows the larger values to "bubble up" to the end of the list
            // It has a BigO(n^2) where n is the number of elements in the collection (or list in this case)
            // After the first loop, the biggest number should be at the end of the list
            // After the 2nd loop, the 2nd biggest number should be at the end of the list - 1
            // etc. etc. hence we have to loop n^2 (n squared) times in order to sort a list in a WORST CASE SCENARIO
            for (int i = 0; i <= unsortedList.Count - 2; i++)
            {
                for (int j = 0; j <= unsortedList.Count - 2; j++)
                {
                    if (unsortedList[j] > unsortedList[j + 1])
                    {
                        int tempVal = unsortedList[j + 1];
                        unsortedList[j + 1] = unsortedList[j];
                        unsortedList[j] = tempVal;
                    }
                }
            }

            Console.WriteLine();
            // Output sorted list
            Console.WriteLine("Sorted list: ");
            foreach (int i in unsortedList)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();

            // List is now sorted and returning it
            return unsortedList;
        }

        private static void LinearSearchExample(int searchVal)
        {
            // Create an unsorted list of integers
            List<int> unsortedList = GetUnsortedList();

            // Linear search is exactly what it says, it searches through a linear data
            // structure (such as a list), until it finds what it needs (or doesn't)
            // It has a BigO(n) where n is the number of elements in the collection (or list in this case)
            // as the WORST CASE SCENARIO since the element (integer in this case) could be the last element.
            // Linear searches work on both sorted and UNSORTED collections, there are MUCH more efficient
            // search methods, but they work mostly on SORTED collections.

            Console.WriteLine("Searching for " + searchVal + " in the list");

            bool found = false;
            int loc = 0;
            // Linear search
            // Note: You can also return/store the index in the list when you find it as we are doing
            // with loc
            foreach (int i in unsortedList)
            {
                if (i == searchVal)
                {
                    found = true;
                    break;
                }
                loc++;
            }

            if (found)
            {
                Console.WriteLine("Found the search value [" + searchVal + "] in the list at location [" + loc + "]");
                Console.WriteLine("Number of loops needed: " + loc);
            }
            else
            {
                Console.WriteLine("Did not find the search value [" + searchVal + "] in the list");
            }

        }

        private static void BinarySearchExample(List<int> sortedList, int searchVal)
        {
            // Binary search is an efficient "divide and conquer" search algorithm
            // it REQUIRES a SORTED collection (like a list).
            // Binary search has a BigO(log n) which is way more efficient than the linear search
            // Note: In computer science, we always have a base of 2 when talking in logarithms, so it's really log2n (log base 2 of n)
            // where n is the number of elements in the collection

            int lowerBound = 0;
            int upperBound = sortedList.Count;
            int midPoint = 0;
            bool found = false;
            int count = 0;

            // Loop while the lowerbound (set to 0) is less than the upper bound (6), these will continue to get closer to each
            // other while looping and comparing
            while (lowerBound <= upperBound)
            {
                count++;        // For teaching purposes to show how much more efficient it is!

                midPoint = (lowerBound + upperBound) / 2;   // Get the midpoint of the list (0 + 7) / 2 (as a double: 3.5, as an integer: 3)

                // If the element at the midpoint is greater than the value I'm searching for, set the upperBound to the midpoint - 1 
                if (sortedList[midPoint] > searchVal)
                {
                    upperBound = midPoint - 1;
                }
                // If the midpoint is less than the value I'm searching for, set the lowerBound to the midpoint + 1
                else if (sortedList[midPoint] < searchVal)
                {
                    lowerBound = midPoint + 1;
                }
                // If the midpoint is equal to the search value, we found it!
                // Note: We could also just return it here if we found it
                else
                {
                    found = true;
                    break;
                }
            }

            if(found)
            {
                Console.WriteLine("Found the search value [" + searchVal + "] in the list at location [" + midPoint + "]");
                Console.WriteLine("Number of loops needed: " + count);
            } else
            {
                Console.WriteLine("Did not find the search value [" + searchVal + "] in the list");
            }
        }

        private static List<int> GetUnsortedList()
        {
            // Create an unsorted list of integers
            List<int> unsortedList = new List<int>
            {
                5,21,99,22,1,33,48
            };

            return unsortedList;
        }
    }
}
