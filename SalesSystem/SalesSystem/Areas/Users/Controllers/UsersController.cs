using Microsoft.AspNetCore.Mvc;

namespace SalesSystem.Areas.Users.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
