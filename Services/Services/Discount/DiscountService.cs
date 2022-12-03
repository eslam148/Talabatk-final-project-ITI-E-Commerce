using Castle.Core.Configuration;
using E_CommerceDB;

namespace Services
{
    public class DiscountService:IDiscount
    {
        private LibraryContext db;
        IConfiguration con;
        public DiscountService(LibraryContext _db, IConfiguration _con)
        {
            this.db = new LibraryContext();
            this.con = _con;
        }

        public void addDiscount(Discount newDiscount)
        {
            db.Discount.Add(newDiscount);
            db.SaveChanges();
        }

        public void deleteDiscount(int id)
        {
            db.Discount.Where(disc => disc.Id == id).FirstOrDefault().IsDeleted = true;
            db.SaveChanges();
        }

        public List<Discount> getAllDiscount()
        {
            return db.Discount.Where(i=>i.IsDeleted==false).ToList();
        }
    }
}
