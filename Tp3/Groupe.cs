using System;
using System.Collections.Generic;

namespace Tp3
{
    class Groupe
    {
        // Propriétés
        public string NomGroupe { get; private set; }
        public List<Etudiant> Etudiants { get; private set; }

        // Constructeur
        public Groupe(string nomGroupe)
        {
            NomGroupe = nomGroupe;
            Etudiants = new List<Etudiant>();
        }

        // Méthode pour ajouter un étudiant
        public void Ajouter_Etudiant(Etudiant e)
        {
            if (e != null)
            {
                Etudiants.Add(e);
                Console.WriteLine($" Étudiant {e.Nom} {e.Prenom} ajouté au groupe {NomGroupe}.");
            }
            else
            {
                Console.WriteLine(" Erreur : Étudiant invalide !");
            }
        }

        // Méthode pour afficher les étudiants du groupe
        public void Afficher_Groupe()
        {
            Console.WriteLine($" Groupe: {NomGroupe} - Nombre d'étudiants: {Etudiants.Count}");
            foreach (var e in Etudiants)
            {
                Console.WriteLine($"   {e.Code} - {e.Nom} {e.Prenom} - Niveau: {e.Niveau} - Moyenne: {e.Moyenne}");
            }
        }
    }
}
