using System;

namespace CbCode.Examples.BewareOfEnums.After
{
    public class Resource
    {
        private readonly string _resource = "Some text";

        public string Get(User user)
        {
            if (!user.Role.HasResourceAccess)
                throw new InvalidOperationException();

            return _resource;
        }
    }
}