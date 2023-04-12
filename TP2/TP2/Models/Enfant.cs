namespace TP2.Models
{
    public class Enfant
    {
        public int Id { get; set; }

        public int IdParent { get; set; }

        public Parent Parent { get; set; }

        public String Nom { get; set; }

        public String ImageURL { get; set; }

        public String Description { get; set; }

        public bool EstVedette { get; set; }

        public String Moteur { get; set; }

        public String Couleur { get; set; }

        public String Model { get; set; }

        public int NbPorte { get; set; }

        public int Km { get; set; }

        public int Hp { get; set; }
    }
}
