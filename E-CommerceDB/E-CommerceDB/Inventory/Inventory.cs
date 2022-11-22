using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class Inventory
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
        public DateTime deleted_at { get; set; }
        public virtual ICollection<Product> products { get; set; }


    }
}
