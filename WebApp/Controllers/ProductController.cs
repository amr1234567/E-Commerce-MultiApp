using Core;
using IService.UseCasesInterfaces.Categorys;
using IService.UseCasesInterfaces.Products;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly IGetProductsUseCase getProducts;
        public readonly IGetProductByIdUseCase GetProduct;
        private readonly IUpdateProductUseCase editProduct;
        private readonly IDeleteProductUseCase deleteProduct;
        private readonly IAddProductUseCase addProduct;
        private readonly IGetCategoriesUseCase getCategories;

        public ProductController(
            IGetProductsUseCase getProducts,
            IGetProductByIdUseCase getProduct,
            IUpdateProductUseCase editProduct,
            IDeleteProductUseCase deleteProduct,
            IAddProductUseCase addProduct,
            IGetCategoriesUseCase getCategories
            )
        {
            this.getProducts = getProducts;
            GetProduct = getProduct;
            this.editProduct = editProduct;
            this.deleteProduct = deleteProduct;
            this.addProduct = addProduct;
            this.getCategories = getCategories;
        }

        public IActionResult Index()
        {
            return View(getProducts.Execute());
        }

        public IActionResult Details(int id)
        {
            return View(GetProduct.Execute(id));
        }

        public ActionResult Edit(int id)
        {
            
            ViewBag.items = getCategories.Execute();
            return View(GetProduct.Execute(id));
        }

        // POST: HomeController1/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Product product)
        {
            if (ModelState.IsValid)
            {
                editProduct.Execute(product);
                return RedirectToAction(nameof(Index));
            }
            return View(GetProduct.Execute(id));
        }
        
        public IActionResult Delete(int id)
        {
            return View(GetProduct.Execute(id));
        }

        [HttpPost]
        public IActionResult Delete(int Id ,Product product)
        {
            deleteProduct.Execute(Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Add()
        {
            ViewBag.items = getCategories.Execute();
            return View();
        }


        [HttpPost]
        public IActionResult Add(Product product)
        {
            if (ModelState.IsValid)
            {
                addProduct.Execute(product);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }
    }
}
