using System;
using System.Collections.Generic;

namespace Tp3
{
     class RessourceHumaine : IRessourceHumaine
    {
        private List<Personnel> personnels = new List<Personnel>();

        public void AjouterPersonne(Personnel personne)
        {
            personnels.Add(personne);
            Console.WriteLine($"Personne ajoutée: {personne.Nom} {personne.Prenom}");
        }

        public void SupprimerPersonne(int code)
        {
            Personnel personnelASupprimer = personnels.Find(p => p.Code == code);
            if (personnelASupprimer != null)
            {
                personnels.Remove(personnelASupprimer);
                Console.WriteLine($"Personne supprimée: {personnelASupprimer.Nom} {personnelASupprimer.Prenom}");
            }
            else
            {
                Console.WriteLine("Personne non trouvée.");
            }
        }

        public void AfficherPersonnel()
        {
            Console.WriteLine("Liste des personnels:");
            foreach (var personnel in personnels)
            {
                Console.WriteLine($"{personnel.Code} - {personnel.Nom} {personnel.Prenom}");
            }
        }
    }
}
