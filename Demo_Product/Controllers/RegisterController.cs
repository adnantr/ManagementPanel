using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserRegisterViewModel model)
        {
            AppUser appUser = new AppUser()
            {
                Name = model.Name,
                Surname = model.SurName,
                UserName = model.UserName,
                Email=model.Mail

            };
            if (model.Password==null)
            {
                TempData["PasswordNull"] = "Lütfen şifre giriniz";
            }
            else
            {
                if (model.Password == model.ComfirmPassword)
                {
                    var result = await _userManager.CreateAsync(appUser, model.Password);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                    else
                    {
                        foreach (var item in result.Errors)
                        {
                            ModelState.AddModelError("", item.Description);
                        }

                    }

                }
                else
                {
                    TempData["PasswordNull"] = "Şifreler eşleşmiyor.Lütfen dikkatli giriş yapınız.";
                }
            }
            return View(model);
        }
    }
}
