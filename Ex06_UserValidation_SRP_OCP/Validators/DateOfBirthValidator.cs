namespace Ex06_UserValidation_SRP_OCP;

public class UserDateOfBirthValidator : IValidator
{
    private const int EIGHTEEN = 18;
    // Reject if under 18
    public bool Validate(User user)
    {
        // Save today's date.
        var today = DateTime.Today;

        // Calculate the age.
        var age = today.Year - user.DateOfBirth.Year;

        // Go back to the year in which the person was born in case of a leap year
        if (user.DateOfBirth.Date > today.AddYears(-age)) age--;
        return age >= EIGHTEEN;
    }
}