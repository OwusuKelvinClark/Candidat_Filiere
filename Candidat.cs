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

        public Candidat(string nom, float moyenneGenerale, int limitOption = 3)
        {
            this.nom = nom;
            this.moyenneGenerale = moyenneGenerale;
            this.limit = limitOption;
        }

        public string Nom
        {
            set { nom = value; }
            get { return nom; }
        }

        public float MoyenneGenerale
        {
            get { return moyenneGenerale; }
        }

        public List<Option> Options
        {
            get { return options; }
        }
        
        public bool addOption(Option option)
        {
            if (options.Count >= limit) return false;

            options.Add(option);
            return true;
        }

        public Option getOption(int position)
        {
            if (position > limit) throw new Exception("Index out of bounds");

            return options[position];
        }
    }
}
