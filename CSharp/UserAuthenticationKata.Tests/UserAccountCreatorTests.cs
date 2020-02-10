using NUnit.Framework;

namespace UserAuthenticationKata.Tests
{
    public class UserAccountCreatorTests
    {
        [Test]
        public void ShouldReturnSuccessMessageOnUserAccountCreation()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("ValidUser", "1234");

            Assert.That(result, Is.EqualTo("Account Created Successfuly"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidUserName()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("InvalidUser123", "1234");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidPassword()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("ValidUser", "Abc123");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));

        }

    }
}