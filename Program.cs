using System;
namespace Vs_Code_Projects
{
    class Program
    {
        static void Main(string[] arg)
        {   
            //Appearance

            Console.Title = "Skynet";                                //To change the name of console.
            Console.BackgroundColor = ConsoleColor.Green;            //To change the color of console background.
            Console.ForegroundColor = ConsoleColor.Black;            //To change the color of console foreground.
            Console.WindowHeight = 40;                               //To change the height of console.
            Console.WindowWidth = 120;                               //To change the width of console.

            //Console.WriteLine("Hello, World!");                    //Printing hello world on console.

            Console.WriteLine("Hey whats you name?");                //Printing on console.   
            Console.ReadLine();                                      //Reading from console.

            Console.ReadKey();                                       //To display console.
        }
    }
}