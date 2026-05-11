using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_compétition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Création d'un compétiteur de type Combattant
            Competiteur.Combattant competiteur1 = new Competiteur.Combattant("Gérard", "Bouchard", 55, 105, "française");

            // Création d'un compétiteur de type Choregraphe
            Competiteur.Choregraphe competiteur2 = new Competiteur.Choregraphe("Sandrine", "Cendrier", 35, "hip-hop");

            List<Competiteur> listeCompetiteurs = new List<Competiteur> { competiteur1, competiteur2 };

            foreach (Competiteur competiteur in listeCompetiteurs)
            {
                Console.WriteLine(competiteur.InfoCompetiteur());
            }

            // Afficher la console pour éviter qu'elle ne se ferme immédiatement
            Console.ReadKey();
        }
    }
}
