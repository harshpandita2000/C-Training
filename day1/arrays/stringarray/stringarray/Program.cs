//Create a string array containing 5 names. 
//Write a program to check if a given name exists in the array 
//and return its index if found.

using System;
namespace stringarray
{
    internal class Program
    {
        static void Main()
        {
            string[] names = new string[5];
            Console.WriteLine("Enter 5 names:");

            for (int i = 0; i < names.Length; i++)
            {
                Console.Write($"Enter name {i + 1}: ");
                names[i] = Console.ReadLine();
            }

            Console.Write("Enter the name to search: ");
            string sname = Console.ReadLine();

            List<int> indices = new List<int>();
            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == sname)
                {
                    indices.Add(i);
                }
            }

            if (indices.Count > 0)
            {
                foreach (int index in indices)
                {
                    Console.WriteLine(index);
                }
            }
            else
            {
                Console.WriteLine("Name not found");
            }
        }
    }
}
