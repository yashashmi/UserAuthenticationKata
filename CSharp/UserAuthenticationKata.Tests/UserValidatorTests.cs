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
        public void ShouldReturnFalseWhenPasswordOtherThanOnlyNumbers()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("Abc123");

            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnTrueWhenValidPassword()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("Abc123456");

            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnFalseWhenPasswordShorterThan8Chars()
        {
            var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("Abc12");

            Assert.That(result, Is.False);
        }

        [Test]
        public void ShouldReturnFalseWhenPasswordShortOfDigits()
        {var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("Abcdefgh1");

            Assert.That(result, Is.False);

        }

         [Test]
        public void ShouldReturnFalseWhenPasswordShortOfAlphabets()
        {var userValidator = new UserValidator();
            var result = userValidator.IsValidPassword("A12345678");

            Assert.That(result, Is.False);

        }


    }
}