using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;

namespace Ex06_Unit_Tests
{
    [TestFixture]
    public class User_Validator_Should
    {
        private IValidator _userValidator;
        [SetUp]
        public void SetUp()
        {
            _userValidator = new UserValidator();
        }

        [Test]
        public void User_Validator_Should_Return_True_When_Valid()
        {
            User _user = new User("Dave", "Bage", "david.bage@codurance.com");

            _userValidator.Validate(_user);
        }
    }
}
