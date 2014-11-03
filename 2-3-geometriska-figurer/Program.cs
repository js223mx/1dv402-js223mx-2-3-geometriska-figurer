using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_3_geometriska_figurer
{
    public enum ShapeType {Rectangle, Ellipse}
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                ViewMenu();
                switch (Console.ReadLine())
                {
                    case "0":
                        return;

                    case "1":
                        ViewShapeDetail((CreateShape(ShapeType.Ellipse)));
                        break;

                    case "2":
                        ViewShapeDetail((CreateShape(ShapeType.Rectangle)));
                        break;

                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("FEL! Vänligen ange ett nummer mellan 0 och 2.");
                        Console.ResetColor();
                        break;
                }

                Console.BackgroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nTryck en tagent för att fortsätta, esc avslutar\n");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType shapetype)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n==========================================");
            switch(shapetype)
            {
                case ShapeType.Ellipse:
                    Console.WriteLine("=                 Ellips                 =");
                    break;

                case ShapeType.Rectangle:
                    Console.WriteLine("=                Rektangel               =");
                    break;
            }
            Console.WriteLine("==========================================\n");
            Console.ResetColor();

            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange Bredden: ");
            Console.WriteLine();

            if(shapetype == ShapeType.Ellipse)
            {
                return new Ellipse(length, width);
            }
            else
            {
                return new Rectangle(length, width);
            }
        }

        //metod som retunerar ett flyttal större än 0
        private static double ReadDoubleGreaterThanZero(string prompt)
        {   
            while(true)
            {
                Console.Write(prompt);
                double floatnumber = double.Parse(Console.ReadLine());
                if (floatnumber > 0) 
                {
                    return floatnumber;
                }
                else 
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("FEL! Ange ett flyttal större än 0.");
                    Console.ResetColor();
                }
            }
            

        }
        private static void ViewMenu()
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========================================");
            Console.WriteLine("=                                        ="); 
            Console.WriteLine("=          Geometriska figurer           =");
            Console.WriteLine("=                                        =");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine("\n0. Avsluta.");
            Console.WriteLine("\n1. Ellips.");
            Console.WriteLine("\n2. Rektangel.");
            Console.WriteLine("\n==========================================\n");
            Console.WriteLine("Ange menyval [0-2]: ");
            Console.WriteLine();

            
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========================================");
            Console.WriteLine("=            Detaljer                    =");
            Console.WriteLine("==========================================\n");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("==========================================");

            



        }
    }
}
