using ObjectClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarteAttaque : Cartes
{
    int dmg;
    int energie;
    Ennemics e;
    public CarteAttaque(Ennemics _e) 
    {
        e = _e;
        dmg = 5;
        energie = 1;
        nom = "Carte Attaque";
    }
    public override void Application() 
    {
        e.pdv = e.pdv - dmg;
        Console.WriteLine("Tu as infliger 5 points de dégats");
        Console.WriteLine("il reste" + e.pdv + "PV");
    } 
    


}
