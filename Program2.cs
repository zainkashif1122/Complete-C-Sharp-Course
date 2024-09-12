using System;

namespace Project_2
{
    class Program
    {
        static void Main(string [] args)
        {

            int num1;
            int num2;

            Console.Write("Input first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;
            Console.WriteLine("\nAddition of two numbers: " + result);

            result = num1 - num2;
            Console.WriteLine("Subtraction of two numbers: " + result);

            result = num1 * num2;
            Console.WriteLine("Multiplication of two numbers: " + result);

            result = num1 / num2;
            Console.WriteLine("Division of two numbers: " + result);

            Console.ReadKey();
        }
    }
}