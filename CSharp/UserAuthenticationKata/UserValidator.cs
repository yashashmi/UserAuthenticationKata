using System.Linq;
using System.Text.RegularExpressions;

namespace UserAuthenticationKata.Tests
{
    public  class UserValidator
    {

        public string CreateUser(string userName, string password)
        {
            if (!IsValidUserName(userName) || !ValidatePassword(password))
            {
                return "Account Creation Failed";
            }
            return "Account Created Successfuly";
        }

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

        public bool ValidatePassword(string password)
        {
            return password.All(p => char.IsDigit(p));
        }
    }
}