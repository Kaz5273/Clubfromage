using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubFromage
{
    public class Pays
    {
        private int id;
        private string name;

        public Pays(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }

        public override string ToString()
        {
            return this.Name;
        }

    }
}
