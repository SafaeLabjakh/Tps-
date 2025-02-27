using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Etudiant : Personne
    {
        public string Niveau { get; set; }
        public double Moyenne { get; set; }

        public Etudiant(int code, string nom, string prenom, string niveau, double moyenne)
            : base(code, nom, prenom)
        {
            Niveau = niveau;
            Moyenne = moyenne;
        }

        public override string ToString()
        {
            return base.ToString() + $" - Niveau: {Niveau}, Moyenne: {Moyenne}";
        }
    }

}
