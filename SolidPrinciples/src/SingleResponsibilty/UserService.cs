// manages the business logic related to the user.

namespace SolidPrinciples.src.SingleResponsibilty;

public class UserService
{
  public static void Register(User user)
  {
    // register user logic...

    // Send email
    EmailSender emailSender = new EmailSender();
    emailSender.SendEmail(user.Email, "Welcome to our site!");

  }

  public static void OtherUserMethod()
  {
    // Other user business logic method....
  }
}