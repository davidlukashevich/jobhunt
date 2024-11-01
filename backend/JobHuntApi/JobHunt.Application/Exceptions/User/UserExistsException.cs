namespace JobHunt.Application.Exceptions.User;

public class UserExistsException(string message) : Exception(message);