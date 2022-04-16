using System;
using System.Globalization;
using ExClass_e_Metodos_Abstratos.Entities;
using ExClass_e_Metodos_Abstratos.Entities.Enums;
using System.Collections.Generic;

namespace ExClass_e_Metodos_Abstratos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Shape> listShapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Shape #{i} data:");
                Console.Write("Rectangle or Circle (r/c)?");
                char op = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red):");
                Color cor = (Color)Enum.Parse(typeof(Color), Console.ReadLine());
                if(op == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    listShapes.Add(new Rectangle(cor, width, height));
                }
                else
                {
                    Console.Write("Radius: ");
                    double r = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                    listShapes.Add(new Circle(cor, r));
                }
            }
            Console.WriteLine();
            Console.WriteLine("SHAPE AREAS:");
            foreach (Shape shape in listShapes)
            {
                Console.WriteLine(shape.Area().ToString("F2",CultureInfo.InvariantCulture));
            }
        }
    }
}
