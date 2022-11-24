using E_CommerceDB.Order_Items;
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
        public int Progress { get; set; } = 0;
        public bool IsDeleted { get; set; } = false;

        public virtual Category Category { get; set; }
        public virtual Inventory inventory { get; set; }
        public virtual Discount discount { get; set; }
        public virtual OrderItems OrderItems { get; set; }

        public virtual CartItem CartItem { get; set; }

        public virtual ICollection<Complaints> Complaints { get; set; }

        public virtual ICollection<Images> Images { get; set; }





    }
}
