using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVidaLib
{
    public class Juego
    {
        public const char TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE = 'A';
        public const char TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE = 'B';

        public bool[,] generar(bool[,] tableroBase, int posX, int posY)
        {
            bool[,] tablero = (bool[,])tableroBase.Clone();
            if (obtenerTipo(tableroBase, posX, posY).Equals(TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE))
                tablero[posX, posY] = false;
            if (obtenerTipo(tableroBase, posX, posY).Equals(TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE))
                tablero[posX, posY] = true;
            return tablero;
        }
        public char obtenerTipo(bool[,] tableroBase, int posX, int posY)
        {
            int cantidadVecinaViva = 0;
            if (posX > 0 && tableroBase[posX - 1, posY]) cantidadVecinaViva++;
            if (posX < tableroBase.GetLength(1)-1 && tableroBase[posX + 1, posY]) cantidadVecinaViva++;
            if (posY > 0 && tableroBase[posX, posY-1]) cantidadVecinaViva++;
            if (posY > tableroBase.GetLength(0) - 1 && tableroBase[posX, posY+1]) cantidadVecinaViva++;

            if (cantidadVecinaViva < 2) return TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE;
            else return TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE;
        }
    }
}
