using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Enseignant : Personnel
    {
        public string Grade { get; set; }
        public int VolumeHoraire { get; set; }
        public int HS { get; set; }

        private Dictionary<string, List<Etudiant>> Grp { get; set; }

        public Enseignant(int code, string nom, string prenom, string bureau,double salaire,double prime, string grade, int volumeHoraire, int hS)
            : base(code, nom, prenom, bureau,salaire,prime)
        {
            Grade = grade;
            VolumeHoraire = volumeHoraire;
            Grp = new Dictionary<string, List<Etudiant>>();
            HS = hS;
        }

        public void Ajouter_groupe(Groupe gp)
        {
            if (!Grp.ContainsKey(gp.NomGroupe)) // si le groupe n existe pas déjà
            {
                Grp[gp.NomGroupe] = gp.Etudiants; // Ajouter le groupe au dictionnaire
            }
            else
            {
                Console.WriteLine($" Le groupe '{gp.NomGroupe}' existe déjà pour cet enseignant !");
            }
        }

        public override double Calculer_Salaire()
        {
            double prixHeure = 0;

            switch (Grade)
            {
                case "PA":
                    prixHeure = 300;
                    break;
                case "PH":
                    prixHeure = 350;
                    break;
                case "PES":
                    prixHeure = 400;
                    break;
                default:
                    prixHeure = 0;
                    break;
            }

            return Salaire + (prixHeure * VolumeHoraire);
        }


        public void Afficher_ens()
        {
            Console.WriteLine($"Enseignant: {Nom} {Prenom} - Grade: {Grade}");
            foreach (var groupe in Grp) // Utilisation de 'Grp' pour afficher les groupes d'étudiants
            {
                Console.WriteLine($"Groupe {groupe.Key}:");
                foreach (var etudiant in groupe.Value) // Affiche les étudiants du groupe
                {
                    Console.WriteLine($" - {etudiant.Nom} {etudiant.Prenom} - Niveau: {etudiant.Niveau} - Moyenne: {etudiant.Moyenne}");
                }
            }
        }

        // Indexeur pour accéder aux groupes d'étudiants par leur nom
        public List<Etudiant> this[string nomGroupe]
        {
            get => Grp.ContainsKey(nomGroupe) ? Grp[nomGroupe] : null;
        }
    }
}
