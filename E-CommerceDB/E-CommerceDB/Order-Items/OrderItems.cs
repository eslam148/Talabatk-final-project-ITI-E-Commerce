using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class OrderItems
    {
        public int Id { get; set; }
        public int Order_Details_id { get; set; }
        [ForeignKey("Product")]
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public bool? IsDeleted { get; set; } = false;

        public virtual Product Product { get; set; }
        //orderdetails obj 
        public virtual Order_Details Order_Details { get; set; }

        //Collection of orderitem in orderdetails
    }
}
