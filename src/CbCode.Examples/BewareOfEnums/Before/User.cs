namespace CbCode.Examples.BewareOfEnums.Before
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