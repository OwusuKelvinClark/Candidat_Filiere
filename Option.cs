using System;
using System.Collections.Generic;

namespace Candidat_Filiere
{
    class Option
    {
        private string nom;
        private List<Candidat> candidats = new List<Candidat>();
        private int nombreDePlace;

        /// <summary>Initializes a new instance of the <see cref="Option" /> class.</summary>
        /// <param name="nom">nom.</param>
        /// <param name="nombreDePlace">nombre de place.</param>
        public Option(string nom, int nombreDePlace = 20)
        {
            this.nom = nom;
            this.nombreDePlace = nombreDePlace;
        }

        /// <summary>Gets the nom.</summary>
        /// <value>nom.</value>
        public string Nom
        {
            get { return nom; }
        }

        /// <summary>Adds a candidate to the option</summary>
        /// <param name="candidat">The candidat.</param>
        /// <returns>bool</returns>
        public bool ajouterCandidat(Candidat candidat)
        {
            if (candidats.Count >= nombreDePlace) return false;

            candidats.Add(candidat);
            return true;
        }

        /// <summary>Prints the candidates inserted into the option</summary>
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
