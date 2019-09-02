using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Granite_online_store.Models
{
   

    public class ProductTypes
    {
        public int id { get; set; }

        [Required]
        public String Name{ get; set; }

    }
}
