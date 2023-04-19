using TP2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TP2.ViewModel;

namespace TP2.Controllers
{
    public class EnfantController : Controller
    {
        private DataBase _database { get; set; }

        public EnfantController(DataBase Database)
        {
            _database = Database;
        }

        [Route("enfant/recherche")]
        public ActionResult Recherche()
        {
            var model = new PageRechercheViewModel();
            model.Criteres = new CritereRechercheViewModel();
            model.Criteres.EstUnNissan = true;
            model.Criteres.EstUnToyota = true;
            model.Criteres.EstUnHonda = true;
            model.Criteres.ChoixPourModelVedette = "PeuImporte";
            model.Resultat = _database.Enfants.ToList();
            return View(model);
        }


        [Route("enfant/detail/{id:int}")]
        [Route("enfant/{id:int}")]      
        [Route("{id:int}")]
        public ActionResult DetailParID(int id)
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


        [Route("enfant/detail/{nom}")]
        [Route("enfant/{nom}")]
        [Route("/{nom}")]
        public ActionResult DetailParNom(string nom)
        {
            var enfantRecherché = _database.Enfants.Where(p => p.Nom.ToUpper() == nom.ToUpper()).SingleOrDefault();
            if (enfantRecherché == null)
            {
                return View("NotFound", "Le numéro de l'enfant demandé n'a pas été trouvé!");
            }
            else
            {
                return View("Detail", enfantRecherché);
            }
        }

        [Route("enfant/filtrer")]     
        public ActionResult Filtrer(CritereRechercheViewModel criteres)
        {
            IEnumerable<Enfant> donnees = _database.Enfants;

            if (!criteres.EstUnNissan)
            {
                donnees = donnees.Where(e => e.Parent.Nom != "Nissan");
            }
            if (!criteres.EstUnToyota)
            {
                donnees = donnees.Where(e => e.Parent.Nom != "Toyota");
            }
            if (!criteres.EstUnHonda)
            {
                donnees = donnees.Where(e => e.Parent.Nom != "Honda");
            }

            if (criteres.MinNbKilo != null)
            {
                donnees = donnees.Where(e => e.Km > criteres.MinNbKilo);
            }

            if (criteres.MaxNbKilo != null)
            {
                donnees = donnees.Where(e => e.Km < criteres.MaxNbKilo);
            }

            if (criteres.ChoixPourModelVedette == "Oui")
            {
                donnees = donnees.Where(e => e.EstVedette == true);
            }
            else if (criteres.ChoixPourModelVedette == "Non")
            {
                donnees = donnees.Where(e => e.EstVedette == false);
            }
            else
            {
                donnees = donnees.Where(e => e.EstVedette == true || e.EstVedette == false);
            }

            PageRechercheViewModel pageRechercheViewModel = new PageRechercheViewModel();

            pageRechercheViewModel.Criteres = criteres;

            pageRechercheViewModel.Resultat = donnees.ToList();
           
            return View("Recherche", pageRechercheViewModel);
        }
    }
}
