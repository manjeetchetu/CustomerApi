using System.Collections.Generic;
using System.Threading.Tasks;
using TestApi.Models;

namespace TestApi.BAL.Interfaces
{
    public interface ICustomer
    {
        public Task<List<Customer>> GetAllCustomers();

        public Task<bool> CreateNewCustomer(Customer customer);

    }
}
