using System;
using System.Collections.Generic;

namespace Array_App
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a one-dimensional array of strings
            string[] stringArray = { "Apple", "Banana", "Orange" };

            // Prompt the user to select an index
            Console.WriteLine("Select an index of the string array (0, 1, or 2):");
            string indexInput = Console.ReadLine();
            int index = Convert.ToInt32(indexInput);

            // Check if the index is within the array bounds
            if (index >= 0 && index < stringArray.Length)
            {
                // Display the string at the selected index
                Console.WriteLine("Selected string: " + stringArray[index]);
            }
            else
            {
                // Display a message for invalid index
                Console.WriteLine("Invalid index selection.");
            }

            // Create a one-dimensional array of integers
            int[] intArray = { 10, 20, 30 };

            // Prompt the user to select an index
            Console.WriteLine("Select an index of the integer array (0, 1, or 2):");
            indexInput = Console.ReadLine();
            index = Convert.ToInt32(indexInput);

            // Check if the index is within the array bounds
            if (index >= 0 && index < intArray.Length)
            {
                // Display the integer at the selected index
                Console.WriteLine("Selected integer: " + intArray[index]);
            }
            else
            {
                // Display a message for invalid index
                Console.WriteLine("Invalid index selection.");
            }

            // Create a list of strings
            List<string> stringList = new List<string> { "Dog", "Cat", "Bird" };

            // Prompt the user to select an index
            Console.WriteLine("Select an index of the string list (0, 1, or 2):");
            indexInput = Console.ReadLine();
            index = Convert.ToInt32(indexInput);

            // Check if the index is within the list bounds
            if (index >= 0 && index < stringList.Count)
            {
                // Display the string at the selected index
                Console.WriteLine("Selected string: " + stringList[index]);
            }
            else
            {
                // Display a message for invalid index
                Console.WriteLine("Invalid index selection.");
            }
        }
    }
}
