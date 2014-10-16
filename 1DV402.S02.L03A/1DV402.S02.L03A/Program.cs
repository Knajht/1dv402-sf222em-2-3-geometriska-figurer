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

                //Prompts the user if the intended shape is an ellipse or a rectangle, sets it using the enum ShapeType
                try
                {
                    switch (int.Parse(Console.ReadLine()))
                    {
                        case 0:
                            exit = true;
                            continue;
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
                    Console.WriteLine("\n FEL! Ange ett nummer mellan 0 och 2.");
                    Console.BackgroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("\n Tryck tangent för att fortsätta");
                    Console.ResetColor();
                    Console.CursorVisible = false;
                    Console.ReadKey();
                    continue;
                }

                Shape shape = CreateShape(type);
                ViewShapeDetail(shape);

                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("\n Tryck tangent för att fortsätta");
                Console.ResetColor();
                Console.CursorVisible = false;
                Console.ReadKey();
	        } while (!exit);
        }

        /// <summary>
        /// Creates a new shape of the type specified in the form of enum ShapeType
        /// </summary>
        private static Shape CreateShape(ShapeType shapeType)
        {
            switch (shapeType)
            {
                case ShapeType.Ellipse:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n");
                    Console.WriteLine("   =================================   ");
                    Console.WriteLine("  =             Ellips              =  ");
                    Console.WriteLine("   =================================   \n");
                    Console.ResetColor();
                    return new Ellipse(ReadDoubleGreaterThanZero(" Ange längden: "), ReadDoubleGreaterThanZero(" Ange bredden: "));
                case ShapeType.Rectangle:
                    Console.BackgroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine("\n");
                    Console.WriteLine("   =================================   ");
                    Console.WriteLine("  =            Rektangel            =  ");
                    Console.WriteLine("   =================================   \n");
                    Console.ResetColor();
                    return new Rectangle(ReadDoubleGreaterThanZero(" Ange längden: "), ReadDoubleGreaterThanZero(" Ange bredden: "));
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
                Console.WriteLine("\n FEL! Ange ett flyttal större än 0.\n");
                Console.ResetColor();
            } while (true);
        }

        /// <summary>
        /// Displays the main menu.
        /// </summary>
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" ===================================== ");
            Console.WriteLine(" =                                   = ");
            Console.WriteLine(" =        Geometriska figurer        = ");
            Console.WriteLine(" =                                   = ");
            Console.WriteLine(" ===================================== ");
            Console.ResetColor();
            Console.WriteLine("\n 0. Avsluta.");
            Console.WriteLine("\n 1. Ellips.");
            Console.WriteLine("\n 2. Rektangel.");
            Console.WriteLine("\n======================================");
            Console.Write("\n Ange menyval [0-2]:");
        }

        /// <summary>
        /// Presents the information of a shape in a very nice way by calling custom ToString() in class Shape
        /// </summary>
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("");
            Console.WriteLine("    ===============================    ");
            Console.WriteLine("  ====         Detaljer          ====  ");
            Console.WriteLine("    ===============================    \n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("\n======================================");
        }
    }
}
