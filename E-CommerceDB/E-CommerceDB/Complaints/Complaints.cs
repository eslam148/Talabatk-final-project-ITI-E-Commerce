using System;
using System.Collections.Generic;
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
       // public int SellerId { get; set; }
        //public int BuyerId { get; set; }
        public int ProductId { get; set; }
        public String Noted { get; set; }
        public DateTime Date { get; set; }
        public int Progress { get; set; } = (int)ComplainsStatus.Unread;
        public bool? IsDeleted { get; set; } = false;

        public virtual Product Product { get; set; }
        public virtual User Seller { get; set; }
        public virtual User Buyer { get; set; }
    }
}
