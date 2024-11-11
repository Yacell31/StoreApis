using Microsoft.EntityFrameworkCore;
using Yacell.Store.APIs.Repositories.Contracts;
using Yacell.Store.APIs.Services.Contracts;
using Yacell.StoreAPIs.Common.ResponseObjects;

namespace Yacell.Store.APIs.Services
{
    public class CustomerService : ICustomerService
    {
        public ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository) {
        
            this._customerRepository = customerRepository;
        }
        public IReadOnlyList<CustomerResponse> GetCustomerList()
        {
           IReadOnlyList<CustomerResponse> finalList= new List<CustomerResponse>();
            try
            {
                finalList=  this._customerRepository.GetCustomerList().Select(customer => new CustomerResponse
                {
                    FirstName= customer.FirstName,
                }).ToList();
            }

            catch(Exception ex) {
                throw;
            }
            return finalList;
        }
    }
}
