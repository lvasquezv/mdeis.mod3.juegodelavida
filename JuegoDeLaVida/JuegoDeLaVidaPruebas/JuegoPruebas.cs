﻿using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace JuegoDeLaVidaPruebas
{
    public class JuegoPruebas
    {

        [Test]
        public void CelulaViva_conMenosDeDosVecinasVivas_Muere()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false; 
            tablero[1, 0] = false; tablero[1, 1] = true;  tablero[1, 2] = false; tablero[1, 3] = false; tablero[1, 4] = false; 
            tablero[2, 0] = false; tablero[2, 1] = false; tablero[2, 2] = false; tablero[2, 3] = false; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = false; tablero[3, 2] = false; tablero[3, 3] = false; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;
            // Hay una celula viva en la posicion 1,1.
            bool[,] tableroActual = juego.generar(tablero, 1, 1, true);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = false; tableroEsperado[1, 3] = false; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = false; tableroEsperado[2, 1] = false; tableroEsperado[2, 2] = false; tableroEsperado[2, 3] = false; tableroEsperado[2, 4] = false;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = false; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
        [Test]
        public void CelulaViva_conDosTresVecinasVivas_Vive()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = false; tablero[1, 2] = false; tablero[1, 3] = true; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = false; tablero[2, 2] = false; tablero[2, 3] = true; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = false; tablero[3, 2] = false; tablero[3, 3] = true; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;
            // Hay una celula viva en la posicion 2,3  que tiene dos vecinas vivas : 1,3  y  3,3
            bool[,] tableroActual = juego.generar(tablero, 2, 3, true);
            tableroActual = juego.generar(tableroActual, 1, 3, true);
            tableroActual = juego.generar(tableroActual, 3, 3, true);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = false; tableroEsperado[1, 3] = false; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = false; tableroEsperado[2, 1] = false; tableroEsperado[2, 2] = false; tableroEsperado[2, 3] = true; tableroEsperado[2, 4] = false;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = false; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
        [Test]
        public void CelulaViva_conMasDeTresVecinasVivas_Muere()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = false; tablero[1, 2] = false; tablero[1, 3] = true; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = false; tablero[2, 2] = true; tablero[2, 3] = true; tablero[2, 4] = true;
            tablero[3, 0] = false; tablero[3, 1] = false; tablero[3, 2] = false; tablero[3, 3] = true; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;
            // Hay una celula viva en la posicion 2,3  que tiene dos vecinas vivas : 1,3  y  3,3
            bool[,] tableroActual = juego.generar(tablero, 2, 3, true);
            tableroActual = juego.generar(tableroActual, 1, 3, true);
            tableroActual = juego.generar(tableroActual, 3, 3, true);
            tableroActual = juego.generar(tableroActual, 2, 4, true);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = false; tableroEsperado[1, 3] = true; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = false; tableroEsperado[2, 1] = false; tableroEsperado[2, 2] = true; tableroEsperado[2, 3] = false; tableroEsperado[2, 4] = true;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = true; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
        [Test]
        public void CelulaMuerta_conTresVecinasVivas_Vive()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = false; tablero[1, 2] = false; tablero[1, 3] = true; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = false; tablero[2, 2] = true; tablero[2, 3] = true; tablero[2, 4] = true;
            tablero[3, 0] = false; tablero[3, 1] = false; tablero[3, 2] = false; tablero[3, 3] = true; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;
            // Hay una celula viva en la posicion 2,3  que tiene dos vecinas vivas : 1,3  y  3,3
            bool[,] tableroActual = juego.generar(tablero, 1, 2, false);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = true; tableroEsperado[1, 3] = true; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = false; tableroEsperado[2, 1] = false; tableroEsperado[2, 2] = true; tableroEsperado[2, 3] = true; tableroEsperado[2, 4] = true;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = true; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }

        [Test]
        public void Tablero_Mix()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = true; tablero[1, 2] = false; tablero[1, 3] = false; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = true; tablero[2, 2] = false; tablero[2, 3] = false; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = true; tablero[3, 2] = false; tablero[3, 3] = false; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;

            bool[,] tableroActual = juego.generarTablero(tablero);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = false; tableroEsperado[1, 3] = false; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = true; tableroEsperado[2, 1] = true; tableroEsperado[2, 2] = true; tableroEsperado[2, 3] = false; tableroEsperado[2, 4] = false;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = false; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
        [Test]
        public void Tablero_Mix01()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = true; tablero[1, 2] = false; tablero[1, 3] = false; tablero[1, 4] = false;
            tablero[2, 0] = true; tablero[2, 1] = true; tablero[2, 2] = true; tablero[2, 3] = false; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = true; tablero[3, 2] = false; tablero[3, 3] = false; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;

            bool[,] tableroActual = juego.generarTablero(tablero);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = true; tableroEsperado[1, 1] = true; tableroEsperado[1, 2] = true; tableroEsperado[1, 3] = false; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = true; tableroEsperado[2, 1] = false; tableroEsperado[2, 2] = true; tableroEsperado[2, 3] = false; tableroEsperado[2, 4] = false;
            tableroEsperado[3, 0] = true; tableroEsperado[3, 1] = true; tableroEsperado[3, 2] = true; tableroEsperado[3, 3] = false; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
        [Test]
        public void Tablero_Mix02()
        {
            JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = true; tablero[1, 2] = false; tablero[1, 3] = true; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = true; tablero[2, 2] = false; tablero[2, 3] = true; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = true; tablero[3, 2] = false; tablero[3, 3] = true; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;

            bool[,] tableroActual = juego.generarTablero(tablero);
            bool[,] tableroEsperado = new bool[5, 5];
            tableroEsperado[0, 0] = false; tableroEsperado[0, 1] = false; tableroEsperado[0, 2] = false; tableroEsperado[0, 3] = false; tableroEsperado[0, 4] = false;
            tableroEsperado[1, 0] = false; tableroEsperado[1, 1] = false; tableroEsperado[1, 2] = false; tableroEsperado[1, 3] = false; tableroEsperado[1, 4] = false;
            tableroEsperado[2, 0] = true; tableroEsperado[2, 1] = true; tableroEsperado[2, 2] = false; tableroEsperado[2, 3] = true; tableroEsperado[2, 4] = true;
            tableroEsperado[3, 0] = false; tableroEsperado[3, 1] = false; tableroEsperado[3, 2] = false; tableroEsperado[3, 3] = false; tableroEsperado[3, 4] = false;
            tableroEsperado[4, 0] = false; tableroEsperado[4, 1] = false; tableroEsperado[4, 2] = false; tableroEsperado[4, 3] = false; tableroEsperado[4, 4] = false;
            // Tablero esperado, la celula unica viva se deberia morir.

            Assert.AreEqual(tableroEsperado, tableroActual);
        }
    }
}
