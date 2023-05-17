using Microsoft.AspNetCore.Mvc;

namespace ParcialPresentacionWeb3.Controllers
{
    public class PresentacionWeb3 : Controller
    {
        public IActionResult Bienvenidos()
        {
            return View();
        }
    }
}
