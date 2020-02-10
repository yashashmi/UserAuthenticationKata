using System.Collections.Generic;

namespace UserAuthenticationKata.Tests
{
    public class UserAccountCreator
    {
        private readonly UserValidator validator_;

        public Dictionary<string, string> Users { get; }

        public UserAccountCreator()
        {
            validator_ = new UserValidator();
            Users = new Dictionary<string, string>();
        }

        
        public string CreateUser(string userName, string password)
        {
            if (!validator_.IsValidUserName(userName) || !validator_.IsValidPassword(password))
            {
                return "Account Creation Failed";
            }

            Users.Add(userName,password);
            return "Account Created Successfuly";
        }
    }
}