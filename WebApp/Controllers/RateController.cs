using Core;
using IService.UseCasesInterfaces.Products;
using IService.UseCasesInterfaces.Rates;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace WebApp.Controllers
{
    public class RateController : Controller
    {
        private readonly IGetProductByIdUseCase getProductById;
        private readonly IGetRateListByProductIdUseCase getRateListByProductId;
        private readonly IAddRateUseCase addRate;
        private readonly IGetRateByIdUseCase getRate;
        private readonly IUpdateRateUseCase updateRate;
        private readonly IDeleteRateUseCase deleteRate;

        public RateController(
            IGetProductByIdUseCase getProductById,
            IGetRateListByProductIdUseCase getRateListByProductId,
            IAddRateUseCase addRate,
            IGetRateByIdUseCase getRate,
            IUpdateRateUseCase updateRate,
            IDeleteRateUseCase deleteRate
            )
        {
            this.getProductById = getProductById;
            this.getRateListByProductId = getRateListByProductId;
            this.addRate = addRate;
            this.getRate = getRate;
            this.updateRate = updateRate;
            this.deleteRate = deleteRate;
        }
        
        public ActionResult GetRatesPerProduct(int id)
        {
            ViewBag.productName = getProductById.Execute(id).Name;
            var rates = getRateListByProductId.Execute(id);
            return View(rates);
        }

        // GET: RateController1/Create/2
        public ActionResult Create(int id)
        {
            ViewBag.ProductName = getProductById.Execute(id).Name;
            ViewBag.ProductId = id;
            return View();
        }

        // POST: RateController1/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Rate rate)
        {
            if (ModelState.IsValid)
            {
                addRate.Execute(rate);
                return RedirectToAction("Index","Product");
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // GET: RateController1/Edit/5
        public ActionResult Edit(int id)
        {
            return View(getRate.Execute(id));
        }

        // POST: RateController1/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Rate rate)
        {
            if (ModelState.IsValid)
            {
                updateRate.Execute(rate);
                return RedirectToAction(nameof(GetRatesPerProduct), new { id = rate.ProductId });
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // GET: RateController1/Delete/5
        public ActionResult Delete(int id , int productId)
        {
            ViewBag.productId = productId;
            return View(getRate.Execute(id));
        }

        // POST: RateController1/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id,string productId)
        {
            deleteRate.Execute(id);
            return RedirectToAction(nameof(GetRatesPerProduct), new { id = int.Parse(productId) });
        }
    }
}
