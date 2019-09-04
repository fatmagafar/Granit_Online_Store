using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Granite_online_store.Models
{
    public class ProductsViewModel
    {
        public Products Products { get; set; }
        public IEnumerable<ProductTypes> ProductTypes { get; set; }
        
    }
}
