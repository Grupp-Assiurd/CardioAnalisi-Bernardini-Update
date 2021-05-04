using Microsoft.VisualStudio.TestTools.UnitTesting;
using CardioLibrary;

namespace DataCardio_test
{
    [TestClass]
    public class DataCardioUnitTest
    {
        [DataTestMethod]
        [DataRow(10, "Soffri di bradicardia")]
        [DataRow(35, "Soffri di bradicardia")]
        [DataRow(40, "Soffri di bradicardia")]
        [DataRow(60, "Hai un battito normale")]
        [DataRow(79, "Hai un battito normale")]
        [DataRow(100, "Hai un battito normale")]
        [DataRow(110, "soffri di tachicardia")]
        [DataRow(150, "soffri di tachicardia")]

        public void BattitiRiposo(int batitti, string risultatoAspettato)
        {
            string risposta = DataCardio.BattitiRiposo(batitti);
            Assert.AreEqual(risposta, risultatoAspettato);
        }

        [DataTestMethod]
        [DataRow(60.5, 12, "corsa", 653.4)]
        [DataRow(55.7, 7, "CORSA", 350.91)]
        [DataRow(82.4, 17, "camminata", 700.4)]
        [DataRow(90.5, 4, "CAMMINATA", 181)]

        public void CorsaCamminata(double peso, double km , string corsaCamminata, double risulatoAspettato)
        {
            double risposta = DataCardio.CorsaCamminata(peso, km, corsaCamminata);
            Assert.AreEqual(risposta, risulatoAspettato);
        }
    }
}
