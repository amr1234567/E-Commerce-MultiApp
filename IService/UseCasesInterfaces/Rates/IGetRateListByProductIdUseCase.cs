using Core;

namespace IService.UseCasesInterfaces.Rates
{
    public interface IGetRateListByProductIdUseCase
    {
        IEnumerable<Rate> Execute(int ProductId);
    }
}