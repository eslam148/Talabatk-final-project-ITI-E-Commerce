using E_Commerce_Admin_Dashboard_MVC.Controllers;
using E_Commerce_Admin_Dashboard_MVC.Models;
using E_CommerceDB;
using System.Collections.Generic;

namespace E_Commerce_Admin_Dashboard_MVC
{
    public class CategoryService : ICategory
    {
        private LibraryContext db;
        IConfiguration con;

        public CategoryService(LibraryContext _db, IConfiguration _con)
        {
            db = _db;
            con = _con;
        }
        public void Add(CategoryCreateModel category)
        {
            Category Cat = new Category
            {
                Name = category.Name,
                Description = category.Description,
                NameAr = category.NameAr,
                DescriptionAr = category.DescriptionAr,
                created_at = DateTime.Now,
                deleted_at = DateTime.Now,
                modified_at = DateTime.Now
            };
            db.Category.Add(Cat);
            save();
        }

        public void delete(int id)
        {
            var cat = db.Category.Find(id);
            cat.deleted_at = DateTime.Now;
            cat.IsDeleted = true;
            save();
        }

        public List<CategoryCreateModel> get()
        {
            var cats = db.Category.Where(c => c.IsDeleted ==false);
            List<CategoryCreateModel> CatList = new List<CategoryCreateModel>();
            foreach (var cat in cats)
            {
                CatList.Add(new CategoryCreateModel()
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    NameAr = cat.NameAr,
                    DescriptionAr = cat.DescriptionAr,
                    created_at = cat.created_at,
                    Description = cat.Description,
                    modified_at = cat.modified_at,
                });

            }
            return CatList;
        }

        public CategoryCreateModel get(int id)
        {
            var cats = db.Category.FirstOrDefault(c => c.Id == id);

            return new CategoryCreateModel()
            {
                Id = cats.Id,
                Name = cats.Name,
                NameAr = cats.NameAr,
                DescriptionAr = cats.DescriptionAr,
                created_at = cats.created_at,
                Description = cats.Description,
                modified_at = cats.modified_at,
            };
        }
        public void update(CategoryCreateModel category)
        {
            var cat = db.Category.FirstOrDefault(c => c.Id == category.Id);
            cat.Name = category.Name;
            cat.modified_at = DateTime.Now;
            cat.Description = category.Description;
            cat.NameAr =  category.NameAr;
            cat.DescriptionAr= category.DescriptionAr;
            save();
        }
        public void save()
        {
            db.SaveChanges();
        }

        public List<CategoryCreateModel> get(string Name)
        {
            var cats = db.Category.Where(c => c.IsDeleted ==false && c.Name.StartsWith(Name));
            List<CategoryCreateModel> CatList = new List<CategoryCreateModel>();
            foreach (var cat in cats)
            {
                CatList.Add(new CategoryCreateModel()
                {
                    Id = cat.Id,
                    Name = cat.Name,
                    NameAr = cat.NameAr,
                    DescriptionAr = cat.DescriptionAr,
                    created_at = cat.created_at,
                    Description = cat.Description,
                    modified_at = cat.modified_at,
                });

            }
            return CatList;
        }
    }
}
