namespace JobHunt.Application.Exceptions.User;

public class UserWrongCredentialsException(string message) : Exception(message)
{
    
}