using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public interface IComplains
    {
        List<Complaints> getAllComplains();
        List<Complaints> getPendingComplains();

        List<Complaints> getSolvedComplains();
        Complaints getDeatils(int id);
    }
}
