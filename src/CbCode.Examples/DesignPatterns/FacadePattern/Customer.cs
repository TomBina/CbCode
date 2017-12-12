using System;

namespace CbCode.Examples.DesignPatterns.FacadePattern
{
    public class Customer
    {
        [DbField("CustomerId")]
        public int Id { get; private set; }
        [DbField("Date")]
        public DateTime Date { get; private set; }
        [DbField("Name")]
        public string Name { get; private set; }
        [DbField("Email")]
        public string Email { get; private set; }

        private Customer()
        {
            
        }

        public Customer(int id, DateTime date, string name, string email)
        {
            Id = id;
            Date = date;
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Email = email ?? throw new ArgumentNullException(nameof(email));
        }
    }
}