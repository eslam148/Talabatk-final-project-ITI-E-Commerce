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
        public String? User_id { get; set; }
        public decimal Total { get; set; } = 0;
        public int? Payment_id { get; set; }

        public DateTime Created_at { get; set; } = DateTime.Now;
        public DateTime Modified_at { get; set; }=  DateTime.Now;
        public bool IsDeleted { get; set; } = false;
        public int progress { get; set; } = 0;
        public virtual User user { get; set; }

      //  public virtual PaymentDetails? PaymentDetails { get; set; }

        public virtual ICollection<OrderItems> OrderItems { get; set; }
    }
}
