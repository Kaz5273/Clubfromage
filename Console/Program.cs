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
            //Pays unPays = new Pays("Hollandeee", 16);
            //DaoPays unDaoPays = new DaoPays(dbal);
            //unDaoPays.Insert(unPays);

            Fromage unFromage = new Fromage(32, "Fromage Suisse", new Pays("Hollandeee", 16) , "Au temps des chevaliers, blablablablablalb", "Du lait de Haute-Savoie, de la patience et c'est t.", 10, new DateTime(2022,08,07), "Fromage-Suisse.png");
            DaoFromage unDaoFromage = new DaoFromage(dbal);
            unDaoFromage.Insert(unFromage);



            //dbal.Insert("Pays","(25,'Suisse')");
            //dbal.Update("Pays", " name='Suisseee'", "id=25;");
            //dbal.Delete("Pays", "id=25");

        }

            
    }
}

