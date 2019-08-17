using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVidaLib
{
    public class Juego
    {
        public bool[,] generar(bool[,] tableroBase, int posX, int posY)
        {
            bool[,] tablero = new bool[5, 5];
            tablero[0, 0] = false; tablero[0, 1] = false; tablero[0, 2] = false; tablero[0, 3] = false; tablero[0, 4] = false;
            tablero[1, 0] = false; tablero[1, 1] = false; tablero[1, 2] = false; tablero[1, 3] = false; tablero[1, 4] = false;
            tablero[2, 0] = false; tablero[2, 1] = false; tablero[2, 2] = false; tablero[2, 3] = false; tablero[2, 4] = false;
            tablero[3, 0] = false; tablero[3, 1] = false; tablero[3, 2] = false; tablero[3, 3] = false; tablero[3, 4] = false;
            tablero[4, 0] = false; tablero[4, 1] = false; tablero[4, 2] = false; tablero[4, 3] = false; tablero[4, 4] = false;
            return tablero;
        }
    }
}
