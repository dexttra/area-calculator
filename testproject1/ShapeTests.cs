
using Xunit;
namespace GeometryCalculations
{
    public class ShapeTests
    {
        [Fact]
        public void CircleArea_ShouldBeCorrect()
        {
            var circle = new Circle(5);
            double area = circle.GetArea();
            Assert.Equal(78.53981633974483, area, 8);
        }

        [Fact]
        public void TriangleArea_ShouldBeCorrect()
        {
            var triangle = new Triangle(3, 4, 5);
            double area = triangle.GetArea();
            Assert.Equal(6, area, 8);
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldBeTrue()
        {
            var triangle = new Triangle(3, 4, 5);
            Assert.True(triangle.IsRightTriangle());
        }

        [Fact]
        public void Triangle_IsRightTriangle_ShouldBeFalse()
        {
            var triangle = new Triangle(3, 4, 6);
            Assert.False(triangle.IsRightTriangle());
        }

        [Fact]
        public void AreaCalculator_ShouldCalculateArea_ForCircle()
        {
            IShape shape = new Circle(5);
            double area = AreaCalculator.CalculateArea(shape);
            Assert.Equal(78.53981633974483, area, 8);
        }

        [Fact]
        public void AreaCalculator_ShouldCalculateArea_ForTriangle()
        {
            IShape shape = new Triangle(3, 4, 5);
            double area = AreaCalculator.CalculateArea(shape);
            Assert.Equal(6, area, 8);
        }
    }
}