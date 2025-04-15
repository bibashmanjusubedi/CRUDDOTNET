using Microsoft.AspNetCore.Mvc;

namespace ObjectCrudApp.Controllers
{
    public class AccountController :Controller
    {
        // Get : Account/ LogIn
        public IActionResult Index()
        {
            return View();
        }
    }
}