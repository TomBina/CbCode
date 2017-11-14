namespace CbCode.Examples.BewareOfEnums.After
{
    public abstract class Role
    {
        private string _name;
        private int _value;

        public static Role Administrator { get; } = new AdminRightsRole("Administrator", 1);
        public static Role Manager { get; } = new AdminRightsRole("Manager", 2);
        public static Role Guest { get; } = new VisitorRightsRole("Guest", 3);

        private Role(string name, int value)
        {
            _name = name;
            _value = value;
        }

        public virtual bool HasResourceAccess { get; private set; }

        private class AdminRightsRole : Role
        {
            public AdminRightsRole(string name, int value) : base(name, value)
            {
                HasResourceAccess = true;
            }
        }

        private class VisitorRightsRole : Role
        {
            public VisitorRightsRole(string name, int value) : base(name, value)
            {
                HasResourceAccess = false;
            }
        }
    }
}