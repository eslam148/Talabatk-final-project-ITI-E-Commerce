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
        public byte[] image { get; set; }

        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

    }
}
