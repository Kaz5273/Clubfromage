using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage.Model
{
    public class DaoPays
    {
        private Dbal undbal;

        public DaoPays(Dbal undbal)
        {
            this.undbal = undbal;
        }
            
        public void Insert(Pays unPays)
        {
            string  values ="(" + unPays.Id + ", '" + unPays.Name.Replace("'","''") + "') ";
            undbal.Insert("Pays", values);
        }
        
        public void Update(Pays unPays)
        {
            string values = " name= '" + unPays.Name.Replace("'", "''") + "' ";
            string condition = "id= " + unPays.Id + " ";
            undbal.Update("Pays", values, condition);
        }   
        public void Delete(Pays unPays)
        {
            string values = "id= " + unPays.Id;
            undbal.Delete("Pays", values);
        }
    }
}
