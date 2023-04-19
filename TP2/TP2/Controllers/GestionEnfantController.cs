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
            return View();
        }

        // POST: GestionEnfantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
