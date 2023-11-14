using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasse
{
    internal class Ennemics 
    {
        public int pdv;
        public int Dmg;
        public Joueur j;
        public int armure;

        public Ennemics ()  
        {
            pdv = 25;
            Dmg = 5;
            armure = 0;
        }

        public void AttackJoueur()
        {
            j.pdv = j.pdv - Dmg;
            Console.WriteLine("L'ennemie vous a infliger 5 pts de dégats");
            Console.WriteLine("il vous reste "+j.pdv+" point de vie !");

        }
        public void AttackAmure()
        {
            j.armure = j.armure - Dmg;
            Console.WriteLine("L'ennemie vous a infliger 5 pts de dégats");
            Console.WriteLine("il vous reste " + j.pdv + " point de vie !");

        }















    }

    







}

