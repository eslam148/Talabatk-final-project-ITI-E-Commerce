using E_Commerce_Back_End;
using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public class OrderServices:Iorder
    {

        private LibraryContext db;
        public OrderServices(LibraryContext _db)
        {
            db = _db;
        }
        public List<OrderItems> GetOrders()
        {
            var orders = db.OrderItems.ToList();
            return orders;
        }
        public void Delete(int id)
        {
            var order = db.OrderItems.FirstOrDefault(o=>o.Id== id);
            order.IsDeleted =true;
            db.SaveChanges();
        }

        public List<OrderItems> GetPendingOrders()
        {
            var pending = db.OrderItems.Where(o => o.Order_Details.progress == 0).ToList();
            return pending;
        }

        public List<OrderItems> GetDeliveredOrders()
        {
            var delivered = db.OrderItems.Where(o => o.Order_Details.progress == 1).ToList();
            return delivered;
        }
 
        /// //////////////////////////////////////////////////////////////////////////////////////////////////////////
     
        public void AddOrder(OrderItemsCreateModel orderModel)
        {
            OrderItems order = new OrderItems()
            {
                Order_Details_id = orderModel.Order_Details_id,
                Product_id = orderModel.Product_id,
                Quantity = orderModel.Quantity,
                created_at = orderModel.created_at,
                modified_at = orderModel.modified_at,
                IsDeleted = false
            };
            db.OrderItems.Add(order);
            db.SaveChanges();
        }

        public void AddOrderDetails(OrderDetailsCreateModel orderDetailsModel)
        {
            Order_Details orderDetails = new Order_Details()
            {
                User_id = orderDetailsModel.User_id,
                Total = orderDetailsModel.Total,
                Payment_id = orderDetailsModel.Payment_id,
                Created_at = orderDetailsModel.Created_at,
                Modified_at = orderDetailsModel.Created_at,
                IsDeleted = false,
                progress = 0
            };
            db.Order_Details.Add(orderDetails);
            db.SaveChanges();
        }
    }
}
