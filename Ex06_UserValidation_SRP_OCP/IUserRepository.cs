namespace Ex06_UserValidation_SRP_OCP;

public interface IUserRepository
{
    User Save(User user);

    List<User> GetAll();
}

public class UserRepository : IUserRepository
{
    List<User> _users = new List<User>();

    public User Save(User user)
    {
        _users.Add(user);

        return user;
    }

    public List<User> GetAll()
    {
        return _users;
    }
}
