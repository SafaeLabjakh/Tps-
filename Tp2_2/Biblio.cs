using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_2
{
    class Biblio
    {
        private List<Document> documents = new List<Document>();

        public void AjouterDocument(Document doc)
        {
            documents.Add(doc);
        }

        public int NombreDeLivres()
        {
            return documents.FindAll(d => d is Livre).Count;
        }

        public void AfficherDictionnaires()
        {
            foreach (var doc in documents)
            {
                if (doc is Dictionnaire)
                {
                    Console.WriteLine(doc.Description());
                }
            }
        }

        public void TousLesAuteurs()
        {
            foreach (var doc in documents)
            {
                if (doc is Livre livre)
                {
                    Console.WriteLine($"Numéro: {doc.Numero}, Auteur: {livre.Auteur}");
                }
                else
                {
                    Console.WriteLine($"Numéro: {doc.Numero}, Auteur: Non applicable");
                }
            }
        }

        public void ToutesLesDescriptions()
        {
            foreach (var doc in documents)
            {
                Console.WriteLine(doc.Description());
            }
        }
    }

}
