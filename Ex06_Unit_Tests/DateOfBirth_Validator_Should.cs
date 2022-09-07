using System;
using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;

namespace Ex06_Unit_Tests;

[TestFixture]
public class DateOfBirth_Validator_Should
{
    private UserDateOfBirthValidator _userDateOfBirthValidator;
    private User _user;
    private DateTime UNDER_EIGHTEEN = new DateTime(2022, 01, 01);
    private DateTime OVER_EIGHTEEN = new DateTime(2000, 01, 01);

    [SetUp]
    public void SetUp()
    {
        _userDateOfBirthValidator = new UserDateOfBirthValidator();
        _user = new User { EmailAddress = "david.bage@codurance.com", FirstName = "Dave", LastName = "Bage" };
    }

    [Test]
    public void Return_False_When_User_Under_Eighteen()
    {
        _user.DateOfBirth = DateTime.Now;

        Assert.IsFalse(_userDateOfBirthValidator.Validate(_user));
    }

    [Test]
    public void Return_True_When_User_Eighteen_Or_Over()
    {
        _user.DateOfBirth = DateTime.Now.AddYears(-18);

        Assert.IsTrue(_userDateOfBirthValidator.Validate(_user));
    }
}