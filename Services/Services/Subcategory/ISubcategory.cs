using Services;
using E_CommerceDB;

namespace Services
{
    public interface ISubcategory
    {
        public List<SubcategoryModelView> Get();
        public SubcategoryModelView Get(int id);
        public void Update(int id,SubcategoryModelView sub);
        public void Add(SubcategoryModelView sub);
        public void Delete(int id);
        public List<SubcategoryModelView> GetSubcategoryByCategoryId(int Id);
        public void Save();

    }
}
