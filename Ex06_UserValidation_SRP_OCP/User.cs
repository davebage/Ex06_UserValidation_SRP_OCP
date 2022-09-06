namespace Ex06_UserValidation_SRP_OCP;

public class User
{
    public string FirstName;
    public string LastName;
    public string EmailAddress;

    public User(string firstName, string lastName, string emailAddress)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.EmailAddress = emailAddress;
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;

        User other = obj as User;

        return other.EmailAddress == this.EmailAddress && other.FirstName == this.FirstName &&
               other.FirstName == this.FirstName;
    }
}