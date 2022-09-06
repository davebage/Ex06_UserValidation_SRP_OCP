using System.Collections.Generic;
using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;

namespace Ex06_Unit_Tests;

[TestFixture]
public class User_Respository_Should
{
    UserRepository _userRepository;

    [SetUp]
    public void SetUp()
    {
        _userRepository = new UserRepository();
    }


    [Test]
    public void Save_A_User()
    {
        User _user = new User("Dave", "Bage", "david.bage@codurance.com");

        _userRepository.Save(_user);

        List<User> users = _userRepository.GetAll();


        Assert.That(users.Count, Is.EqualTo(1));
        Assert.That(users[0], Is.EqualTo(new User("Dave", "Bage", "david.bage@codurance.com")));
    }
}