
using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC.Services
{
    public interface Iorder
    {
        public List<OrderItems> GetOrders();
        public void Delete(int id);
        public List<Order_Details> GetPendingOrders();
        public List<Order_Details> GetDeliveredOrders();
        public void updateProgress(int id , int Progress);
        public List<Order_Details> GetShippingOrders();

    }
}
