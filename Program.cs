namespace ObjectClasse
{
    internal class Program
    {
        static void Main()
        {
          Ennemics E = new Ennemics();
          Joueur j = new Joueur(E);
          E.j = j;
         

            CarteAttaque c = new CarteAttaque(E);

            while (j.pdv>0)
            {
            Console.WriteLine("Quelle cartes souhaitez vous jouer ?");
            j.AfficherCartes();
            string? choix = Console.ReadLine();

                j.JouerCarte( Int32.Parse(choix));

                if (j.armure>0) 
                {
                    E.AttackAmure();
                }
                else
                {
                    E.AttackJoueur();
                }

                if (E.pdv == 0)
                {
                    Console.WriteLine("FELICITATION TU AS GAGNER LE COMBAT !!!");
                }
                if (j.pdv == 0)
                {
                    Console.WriteLine("Dommage tu as perdu ! Essaie encore !");
                }
               
            }





            

            //if (choix = Int32.Parse(c))
            {
                ///Ennemics.hp = Ennemics.hp - 5;
               // Console.WriteLine("vous avez infliger 5 pts de dégats");

            
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

    }
}