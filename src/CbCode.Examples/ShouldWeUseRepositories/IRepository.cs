using System.Collections.Generic;

namespace CbCode.Examples.ShouldWeUseRepositories
{
    public interface IRepository<T>
    {
        IEnumerable<Customer> GetAll();
        Customer Get(int id);
        void Add(Customer customer);
        bool SaveChanges();
    }
}
