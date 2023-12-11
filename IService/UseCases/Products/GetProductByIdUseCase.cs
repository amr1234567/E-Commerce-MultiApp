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
    public class GetProductByIdUseCase : IGetProductByIdUseCase
    {
        private readonly IProductService productService;

        public GetProductByIdUseCase(IProductService productService)
        {
            this.productService = productService;
        }

        public Product Execute(int id)
        {
            return productService.GetProduct(id);
        }
    }
}
