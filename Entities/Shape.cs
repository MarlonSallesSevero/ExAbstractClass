﻿using ExClass_e_Metodos_Abstratos.Entities.Enums;

namespace ExClass_e_Metodos_Abstratos.Entities
{
    internal abstract class Shape
    {
        public Color Color { get; set; }
        public Shape(Color color)
        {
            Color = color;
        }
        public abstract double Area();
    }
}
