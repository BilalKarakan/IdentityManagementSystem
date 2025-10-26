using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Application.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace IdentityManagementSystem.Web.Controllers
{
    public class RegisterController(IRegisterService _service) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> SignUpAsync()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUpAsync(SignUpDto request)
        {

            if (!ModelState.IsValid)
            {
                return View();
            }

            var identityResult = await _service.CreateAsync(request);

            if (identityResult.Succeeded)
            {
                TempData["SuccessMessage"] = "Registration process is successfully.";
                return RedirectToAction("SignUp", "Register");
            }

            foreach (IdentityError error in identityResult.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }

            return View();
        }
    }
}
