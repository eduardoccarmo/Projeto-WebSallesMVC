using Microsoft.AspNetCore.Mvc;

namespace SallesWebMvc.Controllers
{
    public class VendedorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
