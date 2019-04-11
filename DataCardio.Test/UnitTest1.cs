using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DataCardio.Test
{
    [TestClass]
    public class UnitTest1
    {
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

        [DataTestMethod]
        [DataRow(20, 70, 80, 60, "uomo", 191)]
        [DataRow(16, 50, 70, 40, "donna", 176)]    
        public void TestMethod3(double anni, double peso, double frequenza, double tempo, string sesso, int ris_atteso)
        {
            int var;

            var =Convert.ToInt32( CardioAnalisiLibrary.DataCardio.CalcoloCalorie(anni, peso, frequenza, tempo, sesso));

            Assert.AreEqual(ris_atteso, var);
        }
    }
}
