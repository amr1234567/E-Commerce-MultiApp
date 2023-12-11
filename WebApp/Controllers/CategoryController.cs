using Core;
using IService.UseCasesInterfaces.Categorys;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class CategoryController : Controller
    {
        private readonly IGetCategoriesUseCase getCategories;
        private readonly IGetCategoryByIdUseCase getCategory;
        private readonly IAddCategoryUseCase addCategory;
        private readonly IUpdateCategoryUseCase updateCategory;
        private readonly IDeleteCategoryUseCase deleteCategory;

        public CategoryController(
            IGetCategoriesUseCase getCategories,
            IGetCategoryByIdUseCase getCategory,
            IAddCategoryUseCase addCategory,
            IUpdateCategoryUseCase updateCategory,
            IDeleteCategoryUseCase deleteCategory
            )
        {
            this.getCategories = getCategories;
            this.getCategory = getCategory;
            this.addCategory = addCategory;
            this.updateCategory = updateCategory;
            this.deleteCategory = deleteCategory;
        }
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(getCategories.Execute());
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View(getCategory.Execute(id));
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                addCategory.Execute(category);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return BadRequest(ModelState);
            }
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            return View(getCategory.Execute(id));
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                updateCategory.Execute(category);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return BadRequest();
            }
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            return View(getCategory.Execute(id));
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Category category)
        {
            deleteCategory.Execute(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
