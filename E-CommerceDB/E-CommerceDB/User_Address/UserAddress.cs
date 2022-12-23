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
        public string country { get; set; }
        public string city { get; set; }
        public string postal_code { get; set; }
        public string mobile { get; set; }
        public bool? IsDeleted { get; set; } = false;

        public String user_id { get; set; }

        public virtual User user { get; set; }

    }
}
