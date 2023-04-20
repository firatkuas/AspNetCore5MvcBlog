using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Controllers
{
    public class BlogController : Controller
    {
        IBlogService _manager = new BlogManager(new EfBlogDal());
        public IActionResult Index()
        {
            var blogs = _manager.GetAllBlogsWithCategories();
            return View(blogs);
        }
    }
}
