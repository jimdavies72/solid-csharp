// Liskov Substitution Principle (LSP)
// Objects of a sperclass should be replaceable with instances of its subclass without affecting the correctness of the program

namespace SolidPrinciples.src.LiskovSubstitution;

public class RunLSP
{
  public static void CalculateAreas() {

    // These tests violate the LSP
    
    //var rect = new Rectangle();
    // test violating LSP
    // var rect = new BadSquare();

    // rect.Height = 10;
    // rect.Width = 5;
    // Console.WriteLine("Area: {0}", rect.Area);


    // These tests satisfy the LSP (after refactoring)
    Shape rectangle = new Rectangle { Width = 5, Height = 10 }; //expected 50
    Console.WriteLine("Rectangle Area: {0}", rectangle.Area);

    Shape square = new Square { SideLength = 5}; //expected 25
    Console.WriteLine("Square Area: {0}", square.Area);
  }
}