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
            string values = "(" + unFromage.Id + ", '" + unFromage.Nom + "', " + unFromage.Origine_pays + ", '"+ unFromage.Recette + "', " + unFromage.Histoire + "', " + unFromage.Dur_affinage + ", '" + unFromage.DateCreation.ToString("yyyy-MM-dd") + "', '" + unFromage.Image + "') ";
            unDbal.Insert("Fromage", values);
        }
        
        public void Update(Fromage unFromage)
        {
            string values = " nom= '" + unFromage.Nom.Replace("'", "''") + "', " + "origine_pays= " + unFromage.Origine_pays + ", " + "durAffinage= " + unFromage.Dur_affinage + ", " + " histoire= '" + unFromage.Histoire + "', " + " recette= '" + unFromage.Recette + "', " + "creation= '" + unFromage.DateCreation.ToString("yyyy-MM-dd") + "', " + "image= '" + unFromage.Image + "'";
            string condition = "id= " + unFromage.Id;
            unDbal.Update("Fromage", values, condition);
        } 

        public void Delete(Fromage unFromage)
        {
            string values = "id= " + unFromage.Id;
            unDbal.Delete("Fromage", values);
        }
    }
}
