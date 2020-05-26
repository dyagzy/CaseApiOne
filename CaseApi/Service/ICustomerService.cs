using CaseApi.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CaseApi.Service
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int CustomerId);
        Task CreateAsync(Customer customer);
        Task UpdateAsync(Customer customer);
        Task UpdateAsync(int id);
        Task Delete(int id);
    }
}
