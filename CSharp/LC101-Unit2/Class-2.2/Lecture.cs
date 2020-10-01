using System;
using System.Collections.Generic;

/**
 * LC 101 - Unit 2 
 * Class 2.2
 * Chapter 3 - Control Flow & Collections
 * Hank DeDona
 * 10/01/20
 */
namespace Class_2._2
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // 3.1.1-3.1.3 if/else/else if Statements
            String name = "Milo";

            if(name.Equals("Milo")) {
                Console.WriteLine("My name is Milo!");
            } else if(name.Equals("Kitty")) {
                Console.WriteLine("My name is Kitty!");
            } else {
                Console.WriteLine("My name is neither Milo nor Kitty");
            }

            // 3.1.4 Switch statements
            // Switch statements are basically many nested if/else if's in one nice block
            // Note the break statements, these make sure that the case doesn't "fall through"
            // Falling through allows for multiple cases to run the same code.

            Console.WriteLine("Enter an integer to represent a day of the week: ");
            string dayString = Console.ReadLine();
            int dayNum = int.Parse(dayString);

            string day;
            switch (dayNum)
            {
                case 0:
                    day = "Sunday";
                    break;
                case 1:
                    day = "Monday";
                    break;
                case 2:
                    day = "Tuesday";
                    break;
                case 3:
                    day = "Wednesday";
                    break;
                case 4:
                    day = "Thursday";
                    break;
                case 5:
                    day = "Friday";
                    break;
                case 6:
                    day = "Saturday";
                    break;
                default:
                    // in this example, this block runs if none of the above blocks match
                    day = "Int does not correspond to a day of the week";
                    break;
            }
            Console.WriteLine("The day you entered represents: " + day);

            // 3.2 - Loops
            // 3.2.1 for loops

            // What this is saying is loop, setting j to 0 until j is less than 10 and increment it by 1
            // Note j++ is the same as j = j + 1
            for (int j = 0; j < 10; j++)
            {
                Console.WriteLine(j);
            }

            // 3.2.2 foreach loops
            // foreach loops allow you to loop over collections (read like for each item in a collection, do something)
            int[] nums = { 1, 1, 2, 3, 5, 8, 13, 21 };

            foreach (int k in nums)
            {
                Console.WriteLine(k);
            }

            // 3.2.3 while loops
            // while loops keep looping while the statement is true, in this case while i is less than 3
            // Note you can write this as a for loop also
            int i = 0;
            while (i < 3)
            {
                Console.WriteLine(i);
                i++;
            }

            // 3.2.4 do-while loops
            // do-while loops are just like while loops except that they are GUARANTEED to run at least once

            // This example will run only once even though the conditional is false
            do
            {
                Console.WriteLine("Hello, World... but only once");
            } while (false);

            // 3.2.5 Break statements in loops
            // If we want to end a loop before it's had a chance to run it's course, we can BREAK out of it
            // We might do this if we're searching for something in a collection, once we find it, it's unnecessary to keep looping

            int[] someInts = { 1, 10, 2, 3, 5, 8, 10 };
            int searchTerm = 10;
            foreach (int oneInt in someInts)
            {
                if (oneInt == searchTerm)
                {
                    Console.WriteLine("Found it!");
                    break;                      // Without this break, the loop will keep looping even after it's found (wasted CPU cycles)
                }
            }

            // 3.2.6 Continue statements in loops
            // While break will terminate the entire loop, continue will terminate the current running iteration of a loop
            int[] someInts2 = { 1, 10, 2, 3, 5, 8, 10 };
            int searchTerm2 = 10;
            foreach (int oneInt in someInts2)
            {
                if (oneInt == searchTerm2)
                {
                    Console.WriteLine("Found it!");
                    continue;                       // Without this continue, we will write "found it" and "not here" for the value 10
                }
                Console.WriteLine("Not here");
            }

            // 3.3 Collections
            // There are many provided collections that you should familiarize yourself with including Arrays, Lists and Dictionaries

            // 3.4 Lists
            // Note that lists are typed, what this means is you can only store 1 type of object in a given list

            List<string> studentsList = new List<string>();         // Can only store strings
            List<double> gradesList = new List<double>();           // Can only store doubles

            studentsList.Add("Jim");
            studentsList.Add("Billy");

            // You can iterate over a list using a foreach loop. In this example for each string in the list of students
            foreach (string currentStudent in studentsList)
            {
                // What the foreach loop does is store each individual student in the new string currentStudent
                Console.WriteLine(currentStudent);
            }

            // 3.4.2 List methods
            // Add() - Adds an item to the List	
            // Contains() - Checks to see if the List contains a given item, returning a Boolean	
            // IndexOf() - Looks for an item in a List, returns the index of the first occurrence of the item if it exists, returns -1 otherwise
            // Sort() - Rearranges the elements of an List into ascending order
            // ToArray() - Returns an Array containing the elements of the List

            // 3.5 Arrays
            // Note that arrays require the size up front, if we add more than 30, we need to recreate the array and copy everything over
            int maxStudents = 30;
            string[] studentsArray = new string[maxStudents];
            double[] gradesArray = new double[maxStudents];

            studentsArray[0] = "Suzy";
            studentsArray[1] = "Amber";

            // You can iterate over an array the same way you would in a list!
            foreach (string currentStudent in studentsArray)
            {
                Console.WriteLine(currentStudent);
            }

            // 3.6 Dictionaries
            // Dictionaries allow for key->value pairs similar to a dictionary where the word is the key and definition the value
            Dictionary<string, double> studentsDictionary = new Dictionary<string, double>();

            // Here we can store a student's name as the key and their singluar grade as a double value
            studentsDictionary.Add("Jim", 42.9);
            studentsDictionary.Add("Amber", 93.2);

            // We can use a foreach loop with a dictionary as well, even though it's normally accessed via a key
            // The returned value is a KeyValuePair object, notice that it requires the same data types as the dictionary
            double gradeSum = 0.0;
            foreach (KeyValuePair<string, double> currentStudentPair in studentsDictionary)
            {
                Console.WriteLine(currentStudentPair.Key + " (" + currentStudentPair.Value + ")");
                gradeSum += currentStudentPair.Value;
            }

            Console.WriteLine("Total grades: " + gradeSum);

            // 3.6.1 - Dictionary methods
            // Add() - Add a key/value pair to a dictionary
            // ContainsKey() - Returns a boolean indicating whether or not the dictionary contains a given key
            // ContainsValue() - Returns a boolean indicating whether or not the dictionary contains a given value
            // Keys - Returns a collection containing all keys in the dictionary. This collection may be used in a foreach loop just as lists are,
            // but the dictionary may not be modified within such a loop
            // Values - Returns a collection containing all values in the dictionary. This collection may be used in a foreach loop just as lists are
            // Count - Returns the number of items in the dictionary, as an int
        }
    }
}
