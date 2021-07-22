namespace SOLID
{
    public interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string email);

        //For the single responsibility principle below methods are not valid as this interface will lost its main 
        //purpose, in this case is handle the user, instead of having this methods here, we could create new interfaces 
        //for LogErrors and SendEmails.
        
        //void LogError(string error);
        
        //bool SendEmail(string email);

    }
}
