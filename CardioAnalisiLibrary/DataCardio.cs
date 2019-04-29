using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardioAnalisiLibrary
{ 
    public class DataCardio
    {
        //punto 1
        public static int Frequenza_Max(int eta)
        {
            int frequenzaMassima = 0;
            int frequenzaConsigliata = 220 - eta;

            frequenzaMassima = Convert.ToInt32(frequenzaConsigliata * 0.9);

            return frequenzaMassima;
        }

        public static int Frequenza_Min(int eta)
        {
            int frequenzaMinima = 0;
            int frequenzaConsigliata = 220 - eta;

            frequenzaMinima = Convert.ToInt32(frequenzaConsigliata * 0.7);

            return frequenzaMinima;
        }
        //punto 2
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
        //punto 3
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

        //punto 4
        public static double Calorie_Corsa_Camminata(string tipo, int km, int peso)
        {
            double KCal = 0;

            if (tipo == "Corsa")
            {
                KCal = 0.9 * km * peso;
            }
            else if (tipo == "Camminata")
            {
                KCal = 0.50 * km * peso;
            }

            return KCal;
        }

    }
}
