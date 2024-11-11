using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yacell.StoreAPIs.Data.Contracts;
using Yacell.StoreAPIs.Data.Entities;

namespace Yacell.StoreAPIs.Data
{
    public class YacellStoreContext : DbContext, IYacellStoreContext
    {
        public YacellStoreContext(DbContextOptions <YacellStoreContext> options) : base(options)
        {
        }
        public DbSet<CustomerEntity> Customers { get; set; }
        public DbSet<OrderEntity> Orders { get; set; }

        public void AddCustomer<TEntity>(TEntity entity) where TEntity : class
        {
            throw new NotImplementedException();
        }

        void IYacellStoreContext.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
