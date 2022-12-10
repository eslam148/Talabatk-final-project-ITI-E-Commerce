using E_CommerceDB;

namespace E_Commerce_Back_End { 
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

        public Complaints getDeatils( int id)
        {
            var x=db.Complaints.Where(c => c.Id == id).FirstOrDefault();
            db.Complaints
                .Where(c => c.Id == id)
                .FirstOrDefault().Progress=(int) ComplainsStatus.Pending;
            db.SaveChanges();

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
