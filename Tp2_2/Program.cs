using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    class Program
    {
        static void Main()
        {
            Biblio biblio = new Biblio();

            biblio.AjouterDocument(new Livre("C# pour les nuls", "John Doe", 300));
            biblio.AjouterDocument(new Dictionnaire("Dictionnaire Français", "Français", 50000));
            biblio.AjouterDocument(new Livre("Apprendre C#", "Jane Doe", 250));

            Console.WriteLine("Nombre de livres: " + biblio.NombreDeLivres());
            Console.WriteLine("\nDictionnaires: ");
            biblio.AfficherDictionnaires();
            Console.WriteLine("\nAuteurs des livres: ");
            biblio.TousLesAuteurs();
            Console.WriteLine("\nDescriptions des documents: ");
            biblio.ToutesLesDescriptions();
        }
    }
}
