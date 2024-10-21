using System;
using System.Windows.Forms;

namespace procesoDeHilos
{
    public partial class frmJuego : Form
    {
        public frmJuego()
        {
            InitializeComponent();
        }

        bool glMoverAbajo = true; 
        int gnMovimientoVertical = 0; 
        const int gnGravedad = 1;
        const float gnRebote = 0.8f;

        private void frmJuego_Load(object sender, EventArgs e)
        {
            picUFO.ImageLocation = Application.StartupPath + "//balon.png";
            picUFO.Top = this.ClientSize.Height / 2; 
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            tmrUFO.Enabled = true;
        }

        private void tmrUFO_Tick(object sender, EventArgs e)
        {
            if (glMoverAbajo)
            {
                gnMovimientoVertical += gnGravedad;
                picUFO.Top += gnMovimientoVertical; 
            }
            else
            {
                picUFO.Top -= gnMovimientoVertical; 
                gnMovimientoVertical -= gnGravedad; 

                if (gnMovimientoVertical < 0)
                    gnMovimientoVertical = 0;
            }

            if (picUFO.Bottom >= this.ClientSize.Height)
            {
                picUFO.Top = this.ClientSize.Height - picUFO.Height; 
                glMoverAbajo = false; 
                gnMovimientoVertical = (int)(gnMovimientoVertical * gnRebote); 
            }

            if (picUFO.Top <= 0)
            {
                picUFO.Top = 0; 
                glMoverAbajo = true; 
            }

            if (!glMoverAbajo && gnMovimientoVertical < 1)
            {
                gnMovimientoVertical = 0; 
                glMoverAbajo = true; 
            }
        }
    }
}
