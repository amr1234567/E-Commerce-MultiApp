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
    public class GetRateByIdUseCase : IGetRateByIdUseCase
    {
        private readonly IRateService rateService;

        public GetRateByIdUseCase(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public Rate Execute(int RateId)
        {
            return rateService.GetRateById(RateId);
        }
    }
}
