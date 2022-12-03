using Services;
using E_CommerceDB;

namespace Services
{
    public interface ICategory 
    {
        public List<CategoryCreateModel> get();
        public CategoryCreateModel get(int id);
        public void Add(CategoryCreateModel category);
        public void update(CategoryCreateModel category);
        public void delete(int id);
        public void save();
        public List<CategoryCreateModel> get(string Name);
    }
}
