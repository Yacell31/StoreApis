using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yacell.StoreAPIs.Data.Entities;

namespace Yacell.StoreAPIs.Data.Contracts
{
    public interface IYacellStoreContext
    {

        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

        public void AddCustomer<TEntity>(TEntity entity) where TEntity : class;

        public void SaveChanges();
    }
}
