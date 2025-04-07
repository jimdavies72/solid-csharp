// This (bad) example violates the SRP as it manages user data AND the registering logic 

namespace SolidPrinciples.src.SingleResponsibilty;

public class BadUser 
{
  public string Username { get; set; } = "";
  public string Email { get; set; } = "";

  public void Register()
  {
    // register user logic...

    // Send email
    EmailSender emailSender = new EmailSender();
    emailSender.SendEmail(Email, "Welcome to our site!");

  }
}