using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.Models;


namespace TP2.Controllers
{
    public class GestionEnfantController : Controller
    {
        private DataBase _database { get; set; }

        public GestionEnfantController(DataBase Database)
        {
            _database = Database;
        }

        // GET: GestionEnfantController/Delete/5
        public ActionResult Delete(int id)
        {
            var enfantRecherché = _database.Enfants.Where(p => p.Id == id).SingleOrDefault();
            if (enfantRecherché == null)
            {
                return View("NotFound", "Le numéro de l'enfant demandé n'a pas été trouvé!");
            }
            else
            {
                return View("Delete", enfantRecherché);
            }
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                var enfantRecherché = _database.Enfants.Where(p => p.Id == id).SingleOrDefault();
                enfantRecherché.Parent.Enfants.Remove(enfantRecherché);
                _database.Enfants.Remove(enfantRecherché);
                return RedirectToAction("Index", "Home");
            }
            catch
            {
                return View();
            }
        }
    }
}
