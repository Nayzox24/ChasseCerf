namespace Chasse_cerf;

class Program
{
    static void Main(string[] args)
    {
        /*
        Arthur dispose de 5 flèches pour chasser un cerf.

        Consignes :
        - Demander au joueur si chaque tir touche ou rate la cible.
        - Décrémenter le nombre de flèches après chaque tir.
        - Compter le nombre de tirs réussis.
        - Arrêter la chasse lorsque les 5 flèches sont utilisées.
        - Arrêter immédiatement la chasse si le cerf est touché 3 fois.
        - Si la saisie est invalide, demander une nouvelle réponse
          sans consommer de flèche.
        - Afficher le bilan final de la chasse.
        */
        if (args.Length > 0 && args[0] == "test")
        {
            // Code de test
            Console.WriteLine("Mode test activé.");
        }
        else
        {
            // Code principal du jeu
            int flèches = 5;
            int tirsRéussis = 0;
            while (flèches > 0 && tirsRéussis < 3)
            {
                Console.WriteLine($"Il vous reste {flèches} flèches. Tirez (touche/rate) :");
                string saisie = Console.ReadLine()?.ToLower();
                if (saisie == "touche")
                {
                    tirsRéussis++;
                    flèches--;
                    Console.WriteLine("Vous avez touché le cerf !");
                }
                else if (saisie == "rate")
                {
                    flèches--;
                    Console.WriteLine("Vous avez raté le cerf.");
                }
                else
                {
                    Console.WriteLine("Saisie invalide. Veuillez répondre par 'touche' ou 'rate'.");
                    continue; // Ne pas décrémenter les flèches pour une saisie invalide
                }
            }
            // Bilan final de la chasse
            if (tirsRéussis == 3)
            {
                Console.WriteLine("Bravo ! Vous avez gagné !");
            }
            else
            {
                Console.WriteLine("Dommage ! Vous avez perdu !");
            }
            Console.WriteLine($"Chasse terminée. Tirs réussis : {tirsRéussis}, Flèches restantes : {flèches}");

        }

    }
}