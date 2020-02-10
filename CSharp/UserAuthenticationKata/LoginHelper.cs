namespace UserAuthenticationKata.Tests
{
    public class LoginHelper
    {
        private UserAccountCreator accountCreator_;

        public LoginHelper(UserAccountCreator accountCreator)
        {
            accountCreator_ = accountCreator;
        }

        public string Login(string userName, string password)
        {
            if (accountCreator_.Users.ContainsKey(userName))
            {
                 if (accountCreator_.Users[userName].Equals(password))
                 {
                    return "Login Successful";
                 }
            }
            return "Login Failed";
        }
    }
}