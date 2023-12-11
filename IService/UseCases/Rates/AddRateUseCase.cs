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
    public class AddRateUseCase : IAddRateUseCase
    {
        private readonly IRateService rateService;

        public AddRateUseCase(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public void Execute(Rate rate)
        {
            rateService.AddRate(rate);
        }
    }
}
