using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IService.IServiceContract
{
    public interface IRateService
    {
        public Rate GetRateById(int Rateid);
        public void AddRate(Rate rate);
        public void RemoveRate(int id);
        public void UpdateRate(Rate rate);
        public List<Rate> GetRateListByProductId(int ProductId);

    }
}
