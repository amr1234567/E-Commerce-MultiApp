using Core;

namespace IService.UseCasesInterfaces.Products
{
    public interface IGetProductByIdUseCase
    {
        Product Execute(int id);
    }
}