using ConsoleCurso.ExercicioAbstract.Entities.Enums;

namespace ConsoleCurso.ExercicioAbstract.Entities
{
    class Rectangle : AbstractShape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height, Color color ) : base(color)
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
