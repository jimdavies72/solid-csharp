// Dependency Inversion Principle
// Higher modules should not depend on lower modules. Both should depend on abstractions

namespace SolidPrinciples.src.DependencyInversion;

public class RunDIP
{
  public static void RunCar()
  {
    // This test violates the DIP
    //BadCar badCar = new BadCar();
    //badCar.Start();
  
    // This test satisfies the DIP
    Car petrolCar = new Car(new Engine());
    petrolCar.Start();

    Car electricCar = new Car(new ElectricEngine());
    electricCar.Start();
  }
}