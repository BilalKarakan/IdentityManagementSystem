using Microsoft.AspNetCore.Mvc;

namespace IdentityManagementSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> UserListAsync()
        {
            return View();
        }
    }
}
