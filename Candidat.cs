using System;
using System.Collections.Generic;

namespace Candidat_Filiere
{
    class Candidat
    {
        private string nom;
        private float moyenneGenerale;
        private List<Option> options = new List<Option>();
        private int limit;

        /// <summary>Initializes a new instance of the <see cref="Candidat" /> class.</summary>
        /// <param name="nom">The nom.</param>
        /// <param name="moyenneGenerale">The moyenne generale.</param>
        /// <param name="limitOption">The limit option.</param>
        public Candidat(string nom, float moyenneGenerale, int limitOption = 3)
        {
            this.nom = nom;
            this.moyenneGenerale = moyenneGenerale;
            this.limit = limitOption;
        }

        /// <summary>Gets or sets the nom.</summary>
        /// <value>The nom.</value>
        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }

        /// <summary>Gets the moyenne generale.</summary>
        /// <value>The moyenne generale.</value>
        public float MoyenneGenerale
        {
            get { return moyenneGenerale; }
        }

        /// <summary>Gets the options.</summary>
        /// <value>The options.</value>
        public List<Option> Options
        {
            get { return options; }
        }

        /// <summary>
        ///   <para>
        /// Adds an option to the list of options</para>
        /// </summary>
        /// <param name="option">The option.</param>
        /// <returns>
        ///   bool
        /// </returns>
        public bool addOption(Option option)
        {
            if (options.Count >= limit) return false;

            options.Add(option);
            return true;
        }

        /// <summary>Gets an option at the specified index</summary>
        /// <param name="position">The position.</param>
        /// <returns>Option</returns>
        /// <exception cref="System.Exception">Index out of bounds</exception>
        public Option getOption(int position)
        {
            if (position > limit) throw new Exception("Index out of bounds");

            return options[position];
        }
    }
}
