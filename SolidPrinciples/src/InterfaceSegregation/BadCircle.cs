
namespace SolidPrinciples.src.InterfaceSegregation;

public class BadCircle : IBadShape
{
  public double Radius { get; set; }

  public double Area()
  {
    return Math.PI * Math.Pow(Radius, 2);
  }

  // Circles do not have volume but we are being forced to implement it from the IBadShape interface
  public double Volume()
  {
    throw new InvalidOperationException("Volume not applicable for 2D shapes");
  }
}