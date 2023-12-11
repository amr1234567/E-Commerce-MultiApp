using Core;
using IService.IServiceContract;

namespace IService.UseCasesInterfaces.Products
{
    public interface IGetProductsUseCase
    {

        IEnumerable<Product> Execute();
    }
}