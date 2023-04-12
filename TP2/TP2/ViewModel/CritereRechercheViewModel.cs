namespace TP2.ViewModel
{
    public class CritereRechercheViewModel
    {
        public string ChoixPourModelVedette { get; set; }
        public string MotsCles { get; set; }
        public bool EstUnNissan  { get; set; }
        public bool EstUnToyota { get; set; }
        public bool EstUnHonda { get; set; }
        public int? MaxNbKilo { get; set; }
        public int? MinNbKilo { get; set; }
    }
}
