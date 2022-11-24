using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
        public DateTime deleted_at { get; set; }
        public bool IsDeleted { get; set; } = false;

        public virtual ICollection<Product> products { get; set; }

        public virtual ICollection<SubCategories> SubCategories { get; set; }
    }
}
