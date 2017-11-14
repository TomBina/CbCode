namespace CbCode.Examples.BewareOfEnums.After
{
    public class User
    {
        public Role Role { get; }

        public User(Role role)
        {
            Role = role;
        }
    }
}