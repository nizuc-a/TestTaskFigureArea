using TestTaskFigureArea;
using TestTaskFigureArea.Classes;

namespace TestTaskFigureAreaTest;

[TestFixture]
public class CalculatableTest
{
    [Test]
    public void CalculateCircleArea_CorrectArea()
    {
        ICalculatable shape = new Circle(5.0);
        var expectedArea = Math.PI * Math.Pow(5.0, 2);

        var actualArea = shape.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, 1e-10);
    }

    [Test]
    public void CalculateTriangleArea_CorrectArea()
    {
        ICalculatable shape = new Triangle(3.0, 4.0, 5.0);
        var semiPerimeter = (3.0 + 4.0 + 5.0) / 2;
        var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - 3.0) * (semiPerimeter - 4.0) * (semiPerimeter - 5.0));

        var actualArea = shape.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, 1e-10);
    }
}
