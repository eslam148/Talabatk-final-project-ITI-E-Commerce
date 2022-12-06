using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public interface IDiscount
    {
        void addDiscount(Discount newDiscount);
        List<Discount> getAllDiscount();
        void deleteDiscount(int id);
    }
}
