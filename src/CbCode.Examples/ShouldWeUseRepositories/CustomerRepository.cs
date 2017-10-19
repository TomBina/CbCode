using System.Collections.Generic;
using System.Linq;

namespace CbCode.Examples.ShouldWeUseRepositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        private readonly List<Customer> _dataStore;

        public CustomerRepository()
        {
            _dataStore = new List<Customer>()
            {
                new Customer(1, "John"),
                new Customer(2, "Eric")
            };
        }

        public IQueryable<Customer> Query()
            => _dataStore.AsQueryable();

        public IEnumerable<Customer> GetAll() 
            => _dataStore;

        public Customer Get(int id) 
            => _dataStore.FirstOrDefault(c => c.Id == id);

        public void Add(Customer customer) 
            => _dataStore.Add(customer);

        public bool SaveChanges() 
            => true;
    }
}
