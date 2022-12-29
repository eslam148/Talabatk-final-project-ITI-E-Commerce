using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class SubCategories
    {
        public int Id { get; set; }
        public string BrandName { get; set; }
        public string BrandNameAr { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public DateTime created_at { get; set; } = DateTime.Now;
        public DateTime modified_at { get; set; } = DateTime.Now;
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Product> products { get; set; }

    }
}
