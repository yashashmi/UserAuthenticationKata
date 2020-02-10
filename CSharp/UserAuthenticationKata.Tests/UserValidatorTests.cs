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
            var result = userValidator.IsValidPassword("123456");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPasswordOtherThanOnlyNumbers()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("Abc123");

            Assert.That(result, Is.False);
        }

        
    }
}