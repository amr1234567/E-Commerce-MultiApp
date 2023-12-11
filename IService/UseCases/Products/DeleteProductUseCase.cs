using IService.IServiceContract;
using IService.UseCasesInterfaces.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Products
{
    public class DeleteProductUseCase : IDeleteProductUseCase
    {
        private IProductService ProductService { get; }
        public DeleteProductUseCase(IProductService productService)
        {
            ProductService = productService;
        }

        public void Execute(int ProductId)
        {
            ProductService.DeleteProduct(ProductId);
        }

    }
}
