using TP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TP2.Controllers
{
    public class HomeController : Controller
    {
        private DataBase _database { get; set; }

        public HomeController(DataBase Database)
        {
            _database = Database;
        }


        public ActionResult Index()
        {
            return View(_database.Parents.ToList());
        }
    }
}
