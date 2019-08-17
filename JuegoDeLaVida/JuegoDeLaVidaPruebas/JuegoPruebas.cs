using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace JuegoDeLaVidaPruebas
{
    public class JuegoPruebas
    {
        [Test]
        public void CelulaViva_conMenosDeDosVecinasVivas()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            Assert.AreEqual("","");
        }
    }
}
