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
    public class AddProductUseCase : IAddProductUseCase
    {
        private IProductService ProductService { get; }
        public AddProductUseCase(IProductService productService)
        {
            ProductService = productService;
        }
        public void Execute(Product product)
        {
            ProductService.AddProduct(product);
        }
    }
}
