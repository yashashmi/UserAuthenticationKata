using System.Linq;
using System.Text.RegularExpressions;

namespace UserAuthenticationKata.Tests
{
    public  class UserValidator
    {

        // internal string CreateUser(string userName, string password)
        // {
        //     if (!Validate(userName) || !ValidateAlphabets(userName) || !ValidatePassword(password))
        //     {
        //         return "Account Creation Failed";
        //     }
        //     return "Account Created Successfuly";
        // }

        public bool Validate(string userName)
        {
            if (userName.Length < 1 || userName.Length > 11)
            {
                return false;
            }
            return true;
        }

        public bool ValidateAlphabets(string userName)
        {
            return Regex.IsMatch(userName, @"^[a-zA-Z]+$");

        }

        public bool ValidatePassword(string v)
        {
            return v.All(p => char.IsDigit(p));
        }
    }
}