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
    public class GetProductsUseCase : IGetProductsUseCase
    {
        private IProductService ProductService { get; }

        public GetProductsUseCase(IProductService productService)
        {
            ProductService = productService;
        }

        public IEnumerable<Product> Execute()
        {
            return ProductService.GetProducts();
        }
    }
}
