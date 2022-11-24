using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class UserAddress
    {
        public int Id { get; set; }
        public string address_line1 { get; set; }
        public string address_line2 { get; set; }
        public string country { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string telephone { get; set; }
        public string mobile { get; set; }

       // public String user_id { get; set; }

        public  User user { get; set; }

    }
}
