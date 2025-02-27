using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    abstract class Personnel : Personne
    {
        public string Bureau { get; set; }
        public double Salaire { get; set; }
        public double Prime { get; set; }
        public Personnel(int code, string nom, string prenom, string bureau, double salaire, double prime)
            : base(code, nom, prenom)
        {
            Bureau = bureau;
            Salaire = salaire;
            Prime = prime;
        }

        public abstract double Calculer_Salaire();
    }
}
