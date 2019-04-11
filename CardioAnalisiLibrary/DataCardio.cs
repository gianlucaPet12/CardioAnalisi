using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{
    public class DataCardio
    {
        public static string TipoBattio(int battiti, string tipo)
        {
            string rispo = "";
            if (battiti < 60)
            {
                rispo = "Bradicardia";
            }

            if (battiti >= 60 && battiti <= 100)
            {
                rispo = "Normale";
            }

            if (battiti > 100)
            {
                rispo = "Tachicardia";
            }

            return rispo;
        }
        public static double CalcoloCalorie(double anni, double peso, double frequenza, double tempo, string sesso)
        {
            double calorie = 0;
            if (sesso == "uomo")
            {
                calorie= ((anni * 0.2017) + (peso * 0.199) +(frequenza * 0.6309) - 55.0969) * tempo / 4.184;
            }

            if (sesso == "donna")
            {
                calorie = ((anni * 0.074) + (peso * 0.126) + (frequenza * 0.4472) - 20.4022) * tempo / 4.184;
            }

            return calorie;
        }
    }
}
