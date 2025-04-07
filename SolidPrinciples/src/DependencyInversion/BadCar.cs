
namespace SolidPrinciples.src.DependencyInversion;

public class BadCar
{
  private BadEngine engine;

  public BadCar()
  {
    //direct (tightly coupled) dependency on concrete Engine class
    this.engine = new BadEngine();
  }

  public void Start()
  {
    engine.Start();
    Console.WriteLine("Car started");
  }
}