namespace Ex06_UserValidation_SRP_OCP;

public class User
{
    public string FirstName;
    public string LastName;
    public string EmailAddress;
    public DateTime DateOfBirth;

    public User()
    {
    }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;

        User other = obj as User;

        return other.EmailAddress == this.EmailAddress && other.FirstName == this.FirstName &&
               other.FirstName == this.FirstName;
    }

    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
}