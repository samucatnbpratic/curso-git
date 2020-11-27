using ConsoleCurso.ExercicioAbstract.Entities.Enums;

namespace ConsoleCurso.ExercicioAbstract.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        protected AbstractShape(Color color)
        {
            Color = color;
        }

        public abstract double Area();


    }
}
