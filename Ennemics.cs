using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectClasse
{
    internal class Ennemics : HP
    {
        public int hp;
        public int Dmg;

        public Ennemics ()  
        {
            hp = 25;
            Dmg = 5;
        }

        public void Action() 
        {
            Console.WriteLine("L'ennemie vous a infliger 5 pts de dégats");
        }


















    }

    







}

