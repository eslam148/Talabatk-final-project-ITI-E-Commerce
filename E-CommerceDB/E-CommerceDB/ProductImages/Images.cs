using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class Images
    {
        public int Id { get; set; }
        public String Image { get; set; }
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
