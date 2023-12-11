using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.IServiceContract
{
    public interface ICategoryService
    {
        public void AddCategory(Category category);
        public List<Category> GetCategories();
        public Category GetCategoryById(int id);
        public void EditCategory(Category category);
        public void DeleteCategory(int id);

    }
}
