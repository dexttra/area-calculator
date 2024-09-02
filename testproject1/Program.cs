using GeometryCalculations;

// Создание экземпляра круга с радиусом 5
IShape circle = new Circle(5);
double circleArea = AreaCalculator.CalculateArea(circle);
Console.WriteLine($"Площадь круга с радиусом 5: {circleArea}");

// Создание экземпляра треугольника с длинами сторон 3, 4 и 5
IShape triangle = new Triangle(3, 4, 5);
double triangleArea = AreaCalculator.CalculateArea(triangle);
Console.WriteLine($"Площадь треугольника со сторонами 3, 4 и 5: {triangleArea}");
