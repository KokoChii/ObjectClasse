using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasse
{
    internal class CartesDefense : Cartes
    {
        int armure;
        int enrgie;

        public CartesDefense()
        {
            armure = 5;
            enrgie = 1;
            nom = "Carte Defense";

        }
        public override void Application()
        {
            Console.WriteLine("Tu as reçu 5 points d'armure");


        }




    }
}
