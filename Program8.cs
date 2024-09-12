using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Project8
{
    class Program
    {
        static void alienInfo()
        {
            Random numGen = new Random();

            string name = "X-" + numGen.Next(1000,9999);
            int age = numGen.Next(100,500);

            Console.WriteLine("Hello, I'm an Alien ,My name is " + name + " and I'm " + age + " years old.");
        }
        static void Main(string[] args)
        {
            alienInfo();

            Console.WriteLine("-----------------------------------------------------------");

            alienInfo();
            
            Console.ReadKey();
        }
    }
}