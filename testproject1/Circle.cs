namespace GeometryCalculations
{
    public class Circle : IShape
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Радиус должен быть положительным числом");

            Radius = radius;
        }

        public double GetArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}