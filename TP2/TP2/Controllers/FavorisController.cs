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
            return View(_database.Enfants.Take(3).ToList());
        }

        public ActionResult AjouterUnEnfant(int id)
        {
            var enfantRecherché = _database.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (enfantRecherché == null)
            {
                return View("NotFound", "Le numéro de l'enfant demandé n'a pas été trouvé!");
            }
            else
            {
                return View("Detail", enfantRecherché);
            }
        }

        public ActionResult SupprimerUnEnfant(int id)
        {
            var enfantRecherché = _database.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (enfantRecherché == null)
            {
                return View("NotFound", "Le numéro de l'enfant demandé n'a pas été trouvé!");
            }
            else
            {
                return View("Detail", enfantRecherché);
            }
        }
    }
}
