using Core;

namespace IService.UseCasesInterfaces.Rates
{
    public interface IGetRateByIdUseCase
    {
        Rate Execute(int RateId);
    }
}