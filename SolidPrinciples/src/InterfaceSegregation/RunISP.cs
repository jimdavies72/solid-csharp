// Interface Segregation Principle
// Clients should not be forced to depend on interfaces that they do not use

namespace SolidPrinciples.src.InterfaceSegregation;

public class RunISP
{
  public static void Calculate()
  {
    // This test violates the ISP
    // var badCircle = new BadCircle { Radius = 10 };
    // Console.WriteLine(badCircle.Area());
    // Console.WriteLine(badCircle.Volume()); 

    // This test satisfies the ISP
    var circle = new Circle { Radius = 10 };
    Console.WriteLine("Circle Area: {0}", circle.Area());

    var sphere = new Sphere { Radius = 10 };
    Console.WriteLine("Sphere Area: {0}", sphere.Area());
    Console.WriteLine("Sphere Volume: {0}", sphere.Volume());

  }
}