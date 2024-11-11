using Yacell.StoreAPIs.Common.RequestObjects;
using Yacell.StoreAPIs.Common.ResponseObjects;
using Yacell.StoreAPIs.Data.Entities;

namespace Yacell.Store.APIs.Repositories.Contracts
{
    public interface ICustomerRepository
    {
        public IQueryable<CustomerEntity> GetCustomerList();
        public void AddCustomer();
        public Task<T> EditCustomer<T>(CustomerRequest customer) where T : class;
        public Task<T> RemoveCustomer<T>(CustomerRequest customer) where T : class;
    }
} 

