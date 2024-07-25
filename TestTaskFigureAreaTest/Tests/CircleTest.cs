using TestTaskFigureArea.Classes;

namespace TestTaskFigureAreaTest;

[TestFixture]
public class CircleTests
{
    [Test]
    public void CalculateArea_CorrectArea()
    {
        var circle = new Circle(10);
        var expectedArea = Math.PI * 10 * 10;

        var actualArea = circle.CalculateArea();
        
        Assert.AreEqual(expectedArea, actualArea, 1e-10);
    }

    [Test]
    public void Constructor_NegativeRadius()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-1));
    }
}