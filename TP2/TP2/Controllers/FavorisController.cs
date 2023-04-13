using Microsoft.AspNetCore.Mvc;

namespace TP2.Controllers
{
    public class FavorisController : Controller
    {       
        [Route("/favoris")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
