using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Administratif : Personnel
    {

        public Administratif(int code, string nom, string prenom, string bureau, double salaire, double prime)
            : base(code, nom, prenom, bureau,salaire,prime)
        {
            Salaire = salaire;
        }

        public override double Calculer_Salaire()
        {
            return Salaire;
        }
    }

}
