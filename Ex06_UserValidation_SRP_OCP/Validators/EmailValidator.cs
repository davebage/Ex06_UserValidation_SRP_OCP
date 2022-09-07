using System.Text.RegularExpressions;

namespace Ex06_UserValidation_SRP_OCP;

/// <summary>
/// Should we really need to pass in the entire user object to validate an email address?
/// </summary>
public class UserEmailValidator : IValidator
{
    private Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
    public bool Validate(User user)
    {
        return ValidateEmail(user.EmailAddress);
    }

    // Ideally it'll be this
    public bool ValidateEmail(string email)
    {
        return regex.Match(email).Success;
    }
}