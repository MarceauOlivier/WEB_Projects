using TP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP2.Controllers
{
    public class EnfantController : Controller
    {
        private DataBase _database { get; set; }

        public EnfantController(DataBase Database)
        {
            _database = Database;
        }

        public ActionResult Recherche()
        {
            return View(_database.Enfants.ToList());
        }
     
        public ActionResult Detail(int id)
        {
            var enfantRecherché = _database.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (enfantRecherché == null)
            {
                return View("NotFound", "Le numéro de l'enfant demandé n'a pas été trouvé!");
            }
            else
            {
                return View(enfantRecherché);
            }
        }     
    }
}
