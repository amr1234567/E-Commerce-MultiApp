using IService.IServiceContract;
using IService.UseCasesInterfaces.Categorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Categorys
{
    public class DeleteCategoryUseCase : IDeleteCategoryUseCase
    {
        private readonly ICategoryService categoryService;

        public DeleteCategoryUseCase(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public void Execute(int categoryId)
        {
            categoryService.DeleteCategory(categoryId);
        }
    }
}
