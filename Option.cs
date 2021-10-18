using System;
using System.Collections.Generic;

namespace Candidat_Filiere
{
    class Option
    {
        private string nom;
        private List<Candidat> candidats = new List<Candidat>();
        private int nombreDePlace;

        public Option(string nom, int nombreDePlace = 20)
        {
            this.nom = nom;
            this.nombreDePlace = nombreDePlace;
        }

        public string Nom
        {
            get { return nom; }
        }

        public bool ajouterCandidat(Candidat candidat)
        {
            if (candidats.Count >= nombreDePlace) return false;

            candidats.Add(candidat);
            return true;
        }

        public void printCandidats()
        {
            Console.WriteLine("Nom\tMoyen");
            Console.WriteLine("---------------------");
            candidats.ForEach(candidat =>
            {
                Console.WriteLine($"{candidat.Nom}\t{candidat.MoyenneGenerale}");
            });
        }
    }
}
