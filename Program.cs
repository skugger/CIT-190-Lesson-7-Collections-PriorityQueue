using System;
using System.Collections;
using System.Collections.Generic;

namespace CIT_190_Lesson_7_Collections_PriorityQueue
{
    class Program
    {
        public static void Main()
        {

            PriorityQueue<string, int> bookTitles = new();

            {

                bookTitles.Enqueue("The Positronic Man", 2);
                bookTitles.Enqueue("The Caves of Steel", 4);
                bookTitles.Enqueue("The Naked Sun", 3);
                bookTitles.Enqueue("The Robots of Dawn", 5);
                bookTitles.Enqueue("Pebble in the Sky", 1);

                string firstTitle = bookTitles.Peek();
                Console.WriteLine("The highest priority book title is " + firstTitle);

                Console.WriteLine();
                Console.WriteLine("Do you want to delete it? (y/n)");
                string choice = Console.ReadLine();

                while (choice == "y" && bookTitles.Count > 1)
                {
                    bookTitles.Dequeue();
                    firstTitle = bookTitles.Peek();
                    Console.WriteLine("The highest priority book title is " + firstTitle);
                    Console.WriteLine("Do you want to delete it? (y/n)");
                    choice = Console.ReadLine();
                }
                Console.WriteLine();
                
                if (bookTitles.Count <= 0) 
                {
                    Console.WriteLine("All titles have been deleted.");
                }
            }
        }
    }
}