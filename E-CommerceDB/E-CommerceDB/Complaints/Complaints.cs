using Castle.Components.DictionaryAdapter;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceDB
{
    public enum ComplainsStatus
    {
        Unread,
        Pending,
        Solved
    }
    public class Complaints
    {
        public int Id { get; set; }
        //[ForeignKey("Seller")]
        public String SellerId { get; set; }
        //[ForeignKey("Buyer")]
        public String BuyerId { get; set; }
       // [ForeignKey("Product")]
        public int ProductId { get; set; } = 1;
        public String Noted { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Progress { get; set; } =(int)progress.pending;
        public bool? IsDeleted { get; set; } = false;

        public virtual Product? Product { get; set; }
        public virtual User? Seller { get; set; }
        public virtual User? Buyer { get; set; }
    }
}
