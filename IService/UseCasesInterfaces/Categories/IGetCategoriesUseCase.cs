using Core;

namespace IService.UseCasesInterfaces.Categorys
{
    public interface IGetCategoriesUseCase
    {
        IEnumerable<Category> Execute();
    }
}