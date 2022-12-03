using E_CommerceDB;

namespace Services
{
    public interface IDiscount
    {
        void addDiscount(Discount newDiscount);
        List<Discount> getAllDiscount();
        void deleteDiscount(int id);
    }
}
