
using E_Commerce_Back_End;
using E_Commerce_Back_End.Models;
using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public interface Iorder
    {
        public List<OrderItems> GetOrders();
        public void Delete(int id);
        public List<OrderItems> GetPendingOrders();
        public List<OrderItems> GetDeliveredOrders();
     
        /// ////////////////////////////////////////////////////////////

        public Task AddOrder(OrderItemsCreateModel[] orderModel);
        public Order_Details AddOrderDetails(OrderDetailsCreateModel orderDetailsModel);
        public List<Order_Details> GetOrderDetails(string Id);
        public Task<List<GetOrderItemModel>> GetOrderItems(int Id);



    }
}
