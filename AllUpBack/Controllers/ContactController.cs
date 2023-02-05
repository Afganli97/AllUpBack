using Microsoft.AspNetCore.Mvc;

namespace AllUpBack.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}