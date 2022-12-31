using E_Commerce_Back_End;
using E_CommerceDB;
using Microsoft.EntityFrameworkCore;

namespace E_Commerce_Back_End
{
    public class SubcategoryService: ISubcategory
    {
        private LibraryContext db;
        IConfiguration con;

        public SubcategoryService(LibraryContext _db, IConfiguration _con)
        {
            db = _db;
            con = _con;
        }

        public void Add(SubcategoryModelView sub)
        {
            db.SubCategories.Add(new SubCategories()
            {
                BrandName = sub.BrandName,
                CategoryId = sub.CategoryId
            });
            Save();

        }

        public void Delete(int id)
        {
            var sub = db.SubCategories.FirstOrDefault(s => s.Id == id);
            db.SubCategories.Remove(sub);
            Save();
        }

        public List<SubcategoryModelView> Get()
        {
            var Subs = db.SubCategories.Select(i=>i).ToList();
            List<SubcategoryModelView> sub = new List<SubcategoryModelView>();
            foreach(var s in Subs)
            {
                sub.Add(new SubcategoryModelView()
                {
                    Id  = s.Id,
                    BrandName = s.BrandName,
                    BrandNameAr = s.BrandNameAr,
                    CategoryId = s.CategoryId,
                    CategoryName = db.Category.Where(i=>i.Id==s.CategoryId).Select(x=>x.Name).FirstOrDefault(),
                    CategoryNameAr = db.Category.Where(i => i.Id==s.CategoryId).Select(x => x.NameAr).FirstOrDefault(),
                    IsDeleted = s.IsDeleted
                });
            };

            return sub;
        }

        public SubcategoryModelView Get(int id)
        {
            var s = db.SubCategories.FirstOrDefault(s => s.Id == id);
            return new SubcategoryModelView()
            {
                BrandName = s.BrandName,
                BrandNameAr = s.BrandNameAr,
                CategoryId = s.CategoryId,
                CategoryName = db.Category.Where(i => i.Id==s.CategoryId).Select(x => x.Name).FirstOrDefault(),
                CategoryNameAr = db.Category.Where(i => i.Id==s.CategoryId).Select(x => x.NameAr).FirstOrDefault(),

                IsDeleted = s.IsDeleted
            };
        }

        public List<SubcategoryModelView> GetSubcategoryByCategoryId(int Id)
        {
            var Subs = db.SubCategories.Where(c=>c.CategoryId == Id).ToList();
            List<SubcategoryModelView> sub = new List<SubcategoryModelView>();
            foreach (var s in Subs)
            {
                sub.Add(new SubcategoryModelView()
                {
                    Id=s.Id,
                    BrandName = s.BrandName,
                    BrandNameAr = s.BrandNameAr,
                    CategoryId = s.CategoryId,
                    CategoryName = db.Category.Where(i => i.Id==s.CategoryId).Select(x => x.Name).FirstOrDefault(),
                    CategoryNameAr = db.Category.Where(i => i.Id==s.CategoryId).Select(x => x.NameAr).FirstOrDefault(),
                    created_at = s.created_at,
                    modified_at = s.modified_at,
                    IsDeleted = s.IsDeleted
                });
            };

            return sub;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(int id, SubcategoryModelView sub)
        {
            var s = db.SubCategories.FirstOrDefault(s => s.Id == id);
            s.BrandName = sub.BrandName;
            s.CategoryId = sub.CategoryId;
            Save();
        }
    }
}
