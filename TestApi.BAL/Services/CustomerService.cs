using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TestApi.BAL.Interfaces;
using TestApi.DAL;
using TestApi.Models;

namespace TestApi.BAL.Services
{
    public class CustomerService : ICustomer
    {
        readonly CustomerDbContext _customerContext;

        public CustomerService(CustomerDbContext context)
        {
            _customerContext = context;
        }
        public async Task<List<Customer>> GetAllCustomers()
        {
            return await Task.Run(() =>
               {
                   try
                   {
                       return _customerContext.Customers.ToList();
                   }
                   catch
                   {
                       throw;
                   }
               });
        }
        public async Task<bool> CreateNewCustomer(Customer customer)
        {
            return await Task.Run(() =>
            {
                var result = false;
                try
                {
                    _customerContext.Add(customer);
                    _customerContext.SaveChanges();
                    result = true;
                }
                catch
                {
                    throw;
                }
                return result;
            });

        }
    }
}