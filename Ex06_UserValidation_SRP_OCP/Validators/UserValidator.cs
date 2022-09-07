using System.Net.Mail;

namespace Ex06_UserValidation_SRP_OCP;

public class UserValidator : IValidator
{
    public bool Validate(User user)
    {
        if(string.IsNullOrWhiteSpace(user.FirstName) || string.IsNullOrWhiteSpace(user.LastName) || string.IsNullOrWhiteSpace(user.EmailAddress))
            return false;

        return true;
    }
}