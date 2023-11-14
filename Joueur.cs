using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ObjectClasse
{
    internal class Joueur 
    {
        Ennemics e;
        string joueur;
        public string nom;
        public int pdv;
        int energie;
        public int armure;
        public Cartes[] main;
        

        //constructeur
        public Joueur(Ennemics _e)
        {
            e= _e;
            Console.WriteLine("Bienvenue ! Entre ton pseudo :");
            nom = Console.ReadLine();
            pdv = 40;
            armure = 0;
            energie = 3;
            main = new Cartes[5];
            Console.WriteLine($"A toi de jouer {nom}, tu as {pdv} PV");

            main[0] = new CarteAttaque(_e);
            main[1] = new CartesDefense(this);
            main[2] = new CartesDefense(this);
            main[3] = new CarteAttaque(_e);
            main[4] = new CartesDefense(this);
           
        }


        public void AfficherCartes()
        {
            Console.WriteLine("0 : "+ main[0].nom);
            Console.WriteLine("1 : " + main[1].nom);
            Console.WriteLine("2 : " + main[2].nom);
            Console.WriteLine("3 : " + main[3].nom);
            Console.WriteLine("4 : " + main[4].nom);
            
        }

        public void JouerCarte(int numero)
        {
            
        main[numero].Application();

        }
    } }     
        

    

   
