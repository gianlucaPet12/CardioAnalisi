using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{  
    [TestClass]
    public class UnitTest1
    {
        //Punto 1
        [DataTestMethod]
        [DataRow(16, 184, 143)]
        [DataRow(50, 153, 119)]
        [DataRow(90, 117, 91)]
        public void Test_Frequenza_Massima_Cons(int eta, int valore_max_atteso, int valore_min_atteso)
        {
            int valore_max_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza_Max(eta);
            int valore_min_ottenuto = CardioAnalisiLibrary.DataCardio.Frequenza_Min(eta);

            Assert.AreEqual(valore_max_ottenuto, valore_max_atteso);
            Assert.AreEqual(valore_min_ottenuto, valore_min_atteso);
        }
        //punto 2
        [DataTestMethod]
        [DataRow (55, "Bradicardia")] 
        [DataRow (60, "Normale")]
        [DataRow (101, "Tachicardia")]
        public void TestMethod2(int battiti, string tipo)
        {
         string var;

         var = CardioAnalisiLibrary.DataCardio.TipoBattio(battiti, tipo);
            Assert.AreEqual(var, tipo);
        }
        //punto3
        [DataTestMethod]
        [DataRow(20, 70, 80, 60, "uomo", 191)]
        [DataRow(16, 50, 70, 40, "donna", 176)]    
        public void TestMethod3(double anni, double peso, double frequenza, double tempo, string sesso, int ris_atteso)
        {
            int var;

            var =Convert.ToInt32( CardioAnalisiLibrary.DataCardio.CalcoloCalorie(anni, peso, frequenza, tempo, sesso));

            Assert.AreEqual(ris_atteso, var);
        }

        //punto 4
        [DataTestMethod]
        [DataRow("Corsa", 10, 75, 675)]
        [DataRow("Camminata", 5, 65, 162)]
        public void Test_corsa_camminata(string tipo, int km, int peso, int valore_atteso)
        {
            int valore_ottenuto = Convert.ToInt32(CardioAnalisiLibrary.DataCardio.Calorie_Corsa_Camminata(tipo, km, peso));

            Assert.AreEqual(valore_atteso, valore_ottenuto); 
        }
    }
}
