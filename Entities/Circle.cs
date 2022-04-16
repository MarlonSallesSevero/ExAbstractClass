using System;
using ExClass_e_Metodos_Abstratos.Entities.Enums;

namespace ExClass_e_Metodos_Abstratos.Entities
{
    internal class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(Color color, double radius) : base(color)
        {
            Radius = radius;
        }
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
