using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.Models;

namespace TP2.Controllers
{
    public class FavorisController : Controller
    {
        private DataBase _database { get; set; }

        public FavorisController(DataBase Database)
        {
            _database = Database;
        }

        [Route("/favoris")]
        public IActionResult Index()
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            var enfantsDeLaBD = _database.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();

            return View(enfantsDeLaBD);
        }

        public ActionResult AjouterUnEnfant(int id)
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            if (!enfantIDs.Contains(id))
            {
              enfantIDs.Add(id);
            }

            var enfantsDeLaBD = _database.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();

            HttpContext.Session.Set<List<int>>("enfantIDs", enfantIDs);

            return View("Index", enfantsDeLaBD);
        }

        public ActionResult SupprimerUnEnfant(int id)
        {
            var enfantIDs = HttpContext.Session.Get<List<int>>("enfantIDs");
            if (enfantIDs == null)
            {
                enfantIDs = new List<int>();
            }

            enfantIDs.Remove(id);

            var enfantsDeLaBD = _database.Enfants.Where(e => enfantIDs.Contains(e.Id)).ToList();

            HttpContext.Session.Set<List<int>>("enfantIDs", enfantIDs);

            return View("Index", enfantsDeLaBD);
        }
    }
}
