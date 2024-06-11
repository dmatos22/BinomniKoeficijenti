using BinomniKoeficijenti;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProjekt
{
    [TestClass]
    public class FaktorijelTest
    {
        [TestMethod]
        public void IzracunajFaktorijelOd0_VracaVrijednost1()
        {
            BinomniK bk = new BinomniK();
            int f = bk.Faktorijel(0);
            Assert.AreEqual(1, f);
        }

        [TestMethod]
        public void IzracunajFaktorijelOd5_VracaVrijednost120()
        {
            BinomniK bk = new BinomniK();
            int f = bk.Faktorijel(5);
            Assert.AreEqual(120, f);
        }

        [TestMethod]
        public void IzracunajFaktorijelOdMinus5_VracaPorukuNMoraBitiVeciIliJednakNuli()
        {
            BinomniK bk = new BinomniK();
            int f = bk.Faktorijel(-5);
            Assert.AreEqual(0, f, "n mora biti veći ili jednak nuli.");
        }
    }
}
