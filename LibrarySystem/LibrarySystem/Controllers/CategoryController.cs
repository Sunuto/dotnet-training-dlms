using LibrarySystem.Business.CategoryBuisness;
using Microsoft.AspNetCore.Mvc;

namespace LibrarySystem.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryBusiness _categoryBusiness;

        public CategoryController(ICategoryBusiness categoryBusiness)
        {
            _categoryBusiness = categoryBusiness;
        }

        public IActionResult Index()
        {
            var categoryList = _categoryBusiness.GetCategoryList();
            return View(categoryList);
        }
    }
}
