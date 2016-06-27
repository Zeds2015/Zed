using System;
using Ex01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ex01Teste
{
    [TestClass]
    public class Teste01
    {
        int[] menores = new int[3];
        int result;

        Exercicio_Total n = new Exercicio_Total();

        [TestMethod]
        public void Quando_o_1_for_o_menor()
        {
            menores[0] = 2;
            menores[1] = 6;
            menores[2] = 3;

            result = n.Menor(menores);

            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void Quando_o_2_for_o_menor()
        {
            menores[0] = 1;
            menores[1] = 0;
            menores[2] = 2;

            result = n.Menor(menores);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Quando_o_3_for_o_menor()
        {
            menores[0] = 1;
            menores[1] = 2;
            menores[2] = -9;

            result = n.Menor(menores);

            Assert.AreEqual(-9, result);
        }
    }
}
