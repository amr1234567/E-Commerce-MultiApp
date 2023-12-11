using IService.IServiceContract;
using IService.UseCasesInterfaces.Rates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Rates
{
    public class DeleteRateUseCase : IDeleteRateUseCase
    {
        private readonly IRateService rateService;

        public DeleteRateUseCase(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public void Execute(int RateId)
        {
            rateService.RemoveRate(RateId);
        }
    }
}
