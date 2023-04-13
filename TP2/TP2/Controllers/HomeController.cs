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

        [Route("")]       
        [Route("/home")]
        public ActionResult Index()
        {
            return View("index", _database.Parents.ToList());
        }
    }
}
