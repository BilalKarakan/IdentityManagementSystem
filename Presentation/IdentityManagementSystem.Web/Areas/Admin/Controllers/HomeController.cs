using IdentityManagementSystem.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManagementSystem.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController(IUserService _userService) : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UserListAsync()
        {
            var userList = await _userService.GetListAsync();
            return View(userList);
        }
    }
}
