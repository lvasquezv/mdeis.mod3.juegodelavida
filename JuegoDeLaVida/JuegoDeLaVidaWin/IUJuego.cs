using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JuegoDeLaVidaWin
{
    public partial class IUJuego : Form
    {
        public int _iniX { get; set; }
        public int _iniY { get; set; }        
        public bool [,] _tablero { get; set; }

        private JuegoDeLaVidaLib.Juego juego = new JuegoDeLaVidaLib.Juego();

        public IUJuego()
        {
            InitializeComponent();           
            nuevo();
        }

        private void nuevo()
        {
            timer1.Stop();
            _iniX = 10;
            _iniY = 100;
            //_tablero = new bool[int.Parse(txCantColumnas.Text), int.Parse(txCantFilas.Text)];
            _tablero = new bool[25, 25];
            _tablero[0, 0] = false; _tablero[0, 1] = false; _tablero[0, 2] = false; _tablero[0, 3] = false; _tablero[0, 4] = false;
            _tablero[1, 0] = false; _tablero[1, 1] = true; _tablero[1, 2] = false; _tablero[1, 3] = false; _tablero[1, 4] = true;
            _tablero[2, 0] = false; _tablero[2, 1] = true; _tablero[2, 2] = false; _tablero[2, 3] = false; _tablero[2, 4] = true;
            _tablero[3, 0] = false; _tablero[3, 1] = true; _tablero[3, 2] = false; _tablero[3, 3] = false; _tablero[3, 4] = true;
            _tablero[4, 0] = false; _tablero[4, 1] = false; _tablero[4, 2] = false; _tablero[4, 3] = false; _tablero[4, 4] = true;
            Graficador.GraficarTablero(this, _iniX, _iniY, int.Parse(cmbCelda.Text),_tablero);
        }
        private void ejecutar()
        {
            timer1.Interval = (int.Parse(cmbIntervaloTiempoEnSegundos.Text)*1000);
            timer1.Start();

        }
        private void pausar()
        {
            timer1.Stop();
        }
        private void siguiente()
        {
            _tablero = juego.generarTablero(_tablero);
            Graficador.GraficarTablero(this, _iniX, _iniY, int.Parse(cmbCelda.Text), _tablero);
        }
        
        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            nuevo();
        }

        private void BtnEjecutar_Click(object sender, EventArgs e)
        {
            ejecutar();
        }

        private void BtnPausar_Click(object sender, EventArgs e)
        {
            pausar();
        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            siguiente();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer1.Enabled)
            siguiente();
        }
    }
}
