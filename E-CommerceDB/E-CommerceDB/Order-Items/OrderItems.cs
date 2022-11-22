using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Order_Items
{
    public class OrderItems
    {
        public int id { get; set; }
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }

        public virtual Product product { get; set; }
        //orderdetails obj 

        //Collection of orderitem in orderdetails
    }
}
