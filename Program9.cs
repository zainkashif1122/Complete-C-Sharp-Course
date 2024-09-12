using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml.XPath;

namespace Project9
{
    class Program
    {
        static int addition(int num1, int num2)
        {
            int result = num1 + num2;
            return result;
        }

        static int subtraction(int num1, int num2)
        {
            int result = num1 - num2;
            return result;
        }

        static int multiplication(int num1, int num2)
        {
            int result = num1 * num2;
            return result;
        }

        static int division(int num1 ,int num2)
        {
            int result = num1 / num2;
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers on which you want to perform operation: ");
            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("ENter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOperations you can perform: ");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Divison");

            Console.Write("\nEnter the number of operation you want to perform: ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine(num1 + " + " + num2 + " = " + addition(num1,num2));
                    break;

                case 2:
                    Console.WriteLine(num1 + " - " + num2 + " = " + subtraction(num1,num2));
                    break;

                case 3:
                    Console.WriteLine(num1 + " x " + num2 + " = " + multiplication(num1,num2));
                    break;

                case 4:
                    Console.WriteLine(num1 + " / " + num2 + " = " + division(num1,num2));
                    break;

                default:
                    Console.WriteLine("Error!");
                    break;
            }

            Console.ReadKey();            
        }
    }
}