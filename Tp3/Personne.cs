using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    abstract class Personne
    {
        public int Code { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        public Personne(int code, string nom, string prenom)
        {
            Code = code;
            Nom = nom;
            Prenom = prenom;
        }
    }
}
