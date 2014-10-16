using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S02.L03A
{
    class Program
    {
        static void Main(string[] args)
        {
        }
        private static Shape CreateShape(ShapeType shapeType)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Reads user input of length or width.
        /// </summary>
        /// <param name="prompt"></param>
        /// <returns></returns>
        private static double ReadDoubleGreaterThanZero(string prompt)
        {
            double value;

            do
            {
                Console.Write(prompt); 
                if(double.TryParse(Console.ReadLine(), out value) && value >= 0)
                {
                    return value;
                }
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\nFEL! Ange ett flyttal större än 0.\n");
                Console.ResetColor();
            } while (true);
        }

        /// <summary>
        /// Displays the main menu.
        /// </summary>
        private static void ViewMenu()
        {
//Menyn i exemplet SecondZoo var så snyggt så jag tog själva "rutan" därifrån.
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ╔═══════════════════════════════════╗ ");
            Console.WriteLine(" ║        Geometriska figurer        ║ ");
            Console.WriteLine(" ╚═══════════════════════════════════╝ ");
            Console.WriteLine("\n 0. Avsluta.");
            Console.WriteLine("\n 1. Ellips.");
            Console.WriteLine("\n 2. Rektangel.");
            Console.WriteLine("\n═════════════════════════════════════");
            Console.Write("\n Ange menyval [0-2]:");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            
        }

    }
}
