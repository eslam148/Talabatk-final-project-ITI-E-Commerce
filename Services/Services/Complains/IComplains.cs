using E_CommerceDB;

namespace Services
{
    public interface IComplains
    {
        List<Complaints> getAllComplains();
        List<Complaints> getPendingComplains();

        List<Complaints> getSolvedComplains();
        Complaints getDeatils(int id);
    }
}
