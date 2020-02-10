using System;
using NUnit.Framework;

namespace UserAuthenticationKata.Tests
{
    public class UserValidatorTests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ShouldReturnTrueWhenAValidLengthUserNameProvided()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidUserName("ValidUser");
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenUserNameLengthLessThanOne()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidUserName("");

            Assert.That(result, Is.False);

        }

        [Test]
        public void ShouldReturnFalseWhenUserNameLengthGreaterThanEleven()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidUserName("SomeLongUserName");

            Assert.That(result, Is.False);

        }

        [Test]
        public void ShouldReturnTrueWhenUserNameOnlyAlphabets()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidUserName("ValidUser");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenUserNameOtherThanOnlyAlphabets()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidUserName("Abc123");

            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnTrueWhenPasswordOnlyNumbers()
        {
            var userValidator = new UserValidator();
            var result = userValidator.ValidatePassword("123456");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPasswordOtherThanOnlyNumbers()
        {
            var userValidator = new UserValidator();
            var result = userValidator.ValidatePassword("Abc123");

            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnSuccessMessageOnUserAccountCreation()
        {
            var userValidator = new UserValidator();
            var result = userValidator.CreateUser("ValidUser", "1234");

            Assert.That(result, Is.EqualTo("Account Created Successfuly"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidUserName()
        {
            var userValidator = new UserValidator();
            var result = userValidator.CreateUser("InvalidUser123", "1234");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));

        }

        [Test]
        public void ShouldReturnFailureMessageWhenInvalidPassword()
        {
            var userValidator = new UserValidator();
            var result = userValidator.CreateUser("ValidUser", "Abc123");

            Assert.That(result, Is.EqualTo("Account Creation Failed"));

        }
    }
}