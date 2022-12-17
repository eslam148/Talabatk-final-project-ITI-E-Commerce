using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public string address_line1 { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string mobile { get; set; }

        public int Order_Details_Id { get; set; }
        public virtual Order_Details Order_Details { get; set; }
    }
}
