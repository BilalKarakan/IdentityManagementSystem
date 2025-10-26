using Microsoft.AspNetCore.Mvc;

namespace IdentityManagementSystem.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
