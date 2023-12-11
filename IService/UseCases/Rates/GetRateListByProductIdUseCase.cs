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
    public class GetRateListByProductIdUseCase : IGetRateListByProductIdUseCase
    {
        private readonly IRateService rateService;

        public GetRateListByProductIdUseCase(IRateService rateService)
        {
            this.rateService = rateService;
        }

        public IEnumerable<Rate> Execute(int ProductId)
        {
            return rateService.GetRateListByProductId(ProductId);
        }
    }
}
