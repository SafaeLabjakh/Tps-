using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création des instances
            Directeur directeur = Directeur.GetInstance(1, "Safae", "LABJAKH", "Bureau 1", 6000, 1000);
            var enseignant = new Enseignant(1, "KEROUAN SALAH", "Soumaia", "B101", 5000, 500, "PA", 120, 50);
            var etudiant1 = new Etudiant(101, "LABJAKH", "Safae", "L3", 14.5);
            var etudiant2 = new Etudiant(102, "ALAMI", "Sophia", "L2", 12.0);

            // Création de l'instance RessourcesHumaines 
            IRessourceHumaine rh = new RessourceHumaine();

            // Ajouter des personnes
            rh.AjouterPersonne(directeur);
            rh.AjouterPersonne(enseignant);

            // Afficher le personnel
            rh.AfficherPersonnel();

            // Supprimer un étudiant
            rh.SupprimerPersonne(102);

            // Afficher de nouveau le personnel après suppression
            rh.AfficherPersonnel();
        }
    }
}
