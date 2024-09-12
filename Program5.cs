using System;

namespace Project5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number (1-5): ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            switch (num)
            {
                case 1:
                    Console.WriteLine("ONE");
                    break;

                case 2:
                    Console.WriteLine("TWO");
                    break;

                case 3:
                    Console.WriteLine("THREE");
                    break;

                case 4:
                    Console.WriteLine("FOUR");
                    break;

                case 5:
                    Console.WriteLine("FIVE");
                    break;

                default:
                    Console.WriteLine("DEFAULT");
                    break;
            }

            Console.ReadKey();
        }
    }
}