using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
     interface IRessourceHumaine
    {
        void AjouterPersonne(Personnel personne);
        void SupprimerPersonne(int code);
        void AfficherPersonnel();
    }
}
