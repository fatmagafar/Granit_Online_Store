using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Granite_online_store.Models
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public bool available { get; set; }
        public string image { get; set; }



        [Display(Name="Product Type")]
        public int ProductTypeID { get; set; }
        [ForeignKey ("ProductTypeID")]
        public virtual ProductTypes ProductTypes { get; set; }



    }
}
