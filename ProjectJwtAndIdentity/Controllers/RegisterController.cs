using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using ProjectJwtAndIdentity.Entities;
using ProjectJwtAndIdentity.Models;

namespace ProjectJwtAndIdentity.Context
{
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]

        public async Task<IActionResult> Index(RegisterViewModel model)
        {

            AppUser user = new AppUser
            {
                UserName = model.Username,
                Email = model.Email,
                Name = model.Name,
                Surname = model.Surname
            };
            await _userManager.CreateAsync(user, model.Password);
            return RedirectToAction("RoleList", "Role");

        }
    }
}
