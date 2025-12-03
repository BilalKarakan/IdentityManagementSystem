using IdentityManagementSystem.Application.DTOs;
using IdentityManagementSystem.Application.Services;
using IdentityManagementSystem.Domain.Entities;
using IdentityManagementSystem.Web.Extensions;
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

            ModelState.AddModelErrorList(identityResult.Errors.Select(x => x.Description).ToList());

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> SignInAsync()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignInAsync(SignInDto model, string? returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Action("Index", "Home");

            var hasUser = await _service.FindUserByEmailAsync(model.Email) as AppUser;

            if (hasUser is null)
            {
                ModelState.AddModelError(string.Empty, "Email veya şifre yanlış");
                return View();
            }

            var signInResult = await _service.PasswordSignInAsync(hasUser, model.Password, model.RememberMe, true);

            if (signInResult.Succeeded)
                return Redirect(returnUrl);

            if (signInResult.IsLockedOut)
            {
                ModelState.AddModelError(string.Empty, "Hesabınız belirli bir süreliğine kilitlenmiştir. Lütfen daha sonra tekrar deneyiniz.");
                return View();
            }

            ModelState.AddModelErrorList(new List<string> { "Email veya şifre yanlış", $"Başarısız giriş sayısı: {await _service.GetAccessFailedCountAsync(hasUser)}" });

            return View();
        }

        [HttpGet]
        public async Task Logout() => await _service.SignOutAsync();
    }
}
