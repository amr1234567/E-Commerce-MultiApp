using Core;

namespace IService.UseCasesInterfaces.Products
{
    public interface IGetProductsByCategoryIdUseCase
    {
        IEnumerable<Product> Execute(int CategoryId);
    }
}