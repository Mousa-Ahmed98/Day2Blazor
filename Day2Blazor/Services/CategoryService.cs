

using Day2Blazor.Models;

namespace Day2Blazor.Services
{
    public class CategoryService
    {
        List<Category> categories = new List<Category>();

        public CategoryService()
        {
            categories.Add(new Category { Id = 1, Name = "classic" });
            categories.Add(new Category { Id = 2, Name = "family" });
            categories.Add(new Category { Id = 3, Name = "sports" });
            categories.Add(new Category { Id = 4, Name = "luxary" });
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category? GetById(int id)
        {
            return categories.FirstOrDefault(p => p.Id == id);
        }
    }
}
