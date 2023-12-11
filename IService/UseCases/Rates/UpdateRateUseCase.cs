using Core;
using IService.IServiceContract;
using IService.UseCasesInterfaces.Rates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.UseCases.Rates
{
    public class UpdateRateUseCase : IUpdateRateUseCase
    {
        private readonly IRateService rateService;

        public UpdateRateUseCase(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public void Execute(Rate rate)
        {
            rateService.UpdateRate(rate);
        }
    }
}
