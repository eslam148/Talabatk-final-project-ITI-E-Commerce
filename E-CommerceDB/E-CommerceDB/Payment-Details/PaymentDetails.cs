using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB.Payment_Details
{
    public class PaymentDetails
    {
        public int id { get; set; }
        public int Amount { get; set; }
        public string Provider { get; set; }
        public string Status { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }

        //object of orderdetails
    }
}
