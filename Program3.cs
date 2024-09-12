using System;
using System.Net.NetworkInformation;
namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2,n3;

            Console.Write("Enter first number: ");
            n1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number: ");
            n2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number: ");
            n3 = Convert.ToDouble(Console.ReadLine());

            double avg = (n1+n2+n3)/3;

            Console.WriteLine("Average of " + n1 + ", " + n2 + " and " + n3 + " is: " + avg + ". ");

            Console.ReadKey();
        }
    }
}