using Core;

namespace IService.UseCasesInterfaces.Rates
{
    public interface IAddRateUseCase
    {
        void Execute(Rate rate);
    }
}