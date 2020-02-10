namespace UserAuthenticationKata.Tests
{
    public class UserAccountCreator
    {
        private readonly UserValidator validator_;
        public UserAccountCreator()
        {
            validator_ = new UserValidator();
        }
        public string CreateUser(string userName, string password)
        {
            if (!validator_.IsValidUserName(userName) || !validator_.IsValidPassword(password))
            {
                return "Account Creation Failed";
            }
            return "Account Created Successfuly";
        }
    }
}