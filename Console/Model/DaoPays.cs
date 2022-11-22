using System;
using System.Collections.Generic;
using System.Data;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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
        public List<Pays> SelectAll()
        {
            List<Pays> listPays = new List<Pays>();
            DataTable myTable = this.undbal.SelectAll("pays");

            foreach (DataRow r in myTable.Rows)
            {
                listPays.Add(new Pays((string)r["name"], (int)r["id"]));
            }

            return listPays;
        }
        public Pays SelectByName(string namePays)
        {
            DataTable result = new DataTable();
            result = this.undbal.SelectByField("pays", "name = '" + namePays.Replace("'", "''") + "'");
            Pays foundPays = new Pays((string)result.Rows[0]["name"], (int)result.Rows[0]["id"]);
            return foundPays;

        }

        public Pays SelectById(int idPays)
        {
            DataRow result = this.undbal.SelectById("Pays", idPays);
            return new Pays((string)result["name"], (int)result["id"]);

        }



    }
}
