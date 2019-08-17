using System;
using System.Collections.Generic;
using System.Text;

namespace JuegoDeLaVidaLib
{
    public class Juego
    {
        public const char TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE = 'A';
        public const char TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE = 'B';
        public const char TIPO_VIVA_CONMASDETRESVECINASVIVAS_MUERE = 'C';
        public const char TIPO_MUERTA_CONTRESVECINASVIVAS_VIVE = 'D';
        public const char TIPO_MUERTA_CONDIFERENTEDETRESVECINASVIVAS_MUERE = 'E';

        public bool[,] generarTablero(bool[,] tableroBase)
        {
            bool[,] tablero = (bool[,])tableroBase.Clone();
            for (int x = 0; x < tablero.GetLength(1); x++)
            {
                for (int y = 0; y < tablero.GetLength(0); y++)
                {
                    tablero[x, y] = generarCelda(tableroBase, x, y, tableroBase[x, y]);
                }
            }
            return tablero;
        }
        private bool generarCelda(bool[,] tableroBase, int posX, int posY, bool estado)
        {
            char tipo = obtenerTipo(tableroBase, posX, posY, estado);
            if (tipo.Equals(TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE) || tipo.Equals(TIPO_MUERTA_CONTRESVECINASVIVAS_VIVE))
                return true;
            else
                return false;
        }
        public bool[,] generar(bool[,] tableroBase, int posX, int posY, bool estado)
        {
            bool[,] tablero = (bool[,])tableroBase.Clone();
            char tipo = obtenerTipo(tableroBase, posX, posY, estado);
            if (tipo.Equals(TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE))
                tablero[posX, posY] = false;
            if (tipo.Equals(TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE))
                tablero[posX, posY] = true;
            if (tipo.Equals(TIPO_VIVA_CONMASDETRESVECINASVIVAS_MUERE))
                tablero[posX, posY] = false;
            if (tipo.Equals(TIPO_MUERTA_CONTRESVECINASVIVAS_VIVE))
                tablero[posX, posY] = true;
            if (tipo.Equals(TIPO_MUERTA_CONDIFERENTEDETRESVECINASVIVAS_MUERE))
                tablero[posX, posY] = false;
            return tablero;
        }
        public char obtenerTipo(bool[,] tableroBase, int posX, int posY, bool estado)
        {
            int cantidadVecinaViva = 0;

            if (posX > 0 && tableroBase[posX - 1, posY]) cantidadVecinaViva++;
            if (posX < tableroBase.GetLength(1)-1 && tableroBase[posX + 1, posY]) cantidadVecinaViva++;
            if (posY > 0 && tableroBase[posX, posY-1]) cantidadVecinaViva++;
            if (posY < tableroBase.GetLength(0) - 1 && tableroBase[posX, posY+1]) cantidadVecinaViva++;


            if (posX > 0 && posY > 0 && tableroBase[posX - 1, posY - 1]) cantidadVecinaViva++;
            if (posX > 0 && posY < tableroBase.GetLength(0) - 1 && tableroBase[posX - 1, posY + 1]) cantidadVecinaViva++;
            if (posX < tableroBase.GetLength(1) - 1 && posY > 0 && tableroBase[posX + 1, posY - 1]) cantidadVecinaViva++;
            if (posX < tableroBase.GetLength(1) - 1 && posY < tableroBase.GetLength(0) - 1 && tableroBase[posX + 1, posY + 1]) cantidadVecinaViva++;

            if (estado)
            {
                if (cantidadVecinaViva < 2) return TIPO_VIVA_CONMENOSDEDOSVECINASVIVAS_MUERE;
                else if (cantidadVecinaViva < 4) return TIPO_VIVA_CONDOSTRESVECINASVIVAS_VIVE;
                else return TIPO_VIVA_CONMASDETRESVECINASVIVAS_MUERE;
            }
            else
            {
                if (cantidadVecinaViva == 3) return TIPO_MUERTA_CONTRESVECINASVIVAS_VIVE;
                else return TIPO_MUERTA_CONDIFERENTEDETRESVECINASVIVAS_MUERE;
            }
            
        }
    }
}
