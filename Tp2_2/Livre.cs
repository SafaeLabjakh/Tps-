using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    class Livre : Document
    {
        public string Auteur { get; set; }
        public int NombreDePages { get; set; }

        public Livre(string titre, string auteur, int nombreDePages) : base(titre)
        {
            Auteur = auteur;
            NombreDePages = nombreDePages;
        }

        public override string Description()
        {
            return $"Livre - Numéro: {Numero}, Titre: {Titre}, Auteur: {Auteur}, Pages: {NombreDePages}";
        }
    }

}
