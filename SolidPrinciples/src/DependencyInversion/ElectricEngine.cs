
namespace SolidPrinciples.src.DependencyInversion;

public class ElectricEngine : IEngine
{
  public void Start()
  {
    Console.WriteLine("Electric Engine started");
  }
}