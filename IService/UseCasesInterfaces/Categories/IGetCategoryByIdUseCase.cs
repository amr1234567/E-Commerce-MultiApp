using Core;

namespace IService.UseCasesInterfaces.Categorys
{
    public interface IGetCategoryByIdUseCase
    {
        Category Execute(int id);
    }
}