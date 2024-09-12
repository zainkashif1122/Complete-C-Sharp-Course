using System;
using System.Collections.Generic;   //For list

namespace Project7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Apple");
            shoppingList.Add("Mangos");
            shoppingList.Add("Bananas");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Mangos");

            Console.WriteLine("-------------------------------------------------");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            Console.ReadKey();
        }
    }
}