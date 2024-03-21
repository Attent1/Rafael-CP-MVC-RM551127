using Microsoft.AspNetCore.Mvc;

namespace Rafael_CP_MVC_RM551127.Controllers
{
    public class ContatosController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.title = "Contatos";
            return View();
        }
    }
}
