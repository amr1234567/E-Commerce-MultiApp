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
    public class UpdateProductUseCase : IUpdateProductUseCase
    {
        private readonly IProductService productService;

        public UpdateProductUseCase(IProductService productService)
        {
            this.productService = productService;
        }

        public void Execute(Product product)
        {
            productService.UpdateProduct(product);
        }
    }
}
