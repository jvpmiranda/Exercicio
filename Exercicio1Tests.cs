using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TesteExercicio1.Util.Tests
{
    [TestClass()]
    public class Exercicio1Tests
    {
        [TestMethod()]
        public void VerificaMenorDiferençaEntreNumerosTest()
        {
            Exercicio1 ex = new Exercicio1();
            List<int> lsNumeros1;
            List<int> lsNumeros2;

            lsNumeros1 = new List<int>() { 1, 3, 15, 11, 2 };
            lsNumeros2 = new List<int>() { 23, 127, 235, 19, 8 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumeros(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 3, 15, 12, 2 };
            lsNumeros2 = new List<int>() { 23, 127, 235, 19, 8 };
            Assert.IsFalse(ex.VerificaMenorDiferençaEntreNumeros(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 3, 15, 11, 2, 20 };
            lsNumeros2 = new List<int>() { 23, 127, 235, 19, 8 };
            Assert.IsFalse(ex.VerificaMenorDiferençaEntreNumeros(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 3, 15, 11, 2, 20 };
            lsNumeros2 = new List<int>() { 23, 127, 235, 19, 8 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumeros(lsNumeros1, lsNumeros2) == 1);

            lsNumeros1 = new List<int>() { 1, 3, 15, 11, 2, 20 };
            lsNumeros2 = new List<int>();
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumeros(lsNumeros1, lsNumeros2) == -1);
        }

        [TestMethod()]
        public void VerificaMenorDiferençaEntreNumerosListaOrdenadaTest()
        {
            Exercicio1 ex = new Exercicio1();
            List<int> lsNumeros1;
            List<int> lsNumeros2;

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 2, 3, 12, 15 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsFalse(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsFalse(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 3);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 1);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            lsNumeros2 = new List<int>() { };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == -1);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            lsNumeros2 = new List<int>() { 100 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 80);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, null) == -1);

            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(null, null) == -1);

            lsNumeros1 = new List<int>() { 1, 2, 3, 11, 15, 20 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 1);

            lsNumeros1 = new List<int>() { 1, 2, 3, 5 };
            lsNumeros2 = new List<int>() { 18, 19, 23, 127, 235 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 13);

            lsNumeros1 = new List<int>() { 10, 11, 15, 25 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127, 235 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 2);

            lsNumeros1 = new List<int>() { 200, 321 };
            lsNumeros2 = new List<int>() { 8, 19, 23, 127 };
            Assert.IsTrue(ex.VerificaMenorDiferençaEntreNumerosListaOrdenada(lsNumeros1, lsNumeros2) == 73);
        }
    }
}