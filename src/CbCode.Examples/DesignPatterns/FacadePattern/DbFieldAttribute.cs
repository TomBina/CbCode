using System;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public class DbFieldAttribute : Attribute
    {
        public string Name { get; }

        public DbFieldAttribute(string name)
        {
            Name = name;
        }
    }
}