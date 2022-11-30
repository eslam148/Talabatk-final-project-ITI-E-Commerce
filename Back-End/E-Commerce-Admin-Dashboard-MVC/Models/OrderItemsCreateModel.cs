using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC.Models
{
    public class OrderItemsCreateModel
    {
        public int id { get; set; }
        public int Order_Details_id { get; set; }
        public int Product_id { get; set; }
        public int Quantity { get; set; }
        public DateTime created_at { get; set; }
        public DateTime modified_at { get; set; }
        public bool? IsDeleted { get; set; } = false;
        public Order_Details Order_Details { get; set; }

    }
}
