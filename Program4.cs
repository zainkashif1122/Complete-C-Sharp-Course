using System;
using System.IO.Compression;

namespace Project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("1 + 2 + 3 = ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num == 6)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.Write("(2 * 3) + 4 = ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 10)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.WriteLine("3 + (8 / 4) * 2 = ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num == 7)
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong!");
            }

            Console.ReadKey();
        }
    }
}