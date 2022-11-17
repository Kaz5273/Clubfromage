using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage.Model
{
    public class DaoFromage
    {
        private Dbal unDbal;

        public DaoFromage(Dbal unDbal)
        {
            this.unDbal = unDbal;
        }
        
        public void Insert(Fromage unFromage)
        {
            string values = "(" + unFromage.Id + ", '" + unFromage.Nom + "',  '" + unFromage.Recette + "', " + unFromage.Histoire + "', " + unFromage.Dur_affinage + ", '" + unFromage.DateCreation + "', '" + unFromage.Image + "') ";
            unDbal.Insert("Fromage", values);
        }
        
        public void Update(Fromage unFromage)
        {

        } 
    }
}
