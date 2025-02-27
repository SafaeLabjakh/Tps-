using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    class Dictionnaire : Document
    {
        public string Langue { get; set; }
        public int NombreDeDefinitions { get; set; }

        public Dictionnaire(string titre, string langue, int nombreDeDefinitions) : base(titre)
        {
            Langue = langue;
            NombreDeDefinitions = nombreDeDefinitions;
        }

        public override string Description()
        {
            return $"Dictionnaire - Numéro: {Numero}, Titre: {Titre}, Langue: {Langue}, Définitions: {NombreDeDefinitions}";
        }
    }
}
