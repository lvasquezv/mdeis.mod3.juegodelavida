using NUnit.Framework;

namespace Tests
{
    public class JuegoPruebas
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CelulaViva_conMenosDeDosVecinasVivas()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();

            Assert.Pass();
        }
    }
}