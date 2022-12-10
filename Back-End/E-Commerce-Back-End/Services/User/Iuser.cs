using E_CommerceDB;
namespace E_Commerce_Back_End
{
    public interface Iuser
    {
        public List<User> GetAllusers();
        public User DeleteUser(string id);
        public List<User> Search(string SearchedString);
        
    }
}
