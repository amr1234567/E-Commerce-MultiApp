using Core;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Products
{
    public class GetProductsByCategoryIdUseCase : IGetProductsByCategoryIdUseCase
    {
        private readonly IProductService productService;

        public GetProductsByCategoryIdUseCase(IProductService productService)
        {
            this.productService = productService;
        }

        public IEnumerable<Product> Execute(int CategoryId)
        {
            return productService.GetProductsByCategoryId(CategoryId);
        }
    }
}
