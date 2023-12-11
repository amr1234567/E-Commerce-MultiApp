using Core;
using IService.IServiceContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class RateServiceInMemory : IRateService
    {
        private List<Rate> rates;
        public RateServiceInMemory()
        {
            rates = DumyData.rates;
        }
        public void AddRate(Rate rate)
        {
            if (rates != null && rates.Count() > 0 && rate != null)
            {
                var id = rates.Max(p => p.Id);
                rate.Id = id + 1;
                rates.Add(rate);
            }
            else if (rate != null && rates != null && rates.Count() == 0)
            {
                rate.Id = 1;
                rates.Add(rate);
            }
        }

        public Rate GetRateById(int Rateid)
        {
            var rate = rates.FirstOrDefault(r => r.Id == Rateid);
            return rate;
        }

        public List<Rate> GetRateListByProductId(int ProductId)
        {
            var ratesList = rates.Where(r => r.ProductId == ProductId);
            if (ratesList.Count() > 0 && ratesList != null)
                return ratesList.ToList();
            else
                return null;
        }

        public void RemoveRate(int id)
        {
            var rate = GetRateById(id);
            if(rate != null)
                rates.Remove(rate);

        }

        public void UpdateRate(Rate rate)
        {
            if (rate != null)
            {
                var OriginalRate = GetRateById(rate.Id);
                if (OriginalRate != null)
                {
                    OriginalRate.RateNum = rate.RateNum;
                    OriginalRate.Comment = rate.Comment;
                }
            }
        }
    }
}
