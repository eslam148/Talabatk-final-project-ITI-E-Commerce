using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public interface IDiscount
    {
        void addDiscount( Discount newDiscount);
        void editDiscount();
        void deleteDiscount(int id);
    }
}
