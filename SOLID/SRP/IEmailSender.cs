namespace SOLID.SRP
{
    public interface IEmailSender
    {
        bool SendEmail(string email);
    }
}
