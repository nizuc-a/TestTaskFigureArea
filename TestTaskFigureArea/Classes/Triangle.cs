namespace TestTaskFigureArea.Classes;

public class Triangle : ICalculatable
{
    public double SideA { get; set; }
    public double SideB { get; set; }
    public double SideC { get; set; }

    public Triangle(double sideA, double sideB, double sideC)
    {
        if (sideA <= 0 || sideB <= 0 || sideC <= 0)
            throw new ArgumentException("Стороны треугольника должны быть больше нуля.");
        
        SideA = sideA;
        SideB = sideB;
        SideC = sideC;
    }
    
    public double CalculateArea()
    {
        var p = (SideA + SideB + SideC) / 2;
        return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
    }

    public bool IsRectangular()
    {
        var side1Square = SideA * SideA;
        var side2Square = SideB * SideB;
        var side3Square = SideC * SideC;

        return side1Square + side2Square == side3Square ||
               side1Square + side3Square == side2Square ||
               side2Square + side3Square == side1Square;
    }
}