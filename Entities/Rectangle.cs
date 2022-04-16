using ExClass_e_Metodos_Abstratos.Entities.Enums;

namespace ExClass_e_Metodos_Abstratos.Entities
{
    internal class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(Color color, double width, double height)
            :base(color)
        {
            Width = width;
            Height = height;
        }
        public override double Area()
        {
            return Width * Height;
        }
    }
}
