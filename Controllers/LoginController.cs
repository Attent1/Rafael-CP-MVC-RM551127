using Microsoft.AspNetCore.Mvc;

namespace Rafael_CP_MVC_RM551127.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LoginSuccess()
        {
            return View();
        }
    }
}
