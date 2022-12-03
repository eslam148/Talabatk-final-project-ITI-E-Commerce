using E_CommerceDB;

namespace Services
{
    public class UserServices:Iuser
    {
        private LibraryContext db;
        public UserServices(LibraryContext _db)
        {
            db = new LibraryContext();
          
        }
        public List<User> GetAllusers()
        {
            return db.Users.Where(u =>u.IsDeleted == false).ToList();
            
        }
        public User DeleteUser(string id)
        {
            var user = db.Users.FirstOrDefault(u => u.Id == id);
            user.IsDeleted = true;
            db.SaveChanges();
            return user; 
        }
        public List<User> Search(string SearchedString)
        {
            var searchedUser = db.Users.Where(u => u.First_Name.Contains(SearchedString)).ToList();
            return searchedUser;
        }
    }
}
