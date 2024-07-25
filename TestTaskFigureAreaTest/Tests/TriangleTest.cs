using TestTaskFigureArea.Classes;

namespace TestTaskFigureAreaTest;

[TestFixture]
public class TriangleTests
{
    [Test]
    public void CalculateArea_CorrectArea()
    {
        var sideA = 3.0;
        var sideB = 4.0;
        var sideC = 5.0;
        var triangle = new Triangle(sideA, sideB, sideC);
        var semiPerimeter = (sideA + sideB + sideC) / 2;
        var expectedArea = Math.Sqrt(semiPerimeter * (semiPerimeter - sideA) * (semiPerimeter - sideB) * (semiPerimeter - sideC));

        var actualArea = triangle.CalculateArea();

        Assert.AreEqual(expectedArea, actualArea, 1e-10);
    }

    [Test]
    public void Constructor_OneSideNegative()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-1, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, -1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, -1));
    }
}