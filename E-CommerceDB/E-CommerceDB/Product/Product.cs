using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        //public string SKU { get; set; }
        public int Price { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
        public DateTime deleted_at { get; set; }
        public int category_Id { get; set; }
        public int inventory_Id { get; set; }
        public int discount_Id { get; set; }
        public virtual Category cat { get; set; }
        public virtual Inventory inventory { get; set; }
        public virtual Discount discount { get; set; }


    }
}
