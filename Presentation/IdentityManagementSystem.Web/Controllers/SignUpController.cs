using Microsoft.AspNetCore.Mvc;

namespace IdentityManagementSystem.Web.Controllers;

public class SignUpController : Controller
{
    public IActionResult SignUp()
    {
        return View();
    }
}
