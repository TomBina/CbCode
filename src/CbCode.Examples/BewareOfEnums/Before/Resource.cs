using System;

namespace CbCode.Examples.BewareOfEnums.Before
{
    public class Resource
    {
        private readonly string _resource = "Some text";

        public string Get(User user)
        {
            // Validate enum
            if (!Enum.IsDefined(typeof(Role), user.Role))
                throw new InvalidOperationException();

            switch (user.Role)
            {
                case Role.Administrator:
                    return _resource;
                case Role.Manager:
                    return _resource;
                default:
                    throw new InvalidOperationException("Access denied");
            }
        }
    }
}