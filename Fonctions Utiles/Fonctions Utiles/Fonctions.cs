using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fonctions_Utiles
{
    public static class Fonctions
    {
        /// <summary>
        /// fonctions permettant à l'utilisateur de continuer ou arréter le programme.
        /// </summary>
        /// <param name="continuer"></param>
        public static void Poursuivre(out bool continuer)
        {
            string reponse = "";
            continuer = true;
            while (reponse != "n" && reponse != "o")
            {
                Console.WriteLine("Voulez-vous recommencer?\no:Oui\tn:non");
                reponse = Console.ReadLine().ToLower();
                if (reponse == "n")
                {
                    continuer = false;
                }
                else if (reponse != "n" && reponse != "o")
                {
                    Console.WriteLine("Je n'ai pas saisie votre réponse!");
                }
            }
        }
    }
}
