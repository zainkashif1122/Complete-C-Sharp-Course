using System;
using System.Data;

namespace Project6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of names: ");
            int num = Convert.ToInt32(Console.ReadLine());

            string[] arrayOfNames = new string[num];

            Console.WriteLine("\nEnter " + arrayOfNames.Length + " names: ");
            for (int i = 0; i < arrayOfNames.Length; i++)
            {
                arrayOfNames[i] = Console.ReadLine();
            }

            Array.Sort(arrayOfNames);

            Console.WriteLine("\nSorted names are: ");
            for (int i = 0; i < arrayOfNames.Length; i++)
            {
                Console.WriteLine(arrayOfNames[i]);
            }

            Console.ReadKey();
        }
    }
}