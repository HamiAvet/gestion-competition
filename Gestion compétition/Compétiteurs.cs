using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_compétition
{
    // internal class Compétiteur par défaut
    // On rend la classe Compétiteur abstraite pour éviter qu'elle ne soit instanciée directement, elle doit être héritée par les classes Combattant et Choregraphe
    public abstract class Competiteur
    {
        // Les attributs - Propriétés
        private string nom;
        private string prenom;
        private int age;
        private string nationalite;

        // Les constructeurs de la classe Compétiteur
        // Sans pièce d'identité

        // Constructeur protégé pour éviter qu'il ne soit utilisé directement, il doit être appelé par les classes filles
        protected Competiteur(string prenom, string nom, int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
        }

        // Avec pièce d'identité

        // Constructeur protégé pour éviter qu'il ne soit utilisé directement, il doit être appelé par les classes filles
        protected Competiteur(string prenom, string nom, int age, string nationalite)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.nationalite = nationalite;
        }

        // Méthode pour afficher les informations du compétiteur générique
        protected string RecupInfo()
        {
            // Affichage des informations du compétiteur générique en fonction de la présence ou non de la nationalité
            if (nationalite != null)
            {
                return ("Le compétiteur " + prenom + " " + nom + " agé(e) de " + age + " ans, de nationalité " + nationalite + ".");
            }
            else
            {
                return ("Le compétiteur " + prenom + " " + nom + " agé(e) de " + age + " ans.");
            }
        }
        // Méthode abstraite pour afficher les informations spécifiques du compétiteur, elle doit être implémentée par les classes filles
        public abstract string InfoCompetiteur();

        // Les classes filles de la classe Compétiteur
        public class Combattant : Competiteur
        {
            // Attributs spécifiques à la classe Combattant
            private int poids;

            // Constructeur de la classe Combattant
            public Combattant(string prenom, string nom, int age, int poids, string nationalite = null) : base(prenom, nom, age, nationalite)
            {
                this.poids = poids;
            }

            // Méthode pour afficher les informations du combattant
            public override string InfoCompetiteur()
            {
                return (base.RecupInfo() + " Pesant " + poids + " kg.");
            }
        }

        public class Choregraphe : Competiteur
        {
            // Attributs spécifiques à la classe Choregraphe
            private string styleDanse;

            // Constructeur de la classe Choregraphe
            public Choregraphe(string prenom, string nom, int age, string styleDanse, string nationalite = null) : base(prenom, nom, age, nationalite)
            {
                this.styleDanse = styleDanse;
            }

            // Méthode pour afficher les informations du chorégraphe
            public override string InfoCompetiteur()
            {
                return (base.RecupInfo() + " Spécialisé(e) dans le style de danse " + styleDanse + ".");
            }
        }
    }
}
