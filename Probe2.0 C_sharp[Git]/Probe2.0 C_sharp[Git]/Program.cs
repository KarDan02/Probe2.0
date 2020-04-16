using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
//*** Konvertierung in Zahlensysteme
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Titel("Dies ist ein Test", ConsoleColor.Red);
            Console.WriteLine("ttt");
            Console.ReadKey();
        }
        static void Titel(string titel, ConsoleColor textfarbe)
        {
            int breite = Console.WindowWidth;
            int textlen = titel.Length;
            ConsoleColor aktTextFarbe = Console.ForegroundColor;
            Console.Clear();
            Console.ForegroundColor = textfarbe;
            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }

            for (int i = 0; i < (breite-textlen)/2; i++)
            {
                Console.Write(" ");
            }

            Console.WriteLine(titel);

            for (int i = 0; i < Console.WindowWidth; i++)
            {
                Console.Write("*");
            }
            Console.ForegroundColor = aktTextFarbe;
        }
    }
}
