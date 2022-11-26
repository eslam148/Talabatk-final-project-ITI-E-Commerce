using E_CommerceDB;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class ComplainsService : IComplains
    {
        private LibraryContext db;
        IConfiguration con;
        public ComplainsService(LibraryContext _db, IConfiguration _con)
        {
            this.db = _db;
            this.con = _con;
        }

        public List<Complaints> getAllComplains()
        {
            var x = db.Complaints.ToList();
            return x;
        }

        public List<Complaints> getPendingComplains()
        {
             var x=db.Complaints.Where(c=>c.Progress==1).ToList();
            return x;
        }

        public List< Complaints> getSolvedComplains()
        {
            var x = db.Complaints.Where(c => c.Progress == 2).ToList();
            return x;
        }
    }
}
