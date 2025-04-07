
namespace SolidPrinciples.src.DependencyInversion;

public class Car
{
  private IEngine engine;

  public Car(IEngine engine)
  {
    // loosley coupled to the IEngine interface, allows different engine classes to be used
    this.engine = engine;
  }

  public void Start()
  {
    engine.Start();
    Console.WriteLine("Car started");
  }
}