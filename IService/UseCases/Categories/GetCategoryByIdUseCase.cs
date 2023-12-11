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
    public class GetCategoryByIdUseCase : IGetCategoryByIdUseCase
    {
        private readonly ICategoryService categoryService;

        public GetCategoryByIdUseCase(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        public Category Execute(int id)
        {
            return categoryService.GetCategoryById(id);
        }
    }
}
