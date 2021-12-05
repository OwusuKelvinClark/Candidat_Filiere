using System;
using System.Collections.Generic;

namespace Candidat_Filiere
{
    class Program
    {
        static void Main(string[] args)
        {
            Option gI = new Option("Genie Informatique", 3);
            Option aBD = new Option("Administration de Base de Donnees", 3);
            Option aSR = new Option("Administration de Systeme Reseau", 3);

            Candidat bY = new Candidat("Bejamin Yol", 18);
            bY.addOption(aBD);
            bY.addOption(aSR);
            bY.addOption(gI);

            Candidat sC = new Candidat("Steven Cocs", moyenneGenerale: 17);
            sC.addOption(gI);
            sC.addOption(aBD);
            sC.addOption(aSR);

            Candidat mG = new Candidat("Martin Grunt", 12);
            mG.addOption(aSR);
            mG.addOption(gI);
            mG.addOption(aBD);

            Candidat mT = new Candidat(nom: "Matta Tate", 13);
            mT.addOption(gI);
            mT.addOption(aSR);
            mT.addOption(aBD);

            Candidat jB = new Candidat("Josh Brus", 15);
            jB.addOption(aSR);
            jB.addOption(aBD);
            jB.addOption(gI);

            Candidat jC = new Candidat("John Cash", 15);
            jC.addOption(aBD);
            jC.addOption(gI);
            jC.addOption(aSR);

            Candidat dM = new Candidat("Donald Mars", 13);
            dM.addOption(gI);
            dM.addOption(aSR);
            dM.addOption(aBD);

            Candidat lP = new Candidat("Laura Polski", 12);
            lP.addOption(gI);
            lP.addOption(aBD);
            lP.addOption(aSR);

            Candidat gF = new Candidat("Gertrude Stilinski", 17);
            gF.addOption(aBD);
            gF.addOption(aSR);
            gF.addOption(gI);

            List<Candidat> candidats = new List<Candidat>();
            candidats.Add(bY);
            candidats.Add(sC);
            candidats.Add(mG);
            candidats.Add(mT);
            candidats.Add(jB);
            candidats.Add(jC);
            candidats.Add(dM);
            candidats.Add(lP);
            candidats.Add(gF);

            candidats.Sort(
                (cand1, cand2) => cand2.MoyenneGenerale.CompareTo(cand1.MoyenneGenerale)
            );

            Console.WriteLine("Candidat\tMoyenne\tOptions");
            Console.WriteLine("==========================================");
            candidats.ForEach(candidat =>
            {
                Console.Write($"{candidat.Nom}\t");
                Console.Write($"{candidat.MoyenneGenerale}\t");
                candidat.Options.ForEach(option =>
                {
                    Console.Write($"| {option.Nom} ");
                });
                Console.Write("\n");
            });

            Console.Write("\n");

            processRequests(candidats);

            Console.WriteLine($"{gI.Nom}");
            Console.WriteLine("============================");
            gI.printCandidats();
            Console.Write("\n");
            Console.WriteLine($"{aBD.Nom}");
            Console.WriteLine("============================");
            aBD.printCandidats();
            Console.Write("\n");
            Console.WriteLine($"{aSR.Nom}");
            Console.WriteLine("============================");
            aSR.printCandidats();
        }

        /// <summary>Performs the selection of students into their Option</summary>
        /// <param name="candidats">candidats.</param>
        static void processRequests(List<Candidat> candidats)
        {
            candidats.ForEach(candidat =>
            {
                bool goToNext = false;
                int optionIndex = 0;

                while (!goToNext)
                {
                    try
                    {
                        var option = candidat.getOption(optionIndex);
                        var isSuccessfull = option.ajouterCandidat(candidat);
                        if (isSuccessfull)
                        {
                            goToNext = true;
                        }
                        else
                        {
                            optionIndex++;
                        }
                    }
                    catch (Exception)
                    {
                        goToNext = true;
                        break;

                    }
                }
            });
        }
    }
}
