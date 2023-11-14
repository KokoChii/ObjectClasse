namespace ObjectClasse
{
    internal class Program
    {
        static void Main()
        {
          Joueur j = new Joueur();
            j.AfficherCartes();

            CarteAttaque c = new CarteAttaque();

            Console.WriteLine("Quelle cartes souhaitez vous jouer ?");
            string? choix = Console.ReadLine();

            j.JouerCarte( Int32.Parse(choix));

            //if (choix = Int32.Parse(c))
            {
                ///Ennemics.hp = Ennemics.hp - 5;
               // Console.WriteLine("vous avez infliger 5 pts de dégats");

            
            }
        
        
        
        
        
        
        
        
        
        
        
        
        
        }

    }
}