using Core;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Categorys
{
    public class GetCategoriesUseCase : IGetCategoriesUseCase
    {
        private readonly ICategoryService categoryService;

        public GetCategoriesUseCase(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public IEnumerable<Category> Execute()
        {
            return categoryService.GetCategories();
        }
    }
}
