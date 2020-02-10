using System.Linq;
using System.Text.RegularExpressions;

namespace UserAuthenticationKata.Tests
{
    public  class UserValidator
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
            return password.All(p => char.IsDigit(p));
        }
    }
}