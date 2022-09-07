using System;
using System.Collections.Generic;
using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;

namespace Ex06_Unit_Tests;

[TestFixture]
public class User_Respository_Should
{
    UserRepository _userRepository;

    private const string FIRSTNAME = "Dave";
    private const string LASTNAME = "Bage";
    private const string EMAILADDRESS = "david.bage@codurance.com";

    // To get around that you cannot have a datetime const
    private static readonly DateTime DATEOFBIRTH = new DateTime(2000, 02, 03);

    [SetUp]
    public void SetUp()
    {
        _userRepository = new UserRepository();
    }


    [Test]
    public void Save_A_User()
    {
        User _user = new User { FirstName = FIRSTNAME, LastName = LASTNAME, EmailAddress = EMAILADDRESS, DateOfBirth = DATEOFBIRTH };

        _userRepository.Save(_user);

        List<User> users = _userRepository.GetAll();


        Assert.That(users.Count, Is.EqualTo(1));
        Assert.That(users[0], Is.EqualTo(new User { FirstName = "Dave", LastName = "Bage", EmailAddress = "david.bage@codurance.com", DateOfBirth = DATEOFBIRTH }));
    }
}