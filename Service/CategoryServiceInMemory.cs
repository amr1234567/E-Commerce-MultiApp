using Core;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryServiceInMemory : ICategoryService
    {
        private readonly IDeleteProductUseCase deleteProduct;
        private readonly IGetProductsByCategoryIdUseCase getProductsByCategoryId;
        private List<Category> categories;
        public CategoryServiceInMemory(
            IDeleteProductUseCase deleteProduct,
            IGetProductsByCategoryIdUseCase getProductsByCategoryId)
        {

            categories = DumyData.categories;
            this.deleteProduct = deleteProduct;
            this.getProductsByCategoryId = getProductsByCategoryId;
        }
        public void AddCategory(Category category)
        {
            if (categories != null && categories.Count() > 0 && category != null)
            {
                var id = categories.Max(p => p.Id);
                category.Id = id + 1;
                categories.Add(category);
            }
            else if (category != null && categories != null && categories.Count() == 0)
            {
                category.Id = 1;
                categories.Add(category);
            }
            if (category !=null)
            {
                categories?.Add(category);
            }
        }

        public void DeleteCategory(int id)
        {
            var category = GetCategoryById(id);
            if(category != null)
            {
                var products = getProductsByCategoryId.Execute(category.Id);
                foreach(var product in products)
                    deleteProduct.Execute(product.Id);
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
