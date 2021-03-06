using NUnit.Framework;

namespace UserAuthenticationKata.Tests
{
    public class UserAccountCreatorTests
    {
        [Test]
        public void ShouldReturnSuccessMessageOnUserAccountCreation()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("ValidUser", "Abc123456");

            Assert.That(result, Is.EqualTo("Account Created Successfuly"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidUserName()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("InvalidUser123", "Abc123456");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidPassword()
        {
            var accountCreator = new UserAccountCreator();
            var result = accountCreator.CreateUser("ValidUser", "Abc123");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));
        }

        [Test]
        public void UserListShouldNotBeNullEvenIfNoUserCreated()
        {
            var userCreator = new UserAccountCreator();

            Assert.IsNotNull(userCreator.Users);
        }

        [Test]
        public void ShouldIncreaseTheUserCountInListOnUserCreation()
        {
            var userCreator = new UserAccountCreator();
            userCreator.CreateUser("ValidUser", "Abc123456");

            Assert.AreEqual(1, userCreator.Users.Count);
        }
        [Test]
        public void ShouldNotIncreaseTheUserCountInListOnUserCreationFailure()
        {
            var userCreator = new UserAccountCreator();
            userCreator.CreateUser("InvalidUser123", "1234");

            Assert.AreEqual(0, userCreator.Users.Count);
        }

    }
}