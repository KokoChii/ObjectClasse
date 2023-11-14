using ObjectClasse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarteAttaque : Cartes
{
    int degat;
    int energie;

    public CarteAttaque() 
    {
        degat = 5;
        energie = 1;
        nom = "Carte Attaque";
    }
    public override void Application() 
    {
        Console.WriteLine("Tu as infliger 5 points de dégats");
    
    } 



}
