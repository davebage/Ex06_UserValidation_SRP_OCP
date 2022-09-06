using System.Net.Mail;
using System.Text.RegularExpressions;

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

public class EmailValidator : IValidator
{
    private Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    public bool Validate(User user)
    {
        return regex.Match(user.EmailAddress).Success;
    }
}