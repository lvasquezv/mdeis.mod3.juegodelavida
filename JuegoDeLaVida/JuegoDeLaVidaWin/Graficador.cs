using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeLaVidaWin
{
    public class Graficador
    {
        public static Color FONDO = Color.Black;
        public static Color LINEAS = Color.White;
        public static Color CELDA_VIVA = Color.White;
        public static Color CELDA_MUERTA = Color.Black;
        public static void GraficarTablero(Form forma, int initX, int initY, int celda, bool[,] tablero)
        {
            GraficarCuadro(forma, FONDO, initX, initY, initX + (tablero.GetLength(1) * celda), initY + (tablero.GetLength(0) * celda));
            for (int c = 0; c < tablero.GetLength(1); c++)
            {
                for (int f = 0; f < tablero.GetLength(0); f++)
                {
                    GraficarCuadro(forma, tablero[c, f] ? CELDA_VIVA : CELDA_MUERTA, initX + (c * celda), initY + (f * celda), celda);
                }
            }
        }
        public static void GraficarCuadro(Form forma, Color color, int x, int y, int ancho)
        {            
            SolidBrush solidBrush = new SolidBrush(color);
            Pen pen = new Pen(LINEAS);
            Graphics g = forma.CreateGraphics();            
            g.FillRectangle(solidBrush, x, y, ancho, ancho);
            g.DrawRectangle(pen, x, y, ancho, ancho);
        }
        public static void GraficarCuadro(Form forma, Color color, int x, int y, int anchoX, int anchoY)
        {
            SolidBrush solidBrush = new SolidBrush(color);
            Graphics g = forma.CreateGraphics();
            g.FillRectangle(solidBrush, x, y, anchoX, anchoY);
        }
    }
}
