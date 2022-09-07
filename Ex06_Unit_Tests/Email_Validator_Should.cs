using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex06_UserValidation_SRP_OCP;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace Ex06_Unit_Tests
{
    [TestFixture]
    public class Email_Validator_Should
    {
        private IValidator _emailValidator;

        [SetUp]
        public void SetUp()
        {
            _emailValidator = new UserEmailValidator();
        }

        [Test]
        public void RejectInvalidEmailAddress()
        {
            User _user = new User { EmailAddress = "david.bage@codurance..com" };

            // Act
            var success = _emailValidator.Validate(_user);

            Assert.That(success, Is.False);
        }

        [Test]
        public void AcceptValidEmailAddress()
        {
            User _user = new User { EmailAddress = "david.bage@codurance.com" };

            // Act
            var success = _emailValidator.Validate(_user);

            Assert.That(success, Is.True);
        }
    }
}
