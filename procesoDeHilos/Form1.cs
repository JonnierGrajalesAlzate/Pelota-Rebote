using System;
using System.Windows.Forms;
/*Jonnier Grajales Alzate
 21/10/2024
 Pelota Rebote - Juego*/

namespace procesoDeHilos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnJuego_Click(object sender, EventArgs e)
        {
            frmJuego nuevoFormulario = new frmJuego();
            this.Hide();
            nuevoFormulario.FormClosed += (s, args) => this.Close();
            nuevoFormulario.Show();
        }
    }
}
