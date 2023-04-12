namespace TP2.Models
{
    public class Parent
    {
        public int Id { get; set; }
       
        public List<Enfant> Enfants { get; set; }

        public String Nom { get; set; }

        public String ImageURL { get; set; }

        public int NbDispo { get; set; }

        public int KmMoyen { get; set; }

        public String Description { get; set; }

        public Parent()
        {
            Enfants = new List<Enfant>();
        }
    }
}
