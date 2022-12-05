using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public interface IComplains
    {
        List<Complaints> getAllComplains();
        List<Complaints> getPendingComplains();

        List<Complaints> getSolvedComplains();
        Complaints getDeatils(int id);
    }
}
