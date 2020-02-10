using NUnit.Framework;

namespace UserAuthenticationKata.Tests
{
    public class LoginHelperTests
    {
        string validPassword_;
        string validUser_;

        [SetUp]
        public void OneTimeSetup()
        {
            validPassword_ = "123456";
            validUser_ = "David";
        }
        [Test]
        public void ShouldReturnSuccessMessageOnSuccessfulLogin()
        {
            var accountCreator = new UserAccountCreator();
            accountCreator.CreateUser(validUser_, validPassword_);

            var loginHelper = new LoginHelper(accountCreator);
            var result = loginHelper.Login(validUser_, validPassword_);

            Assert.AreEqual("Login Successful", result);
        }

        [Test]
        public void ShouldReturnFailureMessageOnInvalidUserName()
        {
            var userCreator = new UserAccountCreator();
            userCreator.CreateUser(validUser_, validPassword_);

            var loginHelper = new LoginHelper(userCreator);
            var result = loginHelper.Login("Scooby", validPassword_);

            Assert.AreEqual("Login Failed", result);
        }

        [Test]
        public void ShouldReturnFailureMessageOnIncorrectPassword()
        {
            var userCreator = new UserAccountCreator();
            userCreator.CreateUser(validUser_, validPassword_);

            var loginHelper = new LoginHelper(userCreator);
            var result = loginHelper.Login(validUser_, "WrongPassword");

            Assert.AreEqual("Login Failed", result);
        }
    }
}