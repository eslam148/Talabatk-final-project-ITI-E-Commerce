using E_CommerceDB;
namespace E_Commerce_Admin_Dashboard_MVC
{
    public interface Iuser
    {
        public List<User> GetAllusers();
        public User DeleteUser(string id);
        
    }
}
