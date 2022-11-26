using E_CommerceDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class Order_Details
    {
        public int Id { get; set; }
      //  public String User_id { get; set; }
        public decimal Total { get; set; }
        public int Payment_id { get; set; }

        public DateTime Created_at { get; set; }
        public DateTime Modified_at { get; set; }
        public bool? IsDeleted { get; set; } = false;

        public virtual User user { get; set; }

        public virtual PaymentDetails PaymentDetails { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
