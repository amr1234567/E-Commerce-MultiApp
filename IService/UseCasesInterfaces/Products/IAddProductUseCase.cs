using Core;

namespace IService.UseCasesInterfaces.Products
{
    public interface IAddProductUseCase
    {
        void Execute(Product product);
    }
}