using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yacell.StoreAPIs.Common.RequestObjects.Contracts;

namespace Yacell.StoreAPIs.Common.RequestObjects
{
    public class CustomerRequest: RequestAbstractBase
    {
        public string FirstName { get; set; } = string.Empty;
        
    }
}
