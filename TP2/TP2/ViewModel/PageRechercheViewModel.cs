using TP2.Models;

namespace TP2.ViewModel
{
    public class PageRechercheViewModel
    {
        public CritereRechercheViewModel Criteres { get; set; }
        public List<Enfant> Resultat { get; set; }
    }
}
