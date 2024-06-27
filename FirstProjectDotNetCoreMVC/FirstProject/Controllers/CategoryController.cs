using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
