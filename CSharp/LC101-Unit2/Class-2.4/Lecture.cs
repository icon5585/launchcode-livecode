using System;
using System.Collections.Generic;

/**
 * LC 101 - Unit 2 
 * Class 2.4
 * Chapter X - Queues & Stacks
 * Hank DeDona
 * 10/08/20
 */
namespace Class_2._4
{
    class Lecture
    {
        static void Main(string[] args)
        {
            // There is no actual lecture today, no assigned reading at least.
            // Wanted to take this time to introduce 2 new linear data structures

            // The Queue - FIFO (First In - First Out)
            // Think of it as a line, the first person in the line is the first person served
            Queue<string> students = new Queue<string>();

            // Add students to the queue using Enqueue()
            students.Enqueue("Allison");
            students.Enqueue("Billy");
            students.Enqueue("Cameron");
            students.Enqueue("Deborah");

            // You can "peek" at the front of the queue using Peek()
            Console.WriteLine(students.Peek());                 // Allison

            // You can see if the queue "contains" an element
            Console.WriteLine(students.Contains("Billy"));      // True
            Console.WriteLine(students.Contains("Emily"));      // False

            // To get the size of the queue, use the Count property
            Console.WriteLine(students.Count);                  // 4

            // Remove students from the queue using Dequeue()
            Console.WriteLine(students.Dequeue());
            Console.WriteLine(students.Dequeue());
            Console.WriteLine(students.Dequeue());
            Console.WriteLine(students.Dequeue());

            // What happens if you try and Dequeue more than in the queue? It throws an InvalidOperationException
            //Console.WriteLine(students.Dequeue());


            // The Stack - LIFO (Last In - First Out)
            // Think of it as a stack of lunch trays, when you push one onto the stack it's the first removed from the top.
            Stack<string> states = new Stack<string>();

            // Add states to the stack by using Push()
            states.Push("Alabama");
            states.Push("Connecticut");
            states.Push("Delaware");
            states.Push("Florida");

            // You can "peek" at the top of the stack using Peek();
            Console.WriteLine(states.Peek());                    // Florida

            // You can see if the stack "contains" an element
            Console.WriteLine(states.Contains("Delaware"));      // True
            Console.WriteLine(states.Contains("Georgia"));       // False

            // To get the size of the stack, use the Count property
            Console.WriteLine(states.Count);                     // 4

            // Remove states from the stack using Pop()
            Console.WriteLine(states.Pop());
            Console.WriteLine(states.Pop());
            Console.WriteLine(states.Pop());
            Console.WriteLine(states.Pop());

            // Same thing happens with stack as it does with queue if you try and pop one too many elements off the stack.
            // It throws an InvalidOperationException
        }
    }
}
