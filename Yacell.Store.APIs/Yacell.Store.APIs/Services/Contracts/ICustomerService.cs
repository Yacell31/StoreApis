using Yacell.StoreAPIs.Common.ResponseObjects;

namespace Yacell.Store.APIs.Services.Contracts
{
    public interface ICustomerService
    {
        public IReadOnlyList<CustomerResponse> GetCustomerList();

    }
}
