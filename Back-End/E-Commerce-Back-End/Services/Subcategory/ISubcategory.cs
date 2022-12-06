using E_Commerce_Back_End;
using E_CommerceDB;

namespace E_Commerce_Back_End
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
