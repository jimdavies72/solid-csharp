
namespace SolidPrinciples.src.DependencyInversion;

public class Engine : IEngine
{
  public void Start()
  {
    Console.WriteLine("Petrol Engine started");
  }
}