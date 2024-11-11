using Microsoft.EntityFrameworkCore;
using Yacell.Store.APIs.Repositories.Contracts;
using Yacell.StoreAPIs.Common.RequestObjects;
using Yacell.StoreAPIs.Common.ResponseObjects;
using Yacell.StoreAPIs.Data.Contracts;
using Yacell.StoreAPIs.Data.Entities;

namespace Yacell.Store.APIs.Repositories
{
    public class CustomerRepository:ICustomerRepository
    {
        private readonly IYacellStoreContext _storeContext;


        public CustomerRepository(IYacellStoreContext storeContext)
        {
            _storeContext = storeContext;
        }


         public IQueryable<CustomerEntity> GetCustomerList()
        {
            try
            {
                return this._storeContext.Customers.AsNoTracking();
            }
            
            catch(Exception ex)
            {
                throw;
            }
        }

        public void AddCustomer()
        {
            throw new NotImplementedException();
        }

        public Task<T> EditCustomer<T>(CustomerRequest customer) where T : class
        {
            throw new NotImplementedException();
        }

        public Task<T> RemoveCustomer<T>(CustomerRequest customer) where T : class
        {
            throw new NotImplementedException();
        }
    }
}
