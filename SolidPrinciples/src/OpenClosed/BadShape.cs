// This (bad) example violtes the Open/Closed principle because adding new shapes would require modifying the existing class to accomodate them.

namespace SolidPrinciples.src.OpenClosed;

public class BadShape
{
  public ShapeType Type { get; set; }
  public double Radius { get; set; } 
  public double Length { get; set; }
  public double Width { get; set; }

  public double CalculateArea()
  {
    switch (Type)
    {
      case ShapeType.Circle:
        return Math.PI * Math.Pow(Radius, 2);
      case ShapeType.Rectangle:
        return Length * Width;
      default:
        throw new InvalidOperationException("Invalid shape type.");
    }
  }
}