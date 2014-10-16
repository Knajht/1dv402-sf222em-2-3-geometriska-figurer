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
            bool exit = false;
            ShapeType type = ShapeType.Ellipse;

            do
	        {
                Console.Clear();
                ViewMenu();

                try
                {

                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0:
                            exit = true;
                            break;
                        case 1:
                            type = ShapeType.Ellipse;
                            break;
                        case 2:
                            type = ShapeType.Rectangle;
                            break;
                        default:
                            throw new ArgumentException();
                    }
                }
                catch
                {
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("\nFEL! Ange ett nummer mellan 0 och 2.");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\nTryck tangent för att fortsätta");
                    Console.ResetColor();
                    Console.CursorVisible = false;
                    Console.ReadKey();
                }

                Shape shape = CreateShape(type);
                ViewShapeDetail(shape);

                Console.WriteLine("\nTryck tangent för att fortsätta");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey();
	         
	        } while (!exit);





            

            //Shape shape = new Ellipse;
        }

        private static Shape CreateShape(ShapeType shapeType)
        {
            //Console.WriteLine(String.Format("Ny Shape av en {0}", shapeType.ToString()));
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    return new Ellipse(10, 20);
                case ShapeType.Rectangle:
                    return new Rectangle(20, 40);
                default:
                    throw new NotImplementedException();
            }
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
            Console.WriteLine(" ===================================== ");
            Console.WriteLine(" =        Geometriska figurer        = ");
            Console.WriteLine(" ===================================== ");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta.");
            Console.WriteLine("\n 1. Ellips.");
            Console.WriteLine("\n 2. Rektangel.");
            Console.WriteLine("\n======================================");
            Console.Write("\n Ange menyval [0-2]:");
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("DETALJER");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n======================================");
        }

    }
}
