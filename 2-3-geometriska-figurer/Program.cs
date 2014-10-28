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
                Console.WriteLine("tryck en tagent för att fortsätta, esc avslutar");
                Console.ResetColor();
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
        private static Shape CreateShape(ShapeType shapetype)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========================================");
            switch(shapetype)
            {
                case ShapeType.Ellipse:
                    Console.WriteLine("=                 Ellips                 =");
                    break;

                case ShapeType.Rectangle:
                    Console.WriteLine("=                Rektangel               =");
                    break;
            }
            Console.WriteLine("==========================================");
            Console.ResetColor();

            double length = ReadDoubleGreaterThanZero("Ange längden: ");
            double width = ReadDoubleGreaterThanZero("Ange Bredden: ");

            if(shapetype == ShapeType.Ellipse)
            {
                return new Ellipse(length, width);
            }
            else
            {
                return new Rectangle(length, width);
            }
        }
        private static double ReadDoubleGreaterThanZero(string prompt)
        {   
            while(true)
            {
                Console.Write(prompt);
                double something = double.Parse(Console.ReadLine());
                if (something > 0) 
                {
                    return something;
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
            Console.WriteLine("0. Avsluta.");
            Console.WriteLine("1. Ellips.");
            Console.WriteLine("2. Rektangel.");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            
        }
        private static void ViewShapeDetail(Shape shape)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("==========================================");
            Console.WriteLine("=            Detaljer                    =");
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.WriteLine(shape.ToString());
            Console.WriteLine("==========================================");

            



        }
    }
}
