using E_CommerceDB;

namespace E_Commerce_Back_End
{
    public class DiscountService:IDiscount
    {
        private LibraryContext db;
        IConfiguration con;
        public DiscountService(LibraryContext _db, IConfiguration _con)
        {
            this.db = _db;
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
            var d =  db.Discount.Where(i=>i.IsDeleted==false).ToList();
            List<Discount> discountList = new List<Discount>();
            foreach (var item in d)
            {
                discountList.Add(new Discount()
                {
                    Id = item.Id,
                    Name = item.Name
                });
            }
            return discountList;
        }
    }
}
