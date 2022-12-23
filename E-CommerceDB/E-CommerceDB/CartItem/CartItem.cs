using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class CartItem
    {
        public int Id { get; set; }
      //  public int SessionId { get; set; }
        public int Quantity { get; set; }
        public int Product_id { get; set; }

        public DateTime CreatedAt { get; set; }
        public DateTime ModefiedAt { get; set; }
        public bool? IsDeleted { get; set; } = false;

       // public virtual Product Product { get; set; }

        //public virtual ShoppingSession ShoppingSession { get; set; }

    }
}
