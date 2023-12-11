using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryServiceInMemory : ICategoryService
    {
        private List<Category> categories;
        public CategoryServiceInMemory()
        {

            categories = DumyData.categories;
        }
        public void AddCategory(Category category)
        {
            if(category !=null)
            {
                categories.Add(category);
            }
        }

        public void DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            if(category != null)
            {
                categories.Remove(category);
            }
        }

        public void EditCategory(Category category)
        {
            if (category != null)
            {
                var originalCategory = GetCategoryById(category.Id);
                if (originalCategory != null)
                {
                    originalCategory.Name = category.Name;
                    originalCategory.Description = category.Description;
                }
            }
        }

        public List<Category> GetCategories()
        {
            return categories;
        }

        public Category GetCategoryById(int id)
        {
            var category = categories.FirstOrDefault(c => c.Id == id);
            return category;
        }
    }
}
