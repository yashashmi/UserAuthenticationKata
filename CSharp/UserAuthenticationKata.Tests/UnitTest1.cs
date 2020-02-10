using System;
using NUnit.Framework;

namespace UserAuthenticationKata.Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }


        [Test]
        public void ShouldReturnTrueWhenAValidLengthUserNameProvided()
        {
            var userValidator = new UserValidator();
            var result = userValidator.Validate("ValidUser");
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenUserNameLengthLessThanOne()
        {
            var userValidator = new UserValidator();
            var result = userValidator.Validate("");

            Assert.That(result, Is.False);

        }

        [Test]
        public void ShouldReturnFalseWhenUserNameLengthGreaterThanEleven()
        {
            var userValidator = new UserValidator();
            var result = userValidator.Validate("SomeLongUserName");

            Assert.That(result, Is.False);

        }

        [Test]
        public void ShouldReturnTrueWhenUserNameOnlyAlphabets()
        {
            var userValidator = new UserValidator();
            var result = userValidator.ValidateAlphabets("ValidUser");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenUserNameOtherThanOnlyAlphabets()
        {
            var userValidator = new UserValidator();
            var result = userValidator.ValidateAlphabets("Abc123");

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

        // [Test]
        // public void ShouldReturnSuccessMessageOnUserAccountCreation()
        // {
        //     var a = new A();
        //     var result = a.CreateUser("ValidUser", "1234");

        //     Assert.That(result, Is.EqualTo("Account Created Successfuly"));

        // }

        // [Test]
        // public void ShouldReturnFailureMessageWhenUserCreationFailed()
        // {
        //     var a = new A();
        //     var result = a.CreateUser("InvalidUser123", "1234");

        //     Assert.That(result, Is.EqualTo("Account Creation Failed"));

        // }

    }
}