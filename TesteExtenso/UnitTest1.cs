using ChequePorExtenso;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TesteExtenso
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CincoCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(0.05);
            Assert.AreEqual("Cinco centavos", numero.Extenso());
        }

        [TestMethod]
        public void TrezeCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(0.13);
            Assert.AreEqual("Treze centavos", numero.Extenso());
        }
        [TestMethod]
        public void TrintaETresCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(0.33);
            Assert.AreEqual("Trinta e três centavos", numero.Extenso());
        }
        [TestMethod]
        public void DoisReaisEVinteECincoCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(2.25);
            Assert.AreEqual("Dois reais e vinte e cinco centavos", numero.Extenso());
        }
        [TestMethod]
        public void SeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(7.00);
            Assert.AreEqual("Sete reais", numero.Extenso());
        }
        [TestMethod]
        public void TrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(37.00);
            Assert.AreEqual("Trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void SeiscentosETrintaESeteReaisEQuinzeCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(637.15);
            Assert.AreEqual("Seiscentos e trinta e sete reais e quinze centavos", numero.Extenso());
        }
        [TestMethod]
        public void QuinzeMilQuatrocentosEQuinzeReaisEDezesseisCentavosPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(15415.16);
            Assert.AreEqual("Quinze mil quatrocentos e quinze reais e dezesseis centavos", numero.Extenso());
        }
        [TestMethod]
        public void SessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(61637.00);
            Assert.AreEqual("Sessenta e um mil seiscentos e trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void NovecentosESessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(961637.00);
            Assert.AreEqual("Novecentos e sessenta e um mil seiscentos e trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void UmMilhaoOitocentosECinquentaEDoisMilESetecentosReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(1852700.00);
            Assert.AreEqual("Um milhão oitocentos e cinquenta e dois mil e setecentos reais", numero.Extenso());
        }
        [TestMethod]
        public void CincoMilhoesNovecentosESessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(5961637.00);
            Assert.AreEqual("Cinco milhões novecentos e sessenta e " +
                "um mil seiscentos e trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void VinteECincoMilhoesNovecentosESessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(25961637.00);
            Assert.AreEqual("Vinte e cinco milhões novecentos e sessenta e" +
                " um mil seiscentos e trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void QuatrocentosEVinteECincoMilhoesNovecentosESessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(425961637.00);
            Assert.AreEqual("Quatrocentos e vinte e cinco milhões novecentos e " +
                "sessenta e um mil seiscentos e trinta e sete reais", numero.Extenso());
        }
        [TestMethod]
        public void OitoBilhoesQuatrocentosEVinteECincoMilhoesNovecentosESessentaEUmMilSeiscentosETrintaESeteReaisPorExtenso()
        {
            NumeroExtenso numero = new NumeroExtenso(8425961637.00);
            Assert.AreEqual("Oito bilhões quatrocentos e vinte e cinco milhões novecentos e sessenta " +
                "e um mil seiscentos e trinta e sete reais", numero.Extenso());
        }





    }
}
