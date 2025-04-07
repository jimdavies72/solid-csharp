// Single Responsibilty Principle (SRP)
// A class should have only one reason to change and therefore it should have only one responsibility

// manages the data related to the user

namespace SolidPrinciples.src.SingleResponsibilty;

public class User
{
  public string Username { get; set; } = "";
  public string Email { get; set; } = "";

}