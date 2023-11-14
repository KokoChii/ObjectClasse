using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ObjectClasse
{
    internal class Joueur :HP
    {
        string joueur;
        public string nom;
        public int pdv;
        int energie;
        public Cartes[] main;

        //constructeur
        public Joueur()
        {
            Console.WriteLine("Bienvenue ! Entre ton pseudo :");
            nom = Console.ReadLine();
            Console.WriteLine($"A toi de jouer {nom}");
            pdv = 40;
            energie = 3;
            main= new Cartes[5];

            main[0] = new CarteAttaque();
            main[1] = new CartesDefense();
            main[2] = new CartesDefense();
            main[3] = new CarteAttaque();
            main[4] = new CartesDefense();

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
        

    

   
