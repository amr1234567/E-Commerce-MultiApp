using IService.IServiceContract;

namespace IService.UseCasesInterfaces.Products
{
    public interface IDeleteProductUseCase
    {

        void Execute(int ProductId);
    }
}