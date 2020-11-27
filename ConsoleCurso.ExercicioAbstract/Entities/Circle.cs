using ConsoleCurso.ExercicioAbstract.Entities.Enums;
using System;

namespace ConsoleCurso.ExercicioAbstract.Entities
{
    class Circle : AbstractShape
    {
        public double Radius { get; set; }

        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }


        //calcula circulo  - pi * radio elevado a 2
        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
