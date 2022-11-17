using System;
using System.Speech; 
using System.Speech.Recognition;
using System.Speech.Synthesis;
using ClubFromage;
using ClubFromage.Model;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dbal dbal = new Dbal();
            Pays unPays = new Pays("Hollandeee", 56);
            DaoPays unDaoPays = new DaoPays(dbal);
            unDaoPays.Delete(unPays);



            //dbal.Insert("Pays","(25,'Suisse')");
            //dbal.Update("Pays", " name='Suisseee'", "id=25;");
            //dbal.Delete("Pays", "id=25");

        }

            
    }
}

