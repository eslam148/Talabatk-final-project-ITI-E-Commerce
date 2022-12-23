using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Admin_Dashboard_MVC.Services
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
            var order = db.Order_Details.FirstOrDefault(o=>o.Id== id);
            order.IsDeleted =true;
            db.SaveChanges();
        }

        public List<Order_Details> GetPendingOrders()
        {
            var pending = db.Order_Details.Where(o => o.progress == 0 && o.IsDeleted == false).ToList();
            return pending;
        }

        public List<Order_Details> GetDeliveredOrders()
        {
            var delivered = db.Order_Details.Where(o => o.progress == 2 && o.IsDeleted == false).ToList();
            return delivered;
        }

        public void updateProgress(int id, int Progress)
        {
            var order = db.Order_Details.Where(o => o.Id == id).FirstOrDefault();
            order.progress = Progress;
            db.SaveChanges();
        }
        public List<Order_Details> GetShippingOrders()
        {
            var delivered = db.Order_Details.Where(o => o.progress == 1 && o.IsDeleted == false).ToList();
            return delivered;
        }

    }
}
