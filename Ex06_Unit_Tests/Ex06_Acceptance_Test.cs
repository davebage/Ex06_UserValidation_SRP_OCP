using System.Collections.Generic;
using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;

namespace Ex06_Unit_Tests;

[TestFixture]
public class Ex06_Acceptance_Test
{
    private UserService _userService;
    private List<IValidator> validators;
    private IUserRepository _userRepository;
    private User _user;

    [SetUp]
    public void SetUp()
    {
        _userRepository = new UserRepository();
        _user = new User("Dave", "Bage", "david.bage@codurance.com");
        validators = new List<IValidator> { new UserValidator(), new EmailValidator()  };
    }

    [Test]
    public void User_Should_Be_Validated_And_Created()
    {
        // Arrange
        _userService = new UserService(validators, _userRepository);

        // Act
        var success = _userService.CreateUser(_user);

        Assert.IsTrue(success);
    }
}