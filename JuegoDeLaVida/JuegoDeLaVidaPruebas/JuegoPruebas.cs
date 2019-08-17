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
            bool[,] tablero = new bool[10, 10];
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = true; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false; tablero[0, 0] = false;
            // Hay una celula viva en la posicion 1,1.
            bool[,] tableroActual = juego.generar(tablero, 1, 1);
            bool[,] tableroEsperado = new bool[10, 10];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false; tableroEsperado[0, 0] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
    }
}
