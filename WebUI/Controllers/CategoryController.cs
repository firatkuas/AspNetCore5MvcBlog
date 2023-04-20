using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class CategoryController : Controller
    {
        CategoryManager _manager = new CategoryManager(new EfCategoryDal());
        public IActionResult Index()
        {
            var categories = _manager.GetAllCategories();
            return View(categories);
        }
        public IActionResult Delete()
        {
            return View("Index",_manager.GetAllCategories());
        }
    }
}
