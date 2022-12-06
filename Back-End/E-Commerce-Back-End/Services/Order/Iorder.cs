
using E_Commerce_Back_End;
using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC.Services
{
    public interface Iorder
    {
        public List<OrderItems> GetOrders();
        public void Delete(int id);
        public List<OrderItems> GetPendingOrders();
        public List<OrderItems> GetDeliveredOrders();
     
        /// ////////////////////////////////////////////////////////////

        public void AddOrder(OrderItemsCreateModel orderModel);
        public void AddOrderDetails(OrderDetailsCreateModel orderDetailsModel);


    }
}
