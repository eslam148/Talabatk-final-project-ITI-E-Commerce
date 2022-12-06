
using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public interface Iorder
    {
        public List<OrderItems> GetOrders();
        public void Delete(int id);
        public List<OrderItems> GetPendingOrders();
        public List<OrderItems> GetDeliveredOrders();

    }
}
