using System.Linq;
using System.Text.RegularExpressions;

namespace UserAuthenticationKata.Tests
{
    public class UserValidator
    {



        public bool IsValidUserName(string userName)
        {
            if (userName.Length < 1 || userName.Length > 11 || !DoesContainOnlyAlphabets(userName))
            {
                return false;
            }
            return true;
        }

        private bool DoesContainOnlyAlphabets(string userName)
        {
            return Regex.IsMatch(userName, @"^[a-zA-Z]+$");

        }

        public bool IsValidPassword(string password)
        {
            var digitCount = 0;
            var letterCount = 0;
            foreach (var ch in password)
            {
                if (char.IsDigit(ch))
                {
                    digitCount++;
                }

                if (char.IsLetter(ch))
                {
                    letterCount++;
                }
            }

            if (password.Length < 8 || digitCount < 2 || letterCount < 2)
            {
                return false;
            }
            return true;

            //return password.All(p => char.IsDigit(p));
        }
    }
}