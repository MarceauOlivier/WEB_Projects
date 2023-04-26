using System.Collections.Generic;
using System.Linq;

namespace TP2.Models
{
    public class DataBase
    {
        public List<Enfant> Enfants { get; set; }

        public List<Parent> Parents { get; set; }

        public DataBase()
        {
            Enfants = new List<Enfant>();
            Parents = new List<Parent>();

            Enfants.Add(new Enfant() { Id = 1, Nom = "Skyline", Couleur = "Blue", Moteur = "RB26DET", Km = 39000, Hp = 370, NbPorte = 2, IdParent = 1, Model = "R32", EstVedette = true, ImageURL = "/images/skylineR32.jpg", Description = " Super clean  R32 GT-R  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 2, Nom = "180sx", Couleur = "Silver", Moteur = "SR20DET", Km = 78000, Hp = 260, NbPorte = 2, IdParent = 1, Model = "S13", EstVedette = true, ImageURL = "/images/180sx.jpg", Description = " Super clean  180sx  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 3, Nom = "300zx", Couleur = "Black", Moteur = "VG30DETT", Km = 121000, Hp = 300, NbPorte = 2, IdParent = 1, Model = "Z32", EstVedette = false, ImageURL = "/images/300zx.jpg", Description = " Super clean  300zx  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 4, Nom = "Silvia", Couleur = "Red", Moteur = "SR20DET", Km = 19000, Hp = 280, NbPorte = 2, IdParent = 1, Model = "S15", EstVedette = true, ImageURL = "/images/s15.jpg", Description = " Super clean  Silvia S15  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 5, Nom = "Supra", Couleur = "Red", Moteur = "B58", Km = 900, Hp = 400, NbPorte = 2, IdParent = 2, Model = "A90", EstVedette = true, ImageURL = "/images/supra.jpg", Description = " Super clean  Supra  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 6, Nom = "AE86", Couleur = "White", Moteur = "4A-GE", Km = 157000, Hp = 190, NbPorte = 2, IdParent = 2, Model = "Coupe", EstVedette = false, ImageURL = "/images/ae86.jpg", Description = " Super clean  AE86  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 7, Nom = "MR2", Couleur = "Red", Moteur = "5S-FE", Km = 92000, Hp = 250, NbPorte = 2, IdParent = 2, Model = "mid-engine", EstVedette = false, ImageURL = "/images/mr2.jpg", Description = " Super clean  MR2  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 8, Nom = "Chaser", Couleur = "Black", Moteur = "2JZ-GTE", Km = 75000, Hp = 600, NbPorte = 4, IdParent = 2, Model = "JZX100", EstVedette = false, ImageURL = "/images/chaser.jpg", Description = " Super clean  JZX100  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 9, Nom = "NSX", Couleur = "Yellow", Moteur = "C30A", Km = 8000, Hp = 270, NbPorte = 2, IdParent = 3, Model = "Type s", EstVedette = true, ImageURL = "/images/nsx.jpg", Description = " Super clean  NSX  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 10, Nom = "Beat", Couleur = "Yellow", Moteur = "E07A", Km = 49000, Hp = 70, NbPorte = 2, IdParent = 3, Model = "Cabriolet", EstVedette = false, ImageURL = "/images/beat.jpg", Description = " Super clean  Honda Beat  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 11, Nom = "Integra", Couleur = "white", Moteur = "B18C", Km = 93000, Hp = 370, NbPorte = 2, IdParent = 3, Model = "Type R", EstVedette = false, ImageURL = "/images/integra.jpg", Description = " Super clean  Integra  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });
            Enfants.Add(new Enfant() { Id = 12, Nom = "CRX", Couleur = "Silver", Moteur = "CVCC", Km = 76000, Hp = 200, NbPorte = 2, IdParent = 3, Model = "Hatchback", EstVedette = false, ImageURL = "/images/crx.jpg", Description = " Super clean  CRX  just landed at Toprank. It is so difficult to catch in this model with this color. The car is in great condition,it has verified mileage and it is rust free. Let us at trade@toprank.jp if you are in the market for a vehicle like this.Shipping worldwide and JCI / Shaken are also available." });

            Parents.Add(new Parent() { Id = 1, Nom = "Nissan", ImageURL = "/images/logoNissan.png", Description = "Nissan est un constructeur automobile japonais né sous le nom de Datsun. Son siège social est à Yokohama depuis 2010.Nissan est le célèbre créateur de la fameuse Nissan Skyline R34 GTR."});
            Parents.Add(new Parent() { Id = 2, Nom = "Toyota", ImageURL = "/images/logoToyota.png", Description = "Toyota, officiellement Toyota Motor Corporation est un constructeur automobile originaire du Japon. Le siège du groupe est situé dans la ville de Toyota.Il est en 2017 le 1er constructeur automobile mondial pour les performances financières devant Volkswagen et Daimler."});
            Parents.Add(new Parent() { Id = 3, Nom = "Honda", ImageURL = "/images/logoHonda.png", Description = "Honda est un constructeur automobile japonais. C'est également un constructeur de motocyclettes, de quads, de scooters, d'avions d'affaires, de générateurs électriques, de moteurs de bateaux et d'équipements de jardinage et de bricolage."});

            foreach (var p in Parents)
            {
                p.Enfants = new List<Enfant>();
                p.Enfants.AddRange(Enfants.Where(e => e.IdParent == p.Id));
            }

            foreach (var e in Enfants)
            {
                e.Parent = Parents.Where(p => p.Id == e.IdParent).Single();
            }
        }
    }
}
