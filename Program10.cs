using System;
using System.Collections.Generic;

namespace Project10
{
    class Wizard
    {
            private string name;
            private string favoriteSpell;
            private int spellSlot;
            private float experience;

            public Wizard()
            {
                name = " ";
                favoriteSpell = " ";
                spellSlot = 0;
                experience = 0f;
            }

            public Wizard(string n, string f, int s,float e)
            {
                name = n;
                favoriteSpell = f;
                spellSlot = s;
                experience = e;
            }

    }
    class Program
    {
        static void Main()
        {
            

            Console.ReadKey();
        }
    }
}