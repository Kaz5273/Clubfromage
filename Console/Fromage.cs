using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    public class Fromage
    {
        private int id;
        private string nom;
        private string recette;
        private string histoire;
        private int dur_affinage;
        private DateTime dateCreation;
        private char image;

        public Fromage(int id, string nom, string recette, string histoire, int dur_affinage, DateTime dateCreation, char image)
        {
            this.id = id;
            this.nom = nom;
            this.recette = recette;
            this.histoire = histoire;
            this.dur_affinage = dur_affinage;
            this.dateCreation = dateCreation;
            this.image = image;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Recette { get => recette; set => recette = value; }
        public string Histoire { get => histoire; set => histoire = value; }
        public int Dur_affinage { get => dur_affinage; set => dur_affinage = value; }
        public DateTime DateCreation { get => dateCreation; set => dateCreation = value; }
        public char Image { get => image; set => image = value; }
    }
}
