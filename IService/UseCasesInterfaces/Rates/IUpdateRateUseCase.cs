using Core;

namespace IService.UseCasesInterfaces.Rates
{
    public interface IUpdateRateUseCase
    {
        void Execute(Rate rate);
    }
}