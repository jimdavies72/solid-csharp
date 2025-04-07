
namespace SolidPrinciples.src.SingleResponsibilty;

public class EmailSender 
{
  public void SendEmail(string email, string message)
  {
    Console.WriteLine("Sending email to {0} with message: {1}", email, message);
  }

}