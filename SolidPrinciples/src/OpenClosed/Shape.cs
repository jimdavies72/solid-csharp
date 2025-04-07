// The Open/Closed principle states that code is open to extension but closed to modification.

// abstract class that allows for individual shape implementations to inherit this class

namespace SolidPrinciples.src.OpenClosed;

public abstract class Shape
{
  public abstract double CalculateArea();
}