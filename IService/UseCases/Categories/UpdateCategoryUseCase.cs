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
    public class UpdateCategoryUseCase : IUpdateCategoryUseCase
    {
        private readonly ICategoryService categoryService;

        public UpdateCategoryUseCase(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public void Execute(Category category)
        {
            categoryService.EditCategory(category);
        }
    }
}
